using System.Net.Sockets;

namespace Elemential
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            while (true)
            {
                Next = ' ';
                Port = 0;

                Application.Run(new Home());
                if (Next != ' ')
                {
                    Application.Run(new Rules(Next));
                    if (Next != ' ')
                        Application.Run(new Game(Next));
                    continue;
                }
                break;
            }

            Application.Exit();
        }

        public static char Next { get; set; }

        public static int Port { get; set; }

        public static string Address { get; set; }

        public static TcpListener Listener { get; set; }

        public static TcpClient Client { get; set; }
    }
}