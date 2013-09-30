using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace SocketServer
{
   class Program
   {
      static void Main(string[] args)
      {
         IPAddress address = IPAddress.Loopback;
         IPEndPoint endPoint = new IPEndPoint(address, 65500);
         Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
         socket.Bind(endPoint);
         socket.Listen(10);
         Console.WriteLine("Begin to listen, port: {0}.", endPoint.Port);

         while (true)
         {
            Socket client = socket.Accept();

            Console.WriteLine(client.RemoteEndPoint);

            byte[] buffer = new byte[4096];

            int length = client.Receive(buffer, 4096, SocketFlags.None);

            System.Text.Encoding utf8 = System.Text.Encoding.UTF8;

            string requestString = utf8.GetString(buffer, 0, length);

            Console.WriteLine(requestString);

            string statusLine = "HTTP/1.1 200 OK\r\n";
            byte[] statusLineBytes = utf8.GetBytes(statusLine);
            
            string responseBody = "<html><head><title>From Socket Server</title></head><body><h1>Hello World!</h1></body></html>";
            byte[] reponseBodyBytes = utf8.GetBytes(responseBody);

            string reponseHeader = string.Format("Content-Type: text/html; charset=UTF-8\r\nContent-Length: {0}\r\n", responseBody.Length);
            byte[] responseHeaderBytes = utf8.GetBytes(reponseHeader);

            client.Send(statusLineBytes);
            client.Send(responseHeaderBytes);//Sometimes exception "An established connection was aborted by the software in your host machine" comes out
            client.Send(new byte[] { 13, 10 });
            client.Send(reponseBodyBytes);

            client.Close();
            if (Console.KeyAvailable)
            {
               break;
            }
         }

         socket.Close();
      }
   }
}
