using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Semester_Project_Client.WPF
{
    internal static class Network
    {
        private const string k_GlobalIp = "127.0.0.1";
        private const string k_LocalIp = "127.0.0.1";
        private const int k_Port = 7777;
        private static IPAddress ipAddress = IPAddress.Parse(k_GlobalIp);
        private static IPEndPoint remoteEp = new IPEndPoint(ipAddress, k_Port);
        private static Socket handler = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
        internal static void Connect()
        {
            //	Connect the socket to the remote endpoint (the server)
            handler.Connect(remoteEp);
            //	If we get to this line, the connection was successful
            //	If the Connect() method failed, an Exception would have been thrown
            Console.WriteLine("Connected to {0}", handler.RemoteEndPoint);
            Console.WriteLine("Type 'quit' to disconnect\r\n");
        }
        internal static void Close_Connection() {
            handler.Shutdown(SocketShutdown.Both);
        }
        

    }
}
