using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;

namespace Semester_Project_Client.WPF
{
    public static class Network
    {
        public static Queue<string> messages = new Queue<string>();
        private const string k_GlobalIp = "127.0.0.1";
        private const string k_LocalIp = "127.0.0.1";
        private const int k_Port = 7777;
        private static IPAddress ipAddress = IPAddress.Parse(k_GlobalIp);
        private static IPEndPoint remoteEp = new IPEndPoint(ipAddress, k_Port);
        private static Socket handler = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
        public static WelcomePage welcomepage;
        public static bool Connect()
        {
            
            try
            {
                //	Connect the socket to the remote endpoint (the server)
                handler.Connect(remoteEp);
                //	If we get to this line, the connection was successful
                //	If the Connect() method failed, an Exception would have been thrown
                Console.WriteLine("Connected to {0}", handler.RemoteEndPoint);
                Console.WriteLine("Type 'quit' to disconnect\r\n");
                Task.Run(() => Listen());
                return true;
            }
            catch
            {
                return false;
            }
        }

        private static void Listen()
        {
            for(; ; )
            {
                RecieveMessages();
            }
        }

        public static void Close_Connection() {
            handler.Shutdown(SocketShutdown.Both);
        }
        
        public static void SendMessage(string message)
        {
            var bytes = Encoding.ASCII.GetBytes(message + "\r");
            handler.Send(bytes);
        }
        public static string RecieveMessage()
        {
            for(; ; )
            {
                if(messages.Count > 0)
                {
                    break;
                }
            }
            return messages.Dequeue();
        }
        public static void RecieveMessages()
        {
            var buffer = new byte[2048];
            var numBytesReceived = handler.Receive(buffer);
            var textReceived = Encoding.ASCII.GetString(buffer, 0, numBytesReceived);
            string[] text = textReceived.Split("\r");
            if (text[0].StartsWith("GAMEUPDATE%%%"))
            {
                string update = text[0].Substring(13);
                welcomepage.RecieveGameUpdate(update);
            }
            else
            {
                messages.Enqueue(text[0]);
            }
        }
    }
}
