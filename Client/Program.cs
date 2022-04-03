using System.Net;
using System.Net.Sockets;

TcpClient tcpClient = new TcpClient();
var serverIp = IPAddress.Parse("192.168.1.115");
int port = 13000;
tcpClient.SendBufferSize = 8192;
Console.WriteLine("Connecting to server");
tcpClient.Connect(serverIp, port);
Console.WriteLine("Connected");

var rnd = new Random();
var networkStream = tcpClient.GetStream();

byte[] bytes = new byte[1073741824]; // 1 GB
rnd.NextBytes(bytes);

networkStream.Write(bytes, 0, bytes.Length);



networkStream.Close();
