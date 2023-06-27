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
            this.pbPort = new System.Windows.Forms.PictureBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.btnJoin = new System.Windows.Forms.Button();
            this.tbAddress = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPort)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPort
            // 
            this.pbPort.Image = global::Elemential.Properties.Resources.port;
            this.pbPort.Location = new System.Drawing.Point(12, 12);
            this.pbPort.Name = "pbPort";
            this.pbPort.Size = new System.Drawing.Size(60, 60);
            this.pbPort.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPort.TabIndex = 0;
            this.pbPort.TabStop = false;
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(85, 49);
            this.tbPort.MaxLength = 5;
            this.tbPort.Name = "tbPort";
            this.tbPort.PlaceholderText = "Porta";
            this.tbPort.Size = new System.Drawing.Size(75, 23);
            this.tbPort.TabIndex = 1;
            this.tbPort.TextChanged += new System.EventHandler(this.tbPort_TextChanged);
            this.tbPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPress);
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPort.Location = new System.Drawing.Point(82, 12);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(205, 21);
            this.lblPort.TabIndex = 2;
            this.lblPort.Text = "Insira a porta para o jogo:";
            // 
            // btnJoin
            // 
            this.btnJoin.Enabled = false;
            this.btnJoin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnJoin.Location = new System.Drawing.Point(317, 49);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(75, 23);
            this.btnJoin.TabIndex = 3;
            this.btnJoin.Text = "Entrar";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(170, 50);
            this.tbAddress.MaxLength = 15;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.PlaceholderText = "Endereço IP";
            this.tbAddress.Size = new System.Drawing.Size(110, 23);
            this.tbAddress.TabIndex = 4;
            this.tbAddress.Visible = false;
            this.tbAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPress);
            // 
            // Port
            // 
            this.AcceptButton = this.btnJoin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 86);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.pbPort);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Port";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Elemential";
            ((System.ComponentModel.ISupportInitialize)(this.pbPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pbPort;
        private TextBox tbPort;
        private Label lblPort;
        private Button btnJoin;
        private TextBox tbAddress;
    }
}