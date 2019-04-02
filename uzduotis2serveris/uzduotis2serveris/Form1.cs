using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace uzduotis2serveris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TcpListener server = new TcpListener(IPAddress.Parse(textBox1.Text), Int32.Parse(textBox2.Text));
            server.Start();
            
            while (true)
            {
                TcpClient client = server.AcceptTcpClient();
                NetworkStream ns = client.GetStream();
                byte[] hello = new byte[100];
                hello = Encoding.Default.GetBytes("hello world");
                ns.Write(hello, 0, hello.Length);
                while (client.Connected)  //while the client is connected, we look for incoming messages
                {
                    byte[] msg = new byte[1024];     //the messages arrive as byte array
                    ns.Read(msg, 0, msg.Length);   //the same networkstream reads the message sent by the client
                    DirectoryInfo directory = new DirectoryInfo(Encoding.Default.GetString(msg).Trim());//now , we write the message as string
                    FileInfo[] Files = directory.GetFiles();
                    foreach (FileInfo file in Files)
                    {
                        byte[] info = new byte[100];
                        info = Encoding.Default.GetBytes(file.Name);
                        ns.Write(info, 0, file.Name.Length);
                    }
                }

            }
        }
    }
}
