using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.nom.socket_TCP_len
{
    class ServerSocket
    {
        static void Main(string[] args)
        {
            Socket tcpServer = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
            IPAddress ipadress = new IPAddress(new byte[] { 10,0,5,35 });
            EndPoint point = new IPEndPoint(ipadress,8099);
            tcpServer.Bind(point);
            tcpServer.Listen(100);
            Console.WriteLine("start linten");

            Socket clientSocket = tcpServer.Accept();
            Console.WriteLine("accept clientSocket");

            string message = "Hello Wolrd";
            byte[] data = Encoding.UTF8.GetBytes(message);
            clientSocket.Send(data);
            Console.WriteLine("Server send to Client data");

            byte[] receideData = new byte[1024];
            int length = clientSocket.Receive(receideData);
            string receiveMessage = Encoding.UTF8.GetString(receideData,0,length);
            Console.WriteLine("receive message: " + receiveMessage);
            Console.ReadKey();
        }
    }
}
