namespace Server
{
    partial class Server
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnStart = new CCWin.SkinControl.SkinButton();
            this.txtIP = new CCWin.SkinControl.SkinTextBox();
            this.txtPort = new CCWin.SkinControl.SkinTextBox();
            this.txtContent = new CCWin.SkinControl.RtfRichTextBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.btnEnter = new CCWin.SkinControl.SkinButton();
            this.cbbIP = new System.Windows.Forms.ComboBox();
            this.txtSend = new CCWin.SkinControl.RtfRichTextBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.BaseColor = System.Drawing.Color.LightGray;
            this.btnStart.BorderColor = System.Drawing.Color.Black;
            this.btnStart.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnStart.DownBack = null;
            this.btnStart.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnStart.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(11, 42);
            this.btnStart.MouseBack = null;
            this.btnStart.Name = "btnStart";
            this.btnStart.NormlBack = null;
            this.btnStart.Size = new System.Drawing.Size(92, 27);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "启动服务";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtIP
            // 
            this.txtIP.BackColor = System.Drawing.Color.Transparent;
            this.txtIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIP.DownBack = null;
            this.txtIP.Icon = null;
            this.txtIP.IconIsButton = false;
            this.txtIP.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtIP.IsPasswordChat = '\0';
            this.txtIP.IsSystemPasswordChar = false;
            this.txtIP.Lines = new string[] {
        "127.0.0.1"};
            this.txtIP.Location = new System.Drawing.Point(106, 42);
            this.txtIP.Margin = new System.Windows.Forms.Padding(0);
            this.txtIP.MaxLength = 32767;
            this.txtIP.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtIP.MouseBack = null;
            this.txtIP.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtIP.Multiline = false;
            this.txtIP.Name = "txtIP";
            this.txtIP.NormlBack = null;
            this.txtIP.Padding = new System.Windows.Forms.Padding(5);
            this.txtIP.ReadOnly = false;
            this.txtIP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIP.Size = new System.Drawing.Size(205, 28);
            // 
            // 
            // 
            this.txtIP.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIP.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtIP.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtIP.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtIP.SkinTxt.Name = "BaseText";
            this.txtIP.SkinTxt.Size = new System.Drawing.Size(193, 18);
            this.txtIP.SkinTxt.TabIndex = 0;
            this.txtIP.SkinTxt.Text = "127.0.0.1";
            this.txtIP.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtIP.SkinTxt.WaterText = "";
            this.txtIP.TabIndex = 1;
            this.txtIP.Text = "127.0.0.1";
            this.txtIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIP.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtIP.WaterText = "";
            this.txtIP.WordWrap = true;
            // 
            // txtPort
            // 
            this.txtPort.BackColor = System.Drawing.Color.Transparent;
            this.txtPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPort.DownBack = null;
            this.txtPort.Icon = null;
            this.txtPort.IconIsButton = false;
            this.txtPort.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtPort.IsPasswordChat = '\0';
            this.txtPort.IsSystemPasswordChar = false;
            this.txtPort.Lines = new string[] {
        "37280"};
            this.txtPort.Location = new System.Drawing.Point(315, 42);
            this.txtPort.Margin = new System.Windows.Forms.Padding(0);
            this.txtPort.MaxLength = 32767;
            this.txtPort.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtPort.MouseBack = null;
            this.txtPort.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtPort.Multiline = false;
            this.txtPort.Name = "txtPort";
            this.txtPort.NormlBack = null;
            this.txtPort.Padding = new System.Windows.Forms.Padding(5);
            this.txtPort.ReadOnly = false;
            this.txtPort.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPort.Size = new System.Drawing.Size(75, 28);
            // 
            // 
            // 
            this.txtPort.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPort.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPort.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtPort.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtPort.SkinTxt.Name = "BaseText";
            this.txtPort.SkinTxt.Size = new System.Drawing.Size(63, 18);
            this.txtPort.SkinTxt.TabIndex = 0;
            this.txtPort.SkinTxt.Text = "37280";
            this.txtPort.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtPort.SkinTxt.WaterText = "";
            this.txtPort.TabIndex = 2;
            this.txtPort.Text = "37280";
            this.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPort.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtPort.WaterText = "";
            this.txtPort.WordWrap = true;
            // 
            // txtContent
            // 
            this.txtContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContent.HiglightColor = CCWin.SkinControl.RtfRichTextBox.RtfColor.White;
            this.txtContent.Location = new System.Drawing.Point(12, 76);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(531, 358);
            this.txtContent.TabIndex = 3;
            this.txtContent.Text = "";
            this.txtContent.TextColor = CCWin.SkinControl.RtfRichTextBox.RtfColor.Black;
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(8, 623);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(80, 17);
            this.skinLabel1.TabIndex = 4;
            this.skinLabel1.Text = "  选择客户端 ";
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.Transparent;
            this.btnEnter.BaseColor = System.Drawing.Color.LightGray;
            this.btnEnter.BorderColor = System.Drawing.Color.Black;
            this.btnEnter.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnEnter.DownBack = null;
            this.btnEnter.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEnter.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(558, 584);
            this.btnEnter.MouseBack = null;
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.NormlBack = null;
            this.btnEnter.Size = new System.Drawing.Size(92, 27);
            this.btnEnter.TabIndex = 6;
            this.btnEnter.Text = "发送";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // cbbIP
            // 
            this.cbbIP.FormattingEnabled = true;
            this.cbbIP.Location = new System.Drawing.Point(94, 617);
            this.cbbIP.Name = "cbbIP";
            this.cbbIP.Size = new System.Drawing.Size(220, 20);
            this.cbbIP.TabIndex = 7;
            // 
            // txtSend
            // 
            this.txtSend.HiglightColor = CCWin.SkinControl.RtfRichTextBox.RtfColor.White;
            this.txtSend.Location = new System.Drawing.Point(12, 440);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(531, 171);
            this.txtSend.TabIndex = 8;
            this.txtSend.Text = "";
            this.txtSend.TextColor = CCWin.SkinControl.RtfRichTextBox.RtfColor.Black;
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CaptionFont = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientSize = new System.Drawing.Size(661, 648);
            this.Controls.Add(this.txtSend);
            this.Controls.Add(this.cbbIP);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.btnStart);
            this.Name = "Server";
            this.Text = "Server端";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinButton btnStart;
        private CCWin.SkinControl.SkinTextBox txtIP;
        private CCWin.SkinControl.SkinTextBox txtPort;
        private CCWin.SkinControl.RtfRichTextBox txtContent;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinButton btnEnter;
        private System.Windows.Forms.ComboBox cbbIP;
        private CCWin.SkinControl.RtfRichTextBox txtSend;
    }
}

