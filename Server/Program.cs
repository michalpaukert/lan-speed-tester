using System.Net;
using System.Net.Sockets;
using System.Text;

int port = 13000;

var server = new TcpListener(IPAddress.Any, port);

// Start listening for client requests.
server.Start();

// Buffer for reading data
string data = null;

while (true)
{
    Console.Write("Waiting for a connection... ");

    TcpClient tcpClient = server.AcceptTcpClient();
    var ip = tcpClient.Client.RemoteEndPoint as IPEndPoint;
    Console.WriteLine("Connected!", ip.Address);

    // Get a stream object for reading and writing
    NetworkStream stream = tcpClient.GetStream();
    int i;
    byte[] bytes = new byte[1073741824]; // 1 GB

    while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
    {

    }

    tcpClient.Close();
}
