using System;
using System.Windows.Forms;
using System.Net.Sockets;
namespace Project01
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class SocketClientForm : Form
    {

        Socket m_socClient;
        private Button cmdSendData;
        private TextBox txtData;
        private TextBox txtDataRx;
        private Button cmdReceiveData;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtIPAddress;
        private Label label2;
        private TextBox txtPort;
        private Button cmdConnect;
        private Button cmdClose;
        private GroupBox groupBox2;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public SocketClientForm()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdConnect = new Button();
            this.cmdSendData = new Button();
            this.txtData = new TextBox();
            this.txtDataRx = new TextBox();
            this.cmdReceiveData = new Button();
            this.groupBox1 = new GroupBox();
            this.cmdClose = new Button();
            this.txtPort = new TextBox();
            this.label2 = new Label();
            this.txtIPAddress = new TextBox();
            this.label1 = new Label();
            this.groupBox2 = new GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdConnect
            // 
            this.cmdConnect.Location = new System.Drawing.Point(64, 72);
            this.cmdConnect.Name = "cmdConnect";
            this.cmdConnect.Size = new System.Drawing.Size(96, 24);
            this.cmdConnect.TabIndex = 0;
            this.cmdConnect.Text = "Connect";
            this.cmdConnect.Click += new EventHandler(this.cmdConnect_Click);
            // 
            // cmdSendData
            // 
            this.cmdSendData.Location = new System.Drawing.Point(360, 128);
            this.cmdSendData.Name = "cmdSendData";
            this.cmdSendData.Size = new System.Drawing.Size(56, 56);
            this.cmdSendData.TabIndex = 2;
            this.cmdSendData.Text = "Tx";
            this.cmdSendData.Click += new EventHandler(this.cmdSendData_Click);
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(8, 128);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(344, 56);
            this.txtData.TabIndex = 3;
            this.txtData.Text = "enter data to send here...";
            // 
            // txtDataRx
            // 
            this.txtDataRx.Enabled = false;
            this.txtDataRx.Location = new System.Drawing.Point(8, 200);
            this.txtDataRx.Multiline = true;
            this.txtDataRx.Name = "txtDataRx";
            this.txtDataRx.Size = new System.Drawing.Size(344, 56);
            this.txtDataRx.TabIndex = 4;
            // 
            // cmdReceiveData
            // 
            this.cmdReceiveData.Location = new System.Drawing.Point(360, 200);
            this.cmdReceiveData.Name = "cmdReceiveData";
            this.cmdReceiveData.Size = new System.Drawing.Size(56, 56);
            this.cmdReceiveData.TabIndex = 5;
            this.cmdReceiveData.Text = "Rx";
            this.cmdReceiveData.Click += new EventHandler(this.cmdReceiveData_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdClose);
            this.groupBox1.Controls.Add(this.txtPort);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtIPAddress);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmdConnect);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 104);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setting";
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(176, 72);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(120, 24);
            this.cmdClose.TabIndex = 5;
            this.cmdClose.Text = "Close";
            this.cmdClose.Click += new EventHandler(this.cmdClose_Click);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(128, 48);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(120, 20);
            this.txtPort.TabIndex = 4;
            this.txtPort.Text = "8221";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(72, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port :";
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Location = new System.Drawing.Point(128, 16);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(248, 20);
            this.txtIPAddress.TabIndex = 2;
            this.txtIPAddress.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Host I.P. Address:";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(0, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(424, 152);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // SocketClientForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(424, 269);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdReceiveData);
            this.Controls.Add(this.txtDataRx);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.cmdSendData);
            this.Controls.Add(this.groupBox2);
            this.Name = "SocketClientForm";
            this.Text = "Socket Client Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new SocketClientForm());
        }

        private void cmdConnect_Click(object sender, EventArgs e)
        {
            try
            {
                //create a new client socket ...
                m_socClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                String szIPSelected = txtIPAddress.Text;
                String szPort = txtPort.Text;
                int alPort = Convert.ToInt16(szPort, 10);

                System.Net.IPAddress remoteIPAddress = System.Net.IPAddress.Parse(szIPSelected);
                System.Net.IPEndPoint remoteEndPoint = new System.Net.IPEndPoint(remoteIPAddress, alPort);
                m_socClient.Connect(remoteEndPoint);
                String szData = "Hello There";
                byte[] byData = System.Text.Encoding.ASCII.GetBytes(szData);
                m_socClient.Send(byData);
            }
            catch (SocketException se)
            {
                MessageBox.Show(se.Message);
            }
        }

        private void cmdSendData_Click(object sender, EventArgs e)
        {
            try
            {
                Object objData = txtData.Text;
                byte[] byData = System.Text.Encoding.ASCII.GetBytes(objData.ToString());
                m_socClient.Send(byData);
            }
            catch (SocketException se)
            {
                MessageBox.Show(se.Message);
            }
        }

        private void cmdReceiveData_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] buffer = new byte[1024];
                int iRx = m_socClient.Receive(buffer);
                char[] chars = new char[iRx];

                System.Text.Decoder d = System.Text.Encoding.UTF8.GetDecoder();
                int charLen = d.GetChars(buffer, 0, iRx, chars, 0);
                String szData = new String(chars);
                txtDataRx.Text = szData;
            }
            catch (SocketException se)
            {
                MessageBox.Show(se.Message);
            }
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            m_socClient.Close();
        }
    }
}
