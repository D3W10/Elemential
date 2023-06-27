using Elemential.Components;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Elemential
{
    public partial class Home : Form
    {
        private bool closing;
        private readonly Color defaultBtnBorder;

        public Home()
        {
            InitializeComponent();

            closing = false;
            defaultBtnBorder = btnHost.BorderColor;
        }

        private void EnterOption(object sender, EventArgs e)
        {
            ((RoundedButton)sender).BorderColor = Color.Turquoise;
        }

        private void LeaveOption(object sender, EventArgs e)
        {
            ((RoundedButton)sender).BorderColor = defaultBtnBorder;
        }

        private void btnHost_Click(object sender, EventArgs e)
        {
            if (new Port('H').ShowDialog() == DialogResult.OK)
            {
                closing = true;
                Program.Next = 'H';
                Close();
            }
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            if (new Port('C').ShowDialog() == DialogResult.OK)
            {
                closing = true;
                Program.Next = 'J';
                Close();
            }
        }

        private void btnRules_Click(object sender, EventArgs e)
        {
            Hide();
            new Rules(' ').ShowDialog();
            Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            LeavingGame();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!closing)
            {
                e.Cancel = true;
                LeavingGame();
            }
        }

        private void LeavingGame()
        {
            if (MessageBox.Show("Tem a certeza que quer sair?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                closing = true;
                Close();
            }
        }
    }
}