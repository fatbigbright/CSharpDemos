using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace TcpServer
{
   class Program
   {
      static void Main(string[] args)
      {
         //get ip address of localhost
         IPAddress address = IPAddress.Loopback;

         IPEndPoint endPoint = new IPEndPoint(address, 65500);
         TcpListener newServer = new TcpListener(endPoint);

         newServer.Start();
         Console.WriteLine("Began to listen...");

         while (true)
         {
            TcpClient newClient = newServer.AcceptTcpClient();

            Console.WriteLine("Connection established.");

            NetworkStream networkStream = newClient.GetStream();

            System.Text.Encoding utf8 = System.Text.Encoding.UTF8;

            byte[] request = new byte[4096];
            int length = networkStream.Read(request, 0, 4096);
            string requestString = utf8.GetString(request, 0, length);
            Console.WriteLine(requestString);

            string statusLine = "HTTP/1.1 200 OK\r\n";
            byte[] statusLineBytes = utf8.GetBytes(statusLine);

            string responseBody = "<html><head><title>From Socket Server</title></head><body><h1>Hello World!</h1></body></html>";
            byte[] responseBodyBytes = utf8.GetBytes(responseBody);

            string reponseHeader = string.Format("Content-Type: text/html; charset=UTF-8\r\nContent-Length: {0}\r\n", responseBody.Length);
            byte[] responseHeaderBytes = utf8.GetBytes(reponseHeader);

            networkStream.Write(statusLineBytes, 0, statusLineBytes.Length);
            networkStream.Write(responseHeaderBytes, 0, responseHeaderBytes.Length);
            networkStream.Write(new byte[] { 13, 10 }, 0, 2);
            networkStream.Write(responseBodyBytes, 0, responseBodyBytes.Length);

            newClient.Close();

            if (Console.KeyAvailable)
               break;
         }

         newServer.Stop();
      }
   }
}
