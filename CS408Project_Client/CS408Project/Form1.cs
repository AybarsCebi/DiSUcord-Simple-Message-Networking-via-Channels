using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS408Project
{
    public partial class Form1 : Form
    {
        List<string> ifusernames = new List<string>();
        List<string> spsusernames = new List<string>();

        Socket if100Socket;
        Socket sps101Socket;
        bool terminating = false;
        bool connected = false;

        bool isifconnect = false;
        bool isspsconnect = false;

        

        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
            sendtoifbutton.Enabled = false;
            sendtospsbutton.Enabled = false;


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void if100richtextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void sps101richtextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void if100button_Click(object sender, EventArgs e)
        {

            isifconnect = !isifconnect;

            if100Socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            string ip = iptextbox.Text;
            string portnum = porttextbox.Text;
            string username = usernametextbox.Text;

            

            if (ip == "" || portnum == "" || username == "") //To aviod empty ip, portnum, usernames
            {
                if100button.BackColor = Color.Red;

            }
            
            else
            {

                int port;
                Thread receiveThread = new Thread(ReceiveIF); //connectiın to the IF room
                if (isifconnect == true)
                {
                    if (Int32.TryParse(porttextbox.Text, out port))
                    {
                        try
                        {
                            if100Socket.Connect(ip, port);                           
                            if100button.BackColor = Color.Green;

                            sendtoifbutton.Enabled = true;


                            connected = true;
                            receiveThread.Start();

                            byte[] name = Encoding.Default.GetBytes("IF:" + usernametextbox.Text);
                            if100Socket.Send(name);

                        }
                        catch
                        {
                            if100richtextbox.AppendText(username + " could not connect to the server!\n");
                        }
                    }
                    else
                    {
                        if100richtextbox.AppendText("Check the port\n");
                    }
                }
                else
                {
                    if100button.BackColor = Color.Red;  //Disconnected to the IF room

                    if100Socket.Close();

                    receiveThread.Abort();
                    sendtoifbutton.Enabled = false;
                    if100richtextbox.AppendText(username + " disconnected to the server!\n");

                }
            }
        }

        private void ReceiveIF() //get data from the server for IF room
        {
            while (connected)
            {
                try
                {
                    Byte[] buffer = new Byte[512];
                    if100Socket.Receive(buffer);

                    string servermessage = Encoding.Default.GetString(buffer);
                    servermessage = servermessage.Substring(0, servermessage.IndexOf("\0"));

                    if100richtextbox.AppendText(servermessage + "\n");
                }
                catch
                {
                    

                    if100Socket.Close();
                    connected = false;
                }

            }
        }

        private void ReceiveSPS() //get data from the server for SPS room
        {
            while (connected)
            {
                try
                {
                    Byte[] buffer = new Byte[512];
                    sps101Socket.Receive(buffer);

                    string servermessage = Encoding.Default.GetString(buffer);
                    servermessage = servermessage.Substring(0, servermessage.IndexOf("\0"));

                    sps101richtextbox.AppendText(servermessage + "\n");
                }
                catch
                {
                    sps101Socket.Close();
                    connected = false;
                }

            }
        }

        private void Form1_FormClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            connected = false;
            terminating = true;
            Environment.Exit(0);
        }

        private void sendtoifbutton_Click(object sender, EventArgs e) 
        {
            string message = messagerichtextbox.Text;
            string username = usernametextbox.Text;
            string messageupdated = username + ": " + message;
            if (message != "" && message.Length <= 512)
            {
                Byte[] buffer = Encoding.Default.GetBytes(messageupdated);
                if100Socket.Send(buffer);
                messagerichtextbox.Clear();
                message = "";


            }
        }

        private void messagerichtextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void sps101button_Click(object sender, EventArgs e) //Send data to the server for SPS room
        {
            isspsconnect = !isspsconnect;

            sps101Socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);


            string ip = iptextbox.Text;
            string portnum = porttextbox.Text;
            string username = usernametextbox.Text;

            

            if (ip == "" || portnum == "" || username == "") //to avoid empty ip, portnum, usernames
            {
                sps101button.BackColor = Color.Red;
            }

            else
            {
               
                int port;
                Thread receiveThread = new Thread(ReceiveSPS);

                if (isspsconnect == true)
                {
                    if (Int32.TryParse(porttextbox.Text, out port))
                    {
                        try
                        {
                            sps101Socket.Connect(ip, port);
                            sps101button.BackColor = Color.Green;


                            sendtospsbutton.Enabled = true;

                            connected = true;

                            receiveThread.Start();
                            byte[] name = Encoding.Default.GetBytes("SP:" + usernametextbox.Text);
                            sps101Socket.Send(name);

                        }
                        catch
                        {
                            sps101richtextbox.AppendText("Could not connect to the server!\n");
                        }
                    }
                }
                else
                {
                    sps101button.BackColor = Color.Red;

                    sps101Socket.Close();


                    receiveThread.Abort();
                    sendtospsbutton.Enabled = false;
                    sps101richtextbox.AppendText(username + " disconnected to the server!\n");
                }

            }
        }

        private void sendtospsbutton_Click(object sender, EventArgs e) //Send data to the server for SPS room
        {
            string message = messagerichtextbox.Text;
            string username = usernametextbox.Text;
            string messageupdated = username + ": " + message;

            if (message != "" && message.Length <= 512)
            {
                Byte[] buffer = Encoding.Default.GetBytes(messageupdated);
                sps101Socket.Send(buffer);
            
                messagerichtextbox.Clear();
                message = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }




    }
}
