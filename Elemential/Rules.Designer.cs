using System.Windows.Forms;

namespace Elemential
{
    partial class Rules
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rules));
            lblTitle = new Label();
            lblRules = new Label();
            pbGrapth = new PictureBox();
            pgbGame = new ProgressBar();
            lblGame = new Label();
            pbSparkle = new PictureBox();
            pbWind = new PictureBox();
            pbNature = new PictureBox();
            pbEnergy = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbGrapth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSparkle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbWind).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbNature).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEnergy).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTitle.Location = new System.Drawing.Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(200, 72);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Regras";
            // 
            // lblRules
            // 
            lblRules.Location = new System.Drawing.Point(27, 96);
            lblRules.Name = "lblRules";
            lblRules.Size = new System.Drawing.Size(472, 317);
            lblRules.TabIndex = 0;
            lblRules.Text = resources.GetString("lblRules.Text");
            // 
            // pbGrapth
            // 
            pbGrapth.Image = Properties.Resources.Grapth;
            pbGrapth.Location = new System.Drawing.Point(540, 49);
            pbGrapth.Name = "pbGrapth";
            pbGrapth.Size = new System.Drawing.Size(200, 200);
            pbGrapth.SizeMode = PictureBoxSizeMode.Zoom;
            pbGrapth.TabIndex = 5;
            pbGrapth.TabStop = false;
            // 
            // pgbGame
            // 
            pgbGame.Location = new System.Drawing.Point(622, 429);
            pgbGame.MarqueeAnimationSpeed = 25;
            pgbGame.Name = "pgbGame";
            pgbGame.Size = new System.Drawing.Size(150, 20);
            pgbGame.Step = 1;
            pgbGame.Style = ProgressBarStyle.Marquee;
            pgbGame.TabIndex = 0;
            pgbGame.Visible = false;
            // 
            // lblGame
            // 
            lblGame.Location = new System.Drawing.Point(477, 429);
            lblGame.Name = "lblGame";
            lblGame.Size = new System.Drawing.Size(139, 20);
            lblGame.TabIndex = 0;
            lblGame.Text = "Aguardando adversário";
            lblGame.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            lblGame.Visible = false;
            // 
            // pbSparkle
            // 
            pbSparkle.BackColor = System.Drawing.Color.Transparent;
            pbSparkle.Image = Properties.Resources.SparkleSprite;
            pbSparkle.Location = new System.Drawing.Point(610, 330);
            pbSparkle.Name = "pbSparkle";
            pbSparkle.Size = new System.Drawing.Size(60, 60);
            pbSparkle.SizeMode = PictureBoxSizeMode.Zoom;
            pbSparkle.TabIndex = 31;
            pbSparkle.TabStop = false;
            // 
            // pbWind
            // 
            pbWind.BackColor = System.Drawing.Color.Transparent;
            pbWind.Image = Properties.Resources.WindSprite;
            pbWind.Location = new System.Drawing.Point(610, 259);
            pbWind.Name = "pbWind";
            pbWind.Size = new System.Drawing.Size(60, 60);
            pbWind.SizeMode = PictureBoxSizeMode.Zoom;
            pbWind.TabIndex = 30;
            pbWind.TabStop = false;
            // 
            // pbNature
            // 
            pbNature.BackColor = System.Drawing.Color.Transparent;
            pbNature.Image = Properties.Resources.NatureSprite;
            pbNature.Location = new System.Drawing.Point(680, 259);
            pbNature.Name = "pbNature";
            pbNature.Size = new System.Drawing.Size(60, 60);
            pbNature.SizeMode = PictureBoxSizeMode.Zoom;
            pbNature.TabIndex = 29;
            pbNature.TabStop = false;
            // 
            // pbEnergy
            // 
            pbEnergy.BackColor = System.Drawing.Color.Transparent;
            pbEnergy.Image = Properties.Resources.EnergySprite;
            pbEnergy.Location = new System.Drawing.Point(540, 259);
            pbEnergy.Name = "pbEnergy";
            pbEnergy.Size = new System.Drawing.Size(60, 60);
            pbEnergy.SizeMode = PictureBoxSizeMode.Zoom;
            pbEnergy.TabIndex = 28;
            pbEnergy.TabStop = false;
            // 
            // Rules
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(784, 461);
            Controls.Add(pbSparkle);
            Controls.Add(pbWind);
            Controls.Add(pbNature);
            Controls.Add(pbEnergy);
            Controls.Add(lblGame);
            Controls.Add(pgbGame);
            Controls.Add(pbGrapth);
            Controls.Add(lblRules);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Rules";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Elemential";
            FormClosing += Rules_FormClosing;
            Shown += Rules_Shown;
            ((System.ComponentModel.ISupportInitialize)pbGrapth).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSparkle).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbWind).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbNature).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEnergy).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblRules;
        private PictureBox pbGrapth;
        private ProgressBar pgbGame;
        private Label lblGame;
        private PictureBox pbSparkle;
        private PictureBox pbWind;
        private PictureBox pbNature;
        private PictureBox pbEnergy;
    }
}