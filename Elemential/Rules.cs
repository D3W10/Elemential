using System;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elemential
{
    public partial class Rules : Form
    {
        private readonly char type;
        private bool closing;

        public Rules(char type)
        {
            InitializeComponent();

            this.type = type;
            closing = false;
            Program.Next = ' ';

            if (type != ' ')
            {
                lblGame.Visible = true;
                pgbGame.Visible = true;
            }
        }

        private void Rules_Shown(object sender, EventArgs e)
        {
            Task task = null;
            if (type == 'H')
            {
                task = new(() =>
                {
                    try
                    {
                        Program.Listener = new TcpListener(IPAddress.Any, Program.Port);
                        Program.Listener.Start();
                        Program.Client = Program.Listener.AcceptTcpClient();
                        Program.Next = type;
                    }
                    catch (SocketException)
                    {
                        if (!closing)
                        {
                            Program.Next = ' ';
                            MessageBox.Show("Alguma outra aplicação já está a usar esta porta. Experimente usar outra e tente novamente.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Program.Next = ' ';
                        MessageBox.Show("A porta inserida é inválida. Experimente usar outra e tente novamente.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                });
            }
            else if (type == 'J')
            {
                task = new(() =>
                {
                    try
                    {
                        Program.Client = new TcpClient(Program.Address, Program.Port);
                        Program.Next = type;
                    }
                    catch (SocketException)
                    {
                        Program.Next = ' ';
                        MessageBox.Show("Não existe nenhum jogo nessa porta. Verifique se inseriu o seu valor corretamente e tente novamente.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Program.Next = ' ';
                        MessageBox.Show("A porta inserida é inválida. Experimente usar outra e tente novamente.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                });
            }

            if (!closing && (type == 'H' || type == 'J'))
            {
                task.Start();
                task.ContinueWith((tsk) => CloseRules());
            }
        }

        private void Rules_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (type == 'H')
            {
                closing = true;

                try
                {
                    Program.Listener.Stop();
                }
                catch (SocketException) { }
            }
        }

        private delegate void CloseCallback();

        private void CloseRules()
        {
            try
            {
                if (InvokeRequired)
                    Invoke(new CloseCallback(CloseRules));
                else
                    Close();
            }
            catch (ObjectDisposedException) { }
        }
    }
}