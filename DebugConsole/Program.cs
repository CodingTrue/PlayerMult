using System;
using PlayerMult;
using PlayerMult.Types;

namespace DebugConsole
{
    class Program
    {
        public static void Main(string[] args)
        {
            PlayerMultServer server = new PlayerMultServer("127.0.0.1", 22222, SendType.Safe);

            server.Start();
            server.Tick();
            server.Close();
        }
    }
}
