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
            this.lblStart = new System.Windows.Forms.Label();
            this.lblJoin = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblRules = new System.Windows.Forms.Label();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.lblLeave = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblStart.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStart.ForeColor = System.Drawing.Color.Black;
            this.lblStart.Location = new System.Drawing.Point(62, 136);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(56, 28);
            this.lblStart.TabIndex = 0;
            this.lblStart.Text = "Host";
            this.lblStart.Click += new System.EventHandler(this.lblStart_Click);
            this.lblStart.MouseEnter += new System.EventHandler(this.EnterOption);
            this.lblStart.MouseLeave += new System.EventHandler(this.LeaveOption);
            // 
            // lblJoin
            // 
            this.lblJoin.AutoSize = true;
            this.lblJoin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblJoin.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblJoin.ForeColor = System.Drawing.Color.Black;
            this.lblJoin.Location = new System.Drawing.Point(62, 197);
            this.lblJoin.Name = "lblJoin";
            this.lblJoin.Size = new System.Drawing.Size(72, 28);
            this.lblJoin.TabIndex = 1;
            this.lblJoin.Text = "Juntar";
            this.lblJoin.Click += new System.EventHandler(this.lblJoin_Click);
            this.lblJoin.MouseEnter += new System.EventHandler(this.EnterOption);
            this.lblJoin.MouseLeave += new System.EventHandler(this.LeaveOption);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(294, 72);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Elemential";
            // 
            // lblRules
            // 
            this.lblRules.AutoSize = true;
            this.lblRules.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRules.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRules.ForeColor = System.Drawing.Color.Black;
            this.lblRules.Location = new System.Drawing.Point(62, 261);
            this.lblRules.Name = "lblRules";
            this.lblRules.Size = new System.Drawing.Size(76, 28);
            this.lblRules.TabIndex = 3;
            this.lblRules.Text = "Regras";
            this.lblRules.Click += new System.EventHandler(this.lblRules_Click);
            this.lblRules.MouseEnter += new System.EventHandler(this.EnterOption);
            this.lblRules.MouseLeave += new System.EventHandler(this.LeaveOption);
            // 
            // pbIcon
            // 
            this.pbIcon.Image = global::Elemential.Properties.Resources.Elemential;
            this.pbIcon.Location = new System.Drawing.Point(409, 79);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(250, 250);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIcon.TabIndex = 4;
            this.pbIcon.TabStop = false;
            // 
            // lblLeave
            // 
            this.lblLeave.AutoSize = true;
            this.lblLeave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLeave.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLeave.ForeColor = System.Drawing.Color.Black;
            this.lblLeave.Location = new System.Drawing.Point(62, 319);
            this.lblLeave.Name = "lblLeave";
            this.lblLeave.Size = new System.Drawing.Size(48, 28);
            this.lblLeave.TabIndex = 5;
            this.lblLeave.Text = "Sair";
            this.lblLeave.Click += new System.EventHandler(this.lblLeave_Click);
            this.lblLeave.MouseEnter += new System.EventHandler(this.EnterOption);
            this.lblLeave.MouseLeave += new System.EventHandler(this.LeaveOption);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.lblLeave);
            this.Controls.Add(this.pbIcon);
            this.Controls.Add(this.lblRules);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblJoin);
            this.Controls.Add(this.lblStart);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elemential";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblStart;
        private Label lblJoin;
        private Label lblTitle;
        private Label lblRules;
        private PictureBox pbIcon;
        private Label lblLeave;
    }
}