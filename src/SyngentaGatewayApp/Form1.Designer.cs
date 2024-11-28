namespace SyngentaGatewayApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel3 = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            panel7 = new Panel();
            label8 = new Label();
            txtServerRead = new TextBox();
            panel6 = new Panel();
            label7 = new Label();
            txtServerSend = new TextBox();
            panel2 = new Panel();
            txtURL = new TextBox();
            button2 = new Button();
            button1 = new Button();
            bntServerRead = new Button();
            btnServerSend = new Button();
            pnAppSerStatus = new Panel();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtServerPort = new TextBox();
            txtServerIP = new TextBox();
            btnCloseSer = new Button();
            btnOpenSer = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel5 = new Panel();
            tableLayoutPanel5 = new TableLayoutPanel();
            panel9 = new Panel();
            label10 = new Label();
            txtReadPrinter = new TextBox();
            panel8 = new Panel();
            label9 = new Label();
            txtSendToPrinter = new TextBox();
            panel4 = new Panel();
            btnReadPrinter = new Button();
            pnPrinterStatus = new Panel();
            btnSendPrinter = new Button();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtPrinterPort = new TextBox();
            txtPrinterIP = new TextBox();
            btnDisconnectPrinter = new Button();
            btnConnectPrinter = new Button();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel5.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1065, 681);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.7981224F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.2018776F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1065, 681);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(panel3, 0, 1);
            tableLayoutPanel2.Controls.Add(panel2, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 249F));
            tableLayoutPanel2.Size = new Size(535, 675);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(tableLayoutPanel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 429);
            panel3.Name = "panel3";
            panel3.Size = new Size(529, 243);
            panel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 266F));
            tableLayoutPanel4.Controls.Add(panel7, 1, 0);
            tableLayoutPanel4.Controls.Add(panel6, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(529, 243);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.ActiveCaption;
            panel7.Controls.Add(label8);
            panel7.Controls.Add(txtServerRead);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(266, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(260, 237);
            panel7.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Top;
            label8.Location = new Point(0, 0);
            label8.Name = "label8";
            label8.Size = new Size(149, 20);
            label8.TabIndex = 13;
            label8.Text = "App Server Received:";
            // 
            // txtServerRead
            // 
            txtServerRead.Dock = DockStyle.Bottom;
            txtServerRead.Location = new Point(0, 28);
            txtServerRead.Multiline = true;
            txtServerRead.Name = "txtServerRead";
            txtServerRead.Size = new Size(260, 209);
            txtServerRead.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ActiveCaption;
            panel6.Controls.Add(label7);
            panel6.Controls.Add(txtServerSend);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(3, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(257, 237);
            panel6.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Top;
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(122, 20);
            label7.TabIndex = 12;
            label7.Text = "App Server Send:";
            // 
            // txtServerSend
            // 
            txtServerSend.Dock = DockStyle.Bottom;
            txtServerSend.Location = new Point(0, 28);
            txtServerSend.Multiline = true;
            txtServerSend.Name = "txtServerSend";
            txtServerSend.Size = new Size(257, 209);
            txtServerSend.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(txtURL);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(bntServerRead);
            panel2.Controls.Add(btnServerSend);
            panel2.Controls.Add(pnAppSerStatus);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtServerPort);
            panel2.Controls.Add(txtServerIP);
            panel2.Controls.Add(btnCloseSer);
            panel2.Controls.Add(btnOpenSer);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(529, 420);
            panel2.TabIndex = 0;
            // 
            // txtURL
            // 
            txtURL.Location = new Point(11, 229);
            txtURL.Multiline = true;
            txtURL.Name = "txtURL";
            txtURL.Size = new Size(498, 82);
            txtURL.TabIndex = 16;
            txtURL.Text = "http://192.168.10.15:8080/TrackAndTraceServer/report/batchList?fromDate=12/11/2024&toDate=19/11/2024&lineId=0&isDatewisePosting=false&isReework=false";
            // 
            // button2
            // 
            button2.Location = new Point(350, 369);
            button2.Name = "button2";
            button2.Size = new Size(159, 29);
            button2.TabIndex = 15;
            button2.Text = "Get API";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_ClickAsync;
            // 
            // button1
            // 
            button1.Location = new Point(350, 334);
            button1.Name = "button1";
            button1.Size = new Size(159, 29);
            button1.TabIndex = 14;
            button1.Text = "Get Token";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // bntServerRead
            // 
            bntServerRead.Location = new Point(185, 369);
            bntServerRead.Name = "bntServerRead";
            bntServerRead.Size = new Size(159, 29);
            bntServerRead.TabIndex = 13;
            bntServerRead.Text = "Server Read";
            bntServerRead.UseVisualStyleBackColor = true;
            bntServerRead.Click += bntServerRead_Click;
            // 
            // btnServerSend
            // 
            btnServerSend.Location = new Point(185, 334);
            btnServerSend.Name = "btnServerSend";
            btnServerSend.Size = new Size(159, 29);
            btnServerSend.TabIndex = 12;
            btnServerSend.Text = "Server Send";
            btnServerSend.UseVisualStyleBackColor = true;
            btnServerSend.Click += btnServerSend_Click;
            // 
            // pnAppSerStatus
            // 
            pnAppSerStatus.BackColor = Color.DarkGray;
            pnAppSerStatus.Location = new Point(469, 0);
            pnAppSerStatus.Name = "pnAppSerStatus";
            pnAppSerStatus.Size = new Size(57, 45);
            pnAppSerStatus.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 3);
            label5.Name = "label5";
            label5.Size = new Size(82, 20);
            label5.TabIndex = 10;
            label5.Text = "App Server";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 71);
            label2.Name = "label2";
            label2.Size = new Size(115, 20);
            label2.TabIndex = 7;
            label2.Text = "App Server Port:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 37);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 6;
            label1.Text = "App Server IP:";
            // 
            // txtServerPort
            // 
            txtServerPort.Location = new Point(129, 68);
            txtServerPort.Name = "txtServerPort";
            txtServerPort.Size = new Size(179, 27);
            txtServerPort.TabIndex = 3;
            txtServerPort.Text = "9100";
            // 
            // txtServerIP
            // 
            txtServerIP.Location = new Point(129, 34);
            txtServerIP.Name = "txtServerIP";
            txtServerIP.Size = new Size(179, 27);
            txtServerIP.TabIndex = 2;
            txtServerIP.Text = "127.0.0.1";
            // 
            // btnCloseSer
            // 
            btnCloseSer.Location = new Point(11, 369);
            btnCloseSer.Name = "btnCloseSer";
            btnCloseSer.Size = new Size(159, 29);
            btnCloseSer.TabIndex = 1;
            btnCloseSer.Text = "Close Server";
            btnCloseSer.UseVisualStyleBackColor = true;
            btnCloseSer.Click += btnCloseSer_Click;
            // 
            // btnOpenSer
            // 
            btnOpenSer.Location = new Point(11, 334);
            btnOpenSer.Name = "btnOpenSer";
            btnOpenSer.Size = new Size(159, 29);
            btnOpenSer.TabIndex = 0;
            btnOpenSer.Text = "Open Server";
            btnOpenSer.UseVisualStyleBackColor = true;
            btnOpenSer.Click += btnOpenSer_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(panel5, 0, 1);
            tableLayoutPanel3.Controls.Add(panel4, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(544, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 35.4074059F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 64.59259F));
            tableLayoutPanel3.Size = new Size(518, 675);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(tableLayoutPanel5);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(3, 241);
            panel5.Name = "panel5";
            panel5.Size = new Size(512, 431);
            panel5.TabIndex = 2;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 266F));
            tableLayoutPanel5.Controls.Add(panel9, 1, 0);
            tableLayoutPanel5.Controls.Add(panel8, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(512, 431);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // panel9
            // 
            panel9.BackColor = SystemColors.ActiveCaption;
            panel9.Controls.Add(label10);
            panel9.Controls.Add(txtReadPrinter);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(249, 3);
            panel9.Name = "panel9";
            panel9.Size = new Size(260, 425);
            panel9.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = DockStyle.Top;
            label10.Location = new Point(0, 0);
            label10.Name = "label10";
            label10.Size = new Size(131, 20);
            label10.TabIndex = 15;
            label10.Text = "Read From Printer:";
            // 
            // txtReadPrinter
            // 
            txtReadPrinter.Dock = DockStyle.Bottom;
            txtReadPrinter.Location = new Point(0, 42);
            txtReadPrinter.Multiline = true;
            txtReadPrinter.Name = "txtReadPrinter";
            txtReadPrinter.Size = new Size(260, 383);
            txtReadPrinter.TabIndex = 2;
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.ActiveCaption;
            panel8.Controls.Add(label9);
            panel8.Controls.Add(txtSendToPrinter);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(3, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(240, 425);
            panel8.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Top;
            label9.Location = new Point(0, 0);
            label9.Name = "label9";
            label9.Size = new Size(112, 20);
            label9.TabIndex = 14;
            label9.Text = "Send To Printer:";
            // 
            // txtSendToPrinter
            // 
            txtSendToPrinter.Dock = DockStyle.Bottom;
            txtSendToPrinter.Location = new Point(0, 42);
            txtSendToPrinter.Multiline = true;
            txtSendToPrinter.Name = "txtSendToPrinter";
            txtSendToPrinter.Size = new Size(240, 383);
            txtSendToPrinter.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.Controls.Add(btnReadPrinter);
            panel4.Controls.Add(pnPrinterStatus);
            panel4.Controls.Add(btnSendPrinter);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(txtPrinterPort);
            panel4.Controls.Add(txtPrinterIP);
            panel4.Controls.Add(btnDisconnectPrinter);
            panel4.Controls.Add(btnConnectPrinter);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(512, 232);
            panel4.TabIndex = 1;
            // 
            // btnReadPrinter
            // 
            btnReadPrinter.Location = new Point(188, 190);
            btnReadPrinter.Name = "btnReadPrinter";
            btnReadPrinter.Size = new Size(159, 29);
            btnReadPrinter.TabIndex = 15;
            btnReadPrinter.Text = "Read From Printer";
            btnReadPrinter.UseVisualStyleBackColor = true;
            // 
            // pnPrinterStatus
            // 
            pnPrinterStatus.BackColor = Color.DarkGray;
            pnPrinterStatus.Location = new Point(454, 0);
            pnPrinterStatus.Name = "pnPrinterStatus";
            pnPrinterStatus.Size = new Size(55, 45);
            pnPrinterStatus.TabIndex = 12;
            // 
            // btnSendPrinter
            // 
            btnSendPrinter.Location = new Point(188, 155);
            btnSendPrinter.Name = "btnSendPrinter";
            btnSendPrinter.Size = new Size(159, 29);
            btnSendPrinter.TabIndex = 14;
            btnSendPrinter.Text = "Send To Printer";
            btnSendPrinter.UseVisualStyleBackColor = true;
            btnSendPrinter.Click += btnSendPrinter_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 3);
            label6.Name = "label6";
            label6.Size = new Size(110, 20);
            label6.TabIndex = 11;
            label6.Text = "Connect Printer";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 113);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 9;
            label4.Text = "Printer Port:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 59);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 8;
            label3.Text = "Printer IP:";
            // 
            // txtPrinterPort
            // 
            txtPrinterPort.Location = new Point(102, 110);
            txtPrinterPort.Name = "txtPrinterPort";
            txtPrinterPort.Size = new Size(179, 27);
            txtPrinterPort.TabIndex = 5;
            txtPrinterPort.Text = "9100";
            // 
            // txtPrinterIP
            // 
            txtPrinterIP.Location = new Point(102, 54);
            txtPrinterIP.Name = "txtPrinterIP";
            txtPrinterIP.Size = new Size(179, 27);
            txtPrinterIP.TabIndex = 4;
            txtPrinterIP.Text = "127.0.0.1";
            // 
            // btnDisconnectPrinter
            // 
            btnDisconnectPrinter.Location = new Point(12, 190);
            btnDisconnectPrinter.Name = "btnDisconnectPrinter";
            btnDisconnectPrinter.Size = new Size(170, 29);
            btnDisconnectPrinter.TabIndex = 1;
            btnDisconnectPrinter.Text = "Disconnect Printer";
            btnDisconnectPrinter.UseVisualStyleBackColor = true;
            btnDisconnectPrinter.Click += btnDisconnectPrinter_Click;
            // 
            // btnConnectPrinter
            // 
            btnConnectPrinter.Location = new Point(12, 155);
            btnConnectPrinter.Name = "btnConnectPrinter";
            btnConnectPrinter.Size = new Size(170, 29);
            btnConnectPrinter.TabIndex = 0;
            btnConnectPrinter.Text = "Connect Printer";
            btnConnectPrinter.UseVisualStyleBackColor = true;
            btnConnectPrinter.Click += btnConnectPrinter_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1065, 681);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel3;
        private Panel panel2;
        private Button btnCloseSer;
        private Button btnOpenSer;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel5;
        private Panel panel4;
        private Button btnDisconnectPrinter;
        private Button btnConnectPrinter;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panel7;
        private TextBox txtServerRead;
        private Panel panel6;
        private TextBox txtServerSend;
        private TextBox txtServerPort;
        private TextBox txtServerIP;
        private TableLayoutPanel tableLayoutPanel5;
        private Panel panel9;
        private TextBox txtReadPrinter;
        private Panel panel8;
        private TextBox txtSendToPrinter;
        private TextBox txtPrinterPort;
        private TextBox txtPrinterIP;
        private Label label8;
        private Label label7;
        private Panel pnAppSerStatus;
        private Label label5;
        private Label label2;
        private Label label1;
        private Label label10;
        private Label label9;
        private Panel pnPrinterStatus;
        private Label label6;
        private Label label4;
        private Label label3;
        private Button bntServerRead;
        private Button btnServerSend;
        private Button btnReadPrinter;
        private Button btnSendPrinter;
        private Button button1;
        private Button button2;
        private TextBox txtURL;
    }
}
