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

namespace Server
{
    public partial class Server : Skin_VS
    {
        public Server()
        {
            InitializeComponent();
        }

        private Socket serverSocket;
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

            serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            serverSocket.Bind(new IPEndPoint(ip, port));  //绑定IP地址：端口
            serverSocket.Listen(10);    //设定最多10个排队连接请求
            OutputContent(string.Format("启动监听{0}成功", serverSocket.LocalEndPoint.ToString()));

        }

        private void ListenClientConnect()
        {
            while (true)
            {
                string strSend = txtSend.Text;
                Socket clientSocket = serverSocket.Accept();
                clientSocket.Send(Encoding.ASCII.GetBytes(strSend));
                txtSend.Clear();
                Thread receiveThread = new Thread(ReceiveMessage);
                receiveThread.Start(clientSocket);
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
                    int receiveNumber = myClientSocket.Receive(result);
                    OutputContent(string.Format("接收客户端{0}消息{1}", myClientSocket.RemoteEndPoint.ToString(), Encoding.ASCII.GetString(result, 0, receiveNumber)));

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

        private void btnEnter_Click(object sender, EventArgs e)
        {
            //通过Clientsoket发送数据
            Thread myThread = new Thread(ListenClientConnect);
            myThread.Start();
        }
        private void OutputContent(string content)
        {
            txtContent.ForeColor = Color.FromArgb(100, 225, 0);
            txtContent.Text += content + "\r\n";
        }
    }
}
