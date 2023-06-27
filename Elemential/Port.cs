using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Elemential
{
    public partial class Port : Form
    {
        private readonly Regex ipRegex;

        public Port(char type)
        {
            InitializeComponent();

            ipRegex = new(@"^(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$");
            if (type == 'H')
                lblPort.Text = "Insira a porta para o jogo:";
            else if (type == 'C')
            {
                lblPort.Text = "Insira a porta e o endereço de IP:";
                tbAddress.Visible = true;
            }
        }

        private void TextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
        }

        private void tbPort_TextChanged(object sender, EventArgs e)
        {
            if (tbPort.Text.Length >= 4)
                btnJoin.Enabled = true;
            else
                btnJoin.Enabled = false;

            foreach (char c in tbPort.Text)
            {
                if (!char.IsDigit(c))
                {
                    tbPort.Clear();
                    break;
                }
            }
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            if (tbAddress.Visible && !ipRegex.IsMatch(tbAddress.Text))
            {
                MessageBox.Show("O endereço de IP inserido é inválido!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                Program.Port = Convert.ToInt32(tbPort.Text);
                Program.Address = tbAddress.Text;
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (FormatException) { }
        }
    }
}