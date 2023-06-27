using System.Windows.Forms;

namespace Elemential
{
    partial class Port
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Port));
            pbPort = new PictureBox();
            tbPort = new TextBox();
            lblPort = new Label();
            btnJoin = new Button();
            tbAddress = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbPort).BeginInit();
            SuspendLayout();
            // 
            // pbPort
            // 
            pbPort.Image = Properties.Resources.port;
            pbPort.Location = new System.Drawing.Point(12, 12);
            pbPort.Name = "pbPort";
            pbPort.Size = new System.Drawing.Size(60, 60);
            pbPort.SizeMode = PictureBoxSizeMode.Zoom;
            pbPort.TabIndex = 0;
            pbPort.TabStop = false;
            // 
            // tbPort
            // 
            tbPort.Location = new System.Drawing.Point(85, 49);
            tbPort.MaxLength = 5;
            tbPort.Name = "tbPort";
            tbPort.PlaceholderText = "Porta";
            tbPort.Size = new System.Drawing.Size(75, 23);
            tbPort.TabIndex = 0;
            tbPort.TextChanged += tbPort_TextChanged;
            tbPort.KeyPress += TextBoxKeyPress;
            // 
            // lblPort
            // 
            lblPort.AutoSize = true;
            lblPort.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblPort.Location = new System.Drawing.Point(82, 12);
            lblPort.Name = "lblPort";
            lblPort.Size = new System.Drawing.Size(205, 21);
            lblPort.TabIndex = 0;
            lblPort.Text = "Insira a porta para o jogo:";
            // 
            // btnJoin
            // 
            btnJoin.Enabled = false;
            btnJoin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnJoin.Location = new System.Drawing.Point(317, 49);
            btnJoin.Name = "btnJoin";
            btnJoin.Size = new System.Drawing.Size(75, 23);
            btnJoin.TabIndex = 2;
            btnJoin.Text = "Entrar";
            btnJoin.UseVisualStyleBackColor = true;
            btnJoin.Click += btnJoin_Click;
            // 
            // tbAddress
            // 
            tbAddress.Location = new System.Drawing.Point(170, 50);
            tbAddress.MaxLength = 15;
            tbAddress.Name = "tbAddress";
            tbAddress.PlaceholderText = "Endereço IP";
            tbAddress.Size = new System.Drawing.Size(110, 23);
            tbAddress.TabIndex = 1;
            tbAddress.Visible = false;
            tbAddress.KeyPress += TextBoxKeyPress;
            // 
            // Port
            // 
            AcceptButton = btnJoin;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(404, 86);
            Controls.Add(tbAddress);
            Controls.Add(btnJoin);
            Controls.Add(lblPort);
            Controls.Add(tbPort);
            Controls.Add(pbPort);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Port";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Elemential";
            ((System.ComponentModel.ISupportInitialize)pbPort).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbPort;
        private TextBox tbPort;
        private Label lblPort;
        private Button btnJoin;
        private TextBox tbAddress;
    }
}