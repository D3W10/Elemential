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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblRules = new System.Windows.Forms.Label();
            this.pbGrapth = new System.Windows.Forms.PictureBox();
            this.pgbGame = new System.Windows.Forms.ProgressBar();
            this.lblGame = new System.Windows.Forms.Label();
            this.pbSparkle = new System.Windows.Forms.PictureBox();
            this.pbWind = new System.Windows.Forms.PictureBox();
            this.pbNature = new System.Windows.Forms.PictureBox();
            this.pbEnergy = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrapth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSparkle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnergy)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(200, 72);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Regras";
            // 
            // lblRules
            // 
            this.lblRules.Location = new System.Drawing.Point(27, 96);
            this.lblRules.Name = "lblRules";
            this.lblRules.Size = new System.Drawing.Size(472, 317);
            this.lblRules.TabIndex = 4;
            this.lblRules.Text = resources.GetString("lblRules.Text");
            // 
            // pbGrapth
            // 
            this.pbGrapth.Image = global::Elemential.Properties.Resources.Grapth;
            this.pbGrapth.Location = new System.Drawing.Point(540, 49);
            this.pbGrapth.Name = "pbGrapth";
            this.pbGrapth.Size = new System.Drawing.Size(200, 200);
            this.pbGrapth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGrapth.TabIndex = 5;
            this.pbGrapth.TabStop = false;
            // 
            // pgbGame
            // 
            this.pgbGame.Location = new System.Drawing.Point(622, 429);
            this.pgbGame.MarqueeAnimationSpeed = 20;
            this.pgbGame.Name = "pgbGame";
            this.pgbGame.Size = new System.Drawing.Size(150, 20);
            this.pgbGame.Step = 1;
            this.pgbGame.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pgbGame.TabIndex = 6;
            this.pgbGame.Visible = false;
            // 
            // lblGame
            // 
            this.lblGame.Location = new System.Drawing.Point(477, 429);
            this.lblGame.Name = "lblGame";
            this.lblGame.Size = new System.Drawing.Size(139, 20);
            this.lblGame.TabIndex = 7;
            this.lblGame.Text = "Aguardando adversário";
            this.lblGame.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblGame.Visible = false;
            // 
            // pbSparkle
            // 
            this.pbSparkle.BackColor = System.Drawing.Color.Transparent;
            this.pbSparkle.Image = global::Elemential.Properties.Resources.SparkleSprite;
            this.pbSparkle.Location = new System.Drawing.Point(610, 330);
            this.pbSparkle.Name = "pbSparkle";
            this.pbSparkle.Size = new System.Drawing.Size(60, 60);
            this.pbSparkle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSparkle.TabIndex = 31;
            this.pbSparkle.TabStop = false;
            // 
            // pbWind
            // 
            this.pbWind.BackColor = System.Drawing.Color.Transparent;
            this.pbWind.Image = global::Elemential.Properties.Resources.WindSprite;
            this.pbWind.Location = new System.Drawing.Point(610, 259);
            this.pbWind.Name = "pbWind";
            this.pbWind.Size = new System.Drawing.Size(60, 60);
            this.pbWind.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbWind.TabIndex = 30;
            this.pbWind.TabStop = false;
            // 
            // pbNature
            // 
            this.pbNature.BackColor = System.Drawing.Color.Transparent;
            this.pbNature.Image = global::Elemential.Properties.Resources.NatureSprite;
            this.pbNature.Location = new System.Drawing.Point(680, 259);
            this.pbNature.Name = "pbNature";
            this.pbNature.Size = new System.Drawing.Size(60, 60);
            this.pbNature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNature.TabIndex = 29;
            this.pbNature.TabStop = false;
            // 
            // pbEnergy
            // 
            this.pbEnergy.BackColor = System.Drawing.Color.Transparent;
            this.pbEnergy.Image = global::Elemential.Properties.Resources.EnergySprite;
            this.pbEnergy.Location = new System.Drawing.Point(540, 259);
            this.pbEnergy.Name = "pbEnergy";
            this.pbEnergy.Size = new System.Drawing.Size(60, 60);
            this.pbEnergy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEnergy.TabIndex = 28;
            this.pbEnergy.TabStop = false;
            // 
            // Rules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.pbSparkle);
            this.Controls.Add(this.pbWind);
            this.Controls.Add(this.pbNature);
            this.Controls.Add(this.pbEnergy);
            this.Controls.Add(this.lblGame);
            this.Controls.Add(this.pgbGame);
            this.Controls.Add(this.pbGrapth);
            this.Controls.Add(this.lblRules);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Rules";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elemential";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Rules_FormClosing);
            this.Shown += new System.EventHandler(this.Rules_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pbGrapth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSparkle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnergy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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