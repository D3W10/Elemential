namespace Elemential
{
    public partial class Home : Form
    {
        private bool closing;

        public Home()
        {
            InitializeComponent();

            closing = false;
        }

        private void EnterOption(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = Color.FromArgb(255, 51, 215, 240);
        }

        private void LeaveOption(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = Color.Black;
        }

        private void lblStart_Click(object sender, EventArgs e)
        {
            if (new Port('H').ShowDialog() == DialogResult.OK)
            {
                closing = true;
                Program.Next = 'H';
                Close();
            }
        }

        private void lblJoin_Click(object sender, EventArgs e)
        {
            if (new Port('C').ShowDialog() == DialogResult.OK)
            {
                closing = true;
                Program.Next = 'J';
                Close();
            }
        }

        private void lblRules_Click(object sender, EventArgs e)
        {
            Hide();
            new Rules(' ').ShowDialog();
            Show();
        }

        private void lblLeave_Click(object sender, EventArgs e)
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