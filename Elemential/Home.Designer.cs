using System.Windows.Forms;

namespace Elemential
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            lblTitle = new Label();
            pbIcon = new PictureBox();
            btnHost = new Components.RoundedButton();
            btnJoin = new Components.RoundedButton();
            btnRules = new Components.RoundedButton();
            btnExit = new Components.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)pbIcon).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTitle.Location = new System.Drawing.Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(294, 72);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Elemential";
            // 
            // pbIcon
            // 
            pbIcon.Image = Properties.Resources.Elemential;
            pbIcon.Location = new System.Drawing.Point(409, 65);
            pbIcon.Name = "pbIcon";
            pbIcon.Size = new System.Drawing.Size(250, 250);
            pbIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pbIcon.TabIndex = 4;
            pbIcon.TabStop = false;
            // 
            // btnHost
            // 
            btnHost.BackColor = System.Drawing.Color.Transparent;
            btnHost.BorderColor = System.Drawing.Color.DarkGray;
            btnHost.BorderRadius = 10;
            btnHost.BorderSize = 3;
            btnHost.FlatAppearance.BorderSize = 0;
            btnHost.FlatStyle = FlatStyle.Flat;
            btnHost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnHost.ForeColor = System.Drawing.SystemColors.ControlText;
            btnHost.Location = new System.Drawing.Point(50, 120);
            btnHost.Name = "btnHost";
            btnHost.Size = new System.Drawing.Size(130, 40);
            btnHost.TabIndex = 6;
            btnHost.Text = "Criar";
            btnHost.UseVisualStyleBackColor = false;
            btnHost.Click += btnHost_Click;
            btnHost.MouseEnter += EnterOption;
            btnHost.MouseLeave += LeaveOption;
            // 
            // btnJoin
            // 
            btnJoin.BackColor = System.Drawing.Color.Transparent;
            btnJoin.BorderColor = System.Drawing.Color.DarkGray;
            btnJoin.BorderRadius = 10;
            btnJoin.BorderSize = 3;
            btnJoin.FlatAppearance.BorderSize = 0;
            btnJoin.FlatStyle = FlatStyle.Flat;
            btnJoin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnJoin.ForeColor = System.Drawing.SystemColors.ControlText;
            btnJoin.Location = new System.Drawing.Point(50, 180);
            btnJoin.Name = "btnJoin";
            btnJoin.Size = new System.Drawing.Size(130, 40);
            btnJoin.TabIndex = 7;
            btnJoin.Text = "Juntar";
            btnJoin.UseVisualStyleBackColor = false;
            btnJoin.Click += btnJoin_Click;
            btnJoin.MouseEnter += EnterOption;
            btnJoin.MouseLeave += LeaveOption;
            // 
            // btnRules
            // 
            btnRules.BackColor = System.Drawing.Color.Transparent;
            btnRules.BorderColor = System.Drawing.Color.DarkGray;
            btnRules.BorderRadius = 10;
            btnRules.BorderSize = 3;
            btnRules.FlatAppearance.BorderSize = 0;
            btnRules.FlatStyle = FlatStyle.Flat;
            btnRules.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnRules.ForeColor = System.Drawing.SystemColors.ControlText;
            btnRules.Location = new System.Drawing.Point(50, 240);
            btnRules.Name = "btnRules";
            btnRules.Size = new System.Drawing.Size(110, 40);
            btnRules.TabIndex = 8;
            btnRules.Text = "Regras";
            btnRules.UseVisualStyleBackColor = false;
            btnRules.Click += btnRules_Click;
            btnRules.MouseEnter += EnterOption;
            btnRules.MouseLeave += LeaveOption;
            // 
            // btnExit
            // 
            btnExit.BackColor = System.Drawing.Color.Transparent;
            btnExit.BorderColor = System.Drawing.Color.DarkGray;
            btnExit.BorderRadius = 10;
            btnExit.BorderSize = 3;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            btnExit.Location = new System.Drawing.Point(50, 300);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(110, 40);
            btnExit.TabIndex = 9;
            btnExit.Text = "Sair";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            btnExit.MouseEnter += EnterOption;
            btnExit.MouseLeave += LeaveOption;
            // 
            // Home
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(734, 381);
            Controls.Add(btnExit);
            Controls.Add(btnRules);
            Controls.Add(btnJoin);
            Controls.Add(btnHost);
            Controls.Add(pbIcon);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Elemential";
            FormClosing += Home_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pbIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTitle;
        private PictureBox pbIcon;
        private Components.RoundedButton btnHost;
        private Components.RoundedButton btnJoin;
        private Components.RoundedButton btnRules;
        private Components.RoundedButton btnExit;
    }
}