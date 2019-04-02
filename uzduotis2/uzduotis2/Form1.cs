using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;

namespace uzduotis2
{
    public partial class l : Form
    {
        TcpClient clientSocket = new TcpClient();
        NetworkStream serverStream = default(NetworkStream);
        string readData = null;


        public l()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ConnectionButton_Click(object sender, EventArgs e)
        {
            clientSocket.Connect(textBox1.Text, Int32.Parse(textBox2.Text));

            Thread ctThread = new Thread(getMessage);
            ctThread.Start();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void getMessage()
        {
            string returnData;

            while (true)
            {
                serverStream = clientSocket.GetStream();
                var buffSize = clientSocket.ReceiveBufferSize;
                byte[] instream = new byte[buffSize];

                serverStream.Read(instream, 0, buffSize);

                returnData = System.Text.Encoding.ASCII.GetString(instream);
                readData = returnData;
                msg();
            }
        }
        private void msg()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(msg));
            }
            else
            {
                IncomingMessageTextBox.Text = readData;
            }
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            byte[] outstream = Encoding.ASCII.GetBytes(OutcomingMessageTextBox.Text);

            serverStream.Write(outstream, 0, outstream.Length);
            serverStream.Flush();
        }
    }
}
