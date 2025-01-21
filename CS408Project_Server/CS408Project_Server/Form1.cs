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

namespace CS408Project_Server
{
    public partial class Form1 : Form
    {
        Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        List<Socket> clientSockets = new List<Socket>();
        Dictionary<Socket, string> spsclientsockets = new Dictionary<Socket, string>(); //Dictionaries for server-client connection that keeps socket and clientname
        Dictionary<Socket, string> ifclientsockets = new Dictionary<Socket, string>();
        

       

        bool terminating = false;
        bool listening = false;

        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void connectbutton_Click(object sender, EventArgs e)
        {

            

            int serverPort;
            connectbutton.BackColor = Color.Green;

            if (Int32.TryParse(porttextbox.Text, out serverPort))
            {
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, serverPort); 
                serverSocket.Bind(endPoint);
                serverSocket.Listen(3);

                
                listening = true;
                connectbutton.Enabled = false;

                Thread acceptThread = new Thread(Accept);
                acceptThread.Start();

                allclientsrichtextbox.AppendText("Started listening on port: " + serverPort + "\n");

            }
            else
            {
                allclientsrichtextbox.AppendText("Please check port number \n");
            }
        }

        private void Accept()
        {
            while (listening)
            {
                try
                {
                    Socket newClient = serverSocket.Accept();
                    Byte[] buffer = new Byte[64];
                    int received = newClient.Receive(buffer);

                    string clientName = Encoding.Default.GetString(buffer, 0, received);

                    if (clientName.Substring(0, 3) == "SP:") { //clients to connect SPS room

                        if (spsclientsockets.ContainsValue(clientName))
                        {
                            allactionsrichtextbox.AppendText("Username cannot be the same\n"); //to avoid to connect with same username to the room
                            
                            sendMessage(newClient, "SameUsernameError");  //to avoid to connect with same username to the room
                        }
                        else
                        {
                            spsclientsockets.Add(newClient, clientName);
                            clientName = clientName.Substring(3, clientName.Length - 3);
                            allactionsrichtextbox.AppendText("Client " + clientName + " is connected to SPS101.\n"); 

                            string mes = clientName + " connected to the server";//
                            sendMessage(newClient, mes);//

                            sps101clientsrichtextbox.AppendText(clientName + "\n");
                            allclientsrichtextbox.AppendText(clientName + "\n");
                        }
                      
                    }
                    else if (clientName.Substring(0, 3) == "IF:") //clients to connect IF room
                    {
                        if(ifclientsockets.ContainsValue(clientName)){
                            allactionsrichtextbox.AppendText("Username cannot be the same\n");
                            sendMessage(newClient, "SameUsernameError");
                        }

                        else{
                            ifclientsockets.Add(newClient, clientName);
                            clientName = clientName.Substring(3, clientName.Length - 3);

                            allactionsrichtextbox.AppendText("Client " + clientName + " is connected to IF100.\n");

                            string mes = clientName + " connected to the server";//
                            sendMessage(newClient, mes);//

                            if100clientsrichtextbox.AppendText(clientName + "\n");
                            allclientsrichtextbox.AppendText(clientName + "\n");
                        }
                    }
                   

                    Thread receiveThread = new Thread(() => Receive(newClient)); 
                    receiveThread.Start();
                }
                catch
                {
                    if (terminating)
                    {
                        listening = false;
                    }
                    else
                    {
                        allclientsrichtextbox.AppendText("The socket stopped working.\n");
                    }

                }
            }
        }

        private void sendMessage(Socket sender, string message)
        {  

            if (spsclientsockets.ContainsKey(sender)) //send data to SPS room for SPS clients
            {
               
                foreach (var clientSocket in spsclientsockets)
                {
                    
                    if (clientSocket.Value.Substring(0,2)=="SP")
                    {
                        Byte[] buffer = Encoding.Default.GetBytes(message);
                        clientSocket.Key.Send(buffer);
                    }
                }
            }
            else if (ifclientsockets.ContainsKey(sender)) //send data to IF room for SPS clients
            {

                foreach (var clientSocket in ifclientsockets)
                {
                    

                    if (clientSocket.Value.Substring(0,2) == "IF")
                    {
                        Byte[] buffer = Encoding.Default.GetBytes(message);
                        clientSocket.Key.Send(buffer);
                    }
                }
            }

        }

        private void Receive(Socket thisClient) 
        {

            while (!terminating)
            {
                
                    Byte[] buffer = new Byte[512];
                    thisClient.Receive(buffer);

                    sps101clientsrichtextbox.Clear();
                    if100clientsrichtextbox.Clear();
                    foreach (var i in spsclientsockets)
                    {                
                        sps101clientsrichtextbox.AppendText(i.Value.Substring(3) + "\n"); //to write current SPS clientnames
                    }

                    foreach (var i in ifclientsockets)
                    {
                        if100clientsrichtextbox.AppendText(i.Value.Substring(3) + "\n"); //to write current IF clientnames
                    }

                    
                        string incomingMessage = Encoding.Default.GetString(buffer);
                        incomingMessage = incomingMessage.Substring(0, incomingMessage.IndexOf("\0"));

                        allactionsrichtextbox.AppendText(incomingMessage + "\n");

                        if (spsclientsockets.ContainsKey(thisClient) || ifclientsockets.ContainsKey(thisClient))
                        {

                            sendMessage(thisClient, incomingMessage);
                        }
                   
                
            }
        }

        private void Form1_FormClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            listening = false;
            terminating = true;
            Environment.Exit(0);
        }

        private void allactionsrichtextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void porttextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void if100clientsrichtextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void allclientsrichtextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void disconnectbutton_Click(object sender, EventArgs e)
        {
            allactionsrichtextbox.AppendText("Server disconnected\n");

            serverSocket.Close();

            terminating = true;
            listening = false;
            connectbutton.Enabled = true;
            if100clientsrichtextbox.Text="";
            sps101clientsrichtextbox.Text="";
            disconnectbutton.BackColor = Color.Red;
        }
    }
}
