using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace server
{

    class Program
    {

        static string path = "D:\\";
        static int port = 8005; 
        static string address = "127.0.0.1";
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //адрес для запуска сокета
            IPEndPoint ipPoint = new IPEndPoint(IPAddress.Parse(address), port);

            //1. создаем сокет
            Socket listenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                //2. method Bind связываем сокет с локальной точкой, по которой будем принимать данные
                listenSocket.Bind(ipPoint);

                //3. method Listen начинаем прослушивание
                listenSocket.Listen(10);

                Console.WriteLine("Сервер запущен. Подключение...");

                while (true)
                    //4. method Accept получение входящего подключения  
                {
                    Socket handler = listenSocket.Accept();
                    // получаем сообщение
                    StringBuilder builder = new StringBuilder();
                    int bytes = 0; // количество полученных байтов
                    byte[] data = new byte[256]; // буфер для получаемых данных
                    int sizebuf = handler.Receive(data);
                    string decode = "";
                    for (int i = 0; i < sizebuf; i++)
                    {
                        decode += Convert.ToChar(data[i]);
                    }
                    Console.WriteLine(decode);
                    
                    while (handler.Available > 0);
                    //D
                     {
                     
                            if (Directory.Exists(path))
                            {
                                Console.WriteLine("Корневая папка:");
                                string[] dir = Directory.GetDirectories(path);
                                foreach (string str in dir)
                                {
                                    Console.WriteLine(str);
                                }
                                Console.WriteLine("Файлы: ");
                                string[] file = Directory.GetFiles(path);
                                foreach (string str in file)
                                {
                                    Console.WriteLine(str);
                                }
                            }
                       
                     }
                       //5. method Send/receive + 6. method Close socket             
                    string message = "Cообщение доставлено";
                    data = Encoding.Unicode.GetBytes(message);
                    handler.Send(data);
                    handler.Shutdown(SocketShutdown.Both);// закрываем сокет
                    handler.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}  
