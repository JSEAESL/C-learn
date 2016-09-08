using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.nom.socket_TCP_len
{
    class ClientSocket
    {
        static void Main()
        {
            Socket tcpClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            IPAddress ipadress = IPAddress.Parse("10,0,5,35,");
            EndPoint point = new IPEndPoint(ipadress,8090);

            tcpClient.Connect(point);
            byte[] data = new byte[1024];
            int length = tcpClient.Receive(data);
            string message = Encoding.UTF8.GetString(data, 0, length);
            Console.WriteLine("get messgae : " + message);
            string sendMessage = Console.ReadLine();
            tcpClient.Send(Encoding.UTF8.GetBytes(sendMessage));

            Console.ReadKey();
        }
    }
}
