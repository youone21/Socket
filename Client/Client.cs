using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin;

namespace Client
{
    public partial class Client : Skin_VS
    {
        public Client()
        {
            InitializeComponent();
        }

        private Socket clientSocket;
        private static byte[] result = new byte[1024];

        private void btnStart_Click(object sender, EventArgs e)
        {
            string ipAddress = txtIP.Text;
            int port = int.Parse(txtPort.Text);
            if (string.IsNullOrWhiteSpace(ipAddress))
            {
                OutputContent("IP地址不能为空！");
                return;
            }
            // 设定服务器IP地址
            IPAddress ip = IPAddress.Parse(ipAddress);

            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                clientSocket.Connect(new IPEndPoint(ip, port)); //配置服务器IP与端口
                OutputContent("连接服务器成功");
            }
            catch
            {
                OutputContent("连接服务器失败，请按回车键退出！");
                return;
            }
            while (true)
            {
                Thread receiveThread = new Thread(ReceiveMessage);
                receiveThread.Start(clientSocket);
                //通过clientSocket接收数据
            }
        }

        private void ReceiveMessage(object clientSocket)
        {
            Socket myClientSocket = (Socket)clientSocket;
            while (true)
            {
                try
                {
                    //通过clientSocket接收数据
                    int receiveLength = myClientSocket.Receive(result);
                    OutputContent(string.Format("接收客户端{0}消息{1}", myClientSocket.RemoteEndPoint.ToString(), Encoding.ASCII.GetString(result, 0, receiveLength)));

                }
                catch (Exception ex)
                {
                    OutputContent(ex.Message);
                    myClientSocket.Shutdown(SocketShutdown.Both);
                    myClientSocket.Close();
                    break;
                }
            }
        }

        /// <summary>
        /// 通过 clientSocket 发送数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                Thread.Sleep(1000);    //等待1秒钟
                string sendMessage = "client send Message Hellp" + DateTime.Now;
                clientSocket.Send(Encoding.ASCII.GetBytes(sendMessage));
                OutputContent(string.Format("向服务器发送消息：{0}" + sendMessage));
                Thread receiveThread = new Thread(ReceiveMessage);
                receiveThread.Start(clientSocket);
            }
            catch
            {
                clientSocket.Shutdown(SocketShutdown.Both);
                clientSocket.Close();
            }
        }
        private void OutputContent(string content)
        {
            txtContent.ForeColor = Color.FromArgb(100, 225, 0);
            txtContent.Text += content + "\r\n";
        }
    }
}
