using System.Net;
using System.Net.Sockets;
using PlayerMult.Types;

namespace PlayerMult
{
    public class PlayerMultServer
    {
        public static PlayerMultServer instance;

        private string ip = "127.0.0.1";
        private ushort port = 22222;

        private Socket socket;

        public PlayerMultServer(string ip, ushort port, SendType sendType)
        {
            PlayerMultServer.instance = this;

            this.ip = ip;
            this.port = port;

            this.socket = new Socket(AddressFamily.InterNetwork, (SocketType)sendType, ProtocolType.Tcp);
            this.socket.Bind(new IPEndPoint(IPAddress.Parse(this.ip), this.port));
        }

        public void Start()
        {
            this.socket.Listen(2);
        }

        public void Tick()
        {
            Socket currentSocket = this.socket.Accept();
            currentSocket.Close();
        }

        public void Close()
        {
            this.socket.Close();
        }
    }
}
