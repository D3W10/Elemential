using System.Windows.Forms;

namespace Elemential
{
    partial class Game
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            pbSlot1 = new PictureBox();
            pbSlot2 = new PictureBox();
            pbSlot3 = new PictureBox();
            pbSlot4 = new PictureBox();
            pbSlot5 = new PictureBox();
            pbSlot6 = new PictureBox();
            pbSlot7 = new PictureBox();
            pbSlot8 = new PictureBox();
            pbSlot9 = new PictureBox();
            pbOpponent = new PictureBox();
            pbMe = new PictureBox();
            lblPlayer = new Label();
            pbOSlot1 = new PictureBox();
            pbOSlot2 = new PictureBox();
            pbOSlot3 = new PictureBox();
            pbOSlot4 = new PictureBox();
            pbOSlot5 = new PictureBox();
            pbOSlot6 = new PictureBox();
            pbOSlot7 = new PictureBox();
            pbOSlot8 = new PictureBox();
            pbOSlot9 = new PictureBox();
            lblMyTurn = new Label();
            pbEnergy = new PictureBox();
            pbNature = new PictureBox();
            pbWind = new PictureBox();
            pbSparkle = new PictureBox();
            pbWinLose = new PictureBox();
            btnForward = new Components.RoundedButton();
            btnBack = new Components.RoundedButton();
            btnOpponent = new Components.RoundedButton();
            btnMe = new Components.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)pbSlot1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSlot2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSlot3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSlot4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSlot5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSlot6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSlot7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSlot8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSlot9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOpponent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOSlot1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOSlot2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOSlot3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOSlot4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOSlot5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOSlot6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOSlot7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOSlot8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOSlot9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEnergy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbNature).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbWind).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSparkle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbWinLose).BeginInit();
            SuspendLayout();
            // 
            // pbSlot1
            // 
            pbSlot1.BackColor = System.Drawing.Color.Transparent;
            pbSlot1.Cursor = Cursors.Hand;
            pbSlot1.Image = Properties.Resources.Place;
            pbSlot1.Location = new System.Drawing.Point(90, 451);
            pbSlot1.Name = "pbSlot1";
            pbSlot1.Size = new System.Drawing.Size(129, 200);
            pbSlot1.SizeMode = PictureBoxSizeMode.Zoom;
            pbSlot1.TabIndex = 0;
            pbSlot1.TabStop = false;
            pbSlot1.Visible = false;
            pbSlot1.Click += CardClick;
            pbSlot1.MouseEnter += EnterCard;
            pbSlot1.MouseLeave += LeaveCard;
            // 
            // pbSlot2
            // 
            pbSlot2.BackColor = System.Drawing.Color.Transparent;
            pbSlot2.Cursor = Cursors.Hand;
            pbSlot2.Image = Properties.Resources.Place;
            pbSlot2.Location = new System.Drawing.Point(174, 451);
            pbSlot2.Name = "pbSlot2";
            pbSlot2.Size = new System.Drawing.Size(129, 200);
            pbSlot2.SizeMode = PictureBoxSizeMode.Zoom;
            pbSlot2.TabIndex = 1;
            pbSlot2.TabStop = false;
            pbSlot2.Visible = false;
            pbSlot2.Click += CardClick;
            pbSlot2.MouseEnter += EnterCard;
            pbSlot2.MouseLeave += LeaveCard;
            // 
            // pbSlot3
            // 
            pbSlot3.BackColor = System.Drawing.Color.Transparent;
            pbSlot3.Cursor = Cursors.Hand;
            pbSlot3.Image = Properties.Resources.Place;
            pbSlot3.Location = new System.Drawing.Point(258, 451);
            pbSlot3.Name = "pbSlot3";
            pbSlot3.Size = new System.Drawing.Size(129, 200);
            pbSlot3.SizeMode = PictureBoxSizeMode.Zoom;
            pbSlot3.TabIndex = 2;
            pbSlot3.TabStop = false;
            pbSlot3.Visible = false;
            pbSlot3.Click += CardClick;
            pbSlot3.MouseEnter += EnterCard;
            pbSlot3.MouseLeave += LeaveCard;
            // 
            // pbSlot4
            // 
            pbSlot4.BackColor = System.Drawing.Color.Transparent;
            pbSlot4.Cursor = Cursors.Hand;
            pbSlot4.Image = Properties.Resources.Place;
            pbSlot4.Location = new System.Drawing.Point(342, 451);
            pbSlot4.Name = "pbSlot4";
            pbSlot4.Size = new System.Drawing.Size(129, 200);
            pbSlot4.SizeMode = PictureBoxSizeMode.Zoom;
            pbSlot4.TabIndex = 3;
            pbSlot4.TabStop = false;
            pbSlot4.Visible = false;
            pbSlot4.Click += CardClick;
            pbSlot4.MouseEnter += EnterCard;
            pbSlot4.MouseLeave += LeaveCard;
            // 
            // pbSlot5
            // 
            pbSlot5.BackColor = System.Drawing.Color.Transparent;
            pbSlot5.Cursor = Cursors.Hand;
            pbSlot5.Image = Properties.Resources.Place;
            pbSlot5.Location = new System.Drawing.Point(426, 451);
            pbSlot5.Name = "pbSlot5";
            pbSlot5.Size = new System.Drawing.Size(129, 200);
            pbSlot5.SizeMode = PictureBoxSizeMode.Zoom;
            pbSlot5.TabIndex = 4;
            pbSlot5.TabStop = false;
            pbSlot5.Visible = false;
            pbSlot5.Click += CardClick;
            pbSlot5.MouseEnter += EnterCard;
            pbSlot5.MouseLeave += LeaveCard;
            // 
            // pbSlot6
            // 
            pbSlot6.BackColor = System.Drawing.Color.Transparent;
            pbSlot6.Cursor = Cursors.Hand;
            pbSlot6.Image = Properties.Resources.Place;
            pbSlot6.Location = new System.Drawing.Point(510, 451);
            pbSlot6.Name = "pbSlot6";
            pbSlot6.Size = new System.Drawing.Size(129, 200);
            pbSlot6.SizeMode = PictureBoxSizeMode.Zoom;
            pbSlot6.TabIndex = 5;
            pbSlot6.TabStop = false;
            pbSlot6.Visible = false;
            pbSlot6.Click += CardClick;
            pbSlot6.MouseEnter += EnterCard;
            pbSlot6.MouseLeave += LeaveCard;
            // 
            // pbSlot7
            // 
            pbSlot7.BackColor = System.Drawing.Color.Transparent;
            pbSlot7.Cursor = Cursors.Hand;
            pbSlot7.Image = Properties.Resources.Place;
            pbSlot7.Location = new System.Drawing.Point(594, 451);
            pbSlot7.Name = "pbSlot7";
            pbSlot7.Size = new System.Drawing.Size(129, 200);
            pbSlot7.SizeMode = PictureBoxSizeMode.Zoom;
            pbSlot7.TabIndex = 6;
            pbSlot7.TabStop = false;
            pbSlot7.Visible = false;
            pbSlot7.Click += CardClick;
            pbSlot7.MouseEnter += EnterCard;
            pbSlot7.MouseLeave += LeaveCard;
            // 
            // pbSlot8
            // 
            pbSlot8.BackColor = System.Drawing.Color.Transparent;
            pbSlot8.Cursor = Cursors.Hand;
            pbSlot8.Image = Properties.Resources.Place;
            pbSlot8.Location = new System.Drawing.Point(678, 451);
            pbSlot8.Name = "pbSlot8";
            pbSlot8.Size = new System.Drawing.Size(129, 200);
            pbSlot8.SizeMode = PictureBoxSizeMode.Zoom;
            pbSlot8.TabIndex = 7;
            pbSlot8.TabStop = false;
            pbSlot8.Visible = false;
            pbSlot8.Click += CardClick;
            pbSlot8.MouseEnter += EnterCard;
            pbSlot8.MouseLeave += LeaveCard;
            // 
            // pbSlot9
            // 
            pbSlot9.BackColor = System.Drawing.Color.Transparent;
            pbSlot9.Cursor = Cursors.Hand;
            pbSlot9.Image = Properties.Resources.Place;
            pbSlot9.Location = new System.Drawing.Point(762, 451);
            pbSlot9.Name = "pbSlot9";
            pbSlot9.Size = new System.Drawing.Size(129, 200);
            pbSlot9.SizeMode = PictureBoxSizeMode.Zoom;
            pbSlot9.TabIndex = 8;
            pbSlot9.TabStop = false;
            pbSlot9.Visible = false;
            pbSlot9.Click += CardClick;
            pbSlot9.MouseEnter += EnterCard;
            pbSlot9.MouseLeave += LeaveCard;
            // 
            // pbOpponent
            // 
            pbOpponent.Image = Properties.Resources.Place;
            pbOpponent.Location = new System.Drawing.Point(351, 150);
            pbOpponent.Name = "pbOpponent";
            pbOpponent.Size = new System.Drawing.Size(129, 200);
            pbOpponent.SizeMode = PictureBoxSizeMode.Zoom;
            pbOpponent.TabIndex = 9;
            pbOpponent.TabStop = false;
            // 
            // pbMe
            // 
            pbMe.BackColor = System.Drawing.Color.Transparent;
            pbMe.Image = Properties.Resources.Place;
            pbMe.Location = new System.Drawing.Point(508, 149);
            pbMe.Name = "pbMe";
            pbMe.Size = new System.Drawing.Size(129, 200);
            pbMe.SizeMode = PictureBoxSizeMode.Zoom;
            pbMe.TabIndex = 10;
            pbMe.TabStop = false;
            // 
            // lblPlayer
            // 
            lblPlayer.AutoSize = true;
            lblPlayer.BackColor = System.Drawing.Color.Transparent;
            lblPlayer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblPlayer.Location = new System.Drawing.Point(90, 420);
            lblPlayer.Name = "lblPlayer";
            lblPlayer.Size = new System.Drawing.Size(86, 21);
            lblPlayer.TabIndex = 13;
            lblPlayer.Text = "Jogador X";
            // 
            // pbOSlot1
            // 
            pbOSlot1.BackColor = System.Drawing.Color.Transparent;
            pbOSlot1.Image = Properties.Resources.Card;
            pbOSlot1.Location = new System.Drawing.Point(697, -75);
            pbOSlot1.Name = "pbOSlot1";
            pbOSlot1.Size = new System.Drawing.Size(97, 150);
            pbOSlot1.SizeMode = PictureBoxSizeMode.Zoom;
            pbOSlot1.TabIndex = 14;
            pbOSlot1.TabStop = false;
            pbOSlot1.Visible = false;
            // 
            // pbOSlot2
            // 
            pbOSlot2.BackColor = System.Drawing.Color.Transparent;
            pbOSlot2.Image = Properties.Resources.Card;
            pbOSlot2.Location = new System.Drawing.Point(634, -75);
            pbOSlot2.Name = "pbOSlot2";
            pbOSlot2.Size = new System.Drawing.Size(97, 150);
            pbOSlot2.SizeMode = PictureBoxSizeMode.Zoom;
            pbOSlot2.TabIndex = 15;
            pbOSlot2.TabStop = false;
            pbOSlot2.Visible = false;
            // 
            // pbOSlot3
            // 
            pbOSlot3.BackColor = System.Drawing.Color.Transparent;
            pbOSlot3.Image = Properties.Resources.Card;
            pbOSlot3.Location = new System.Drawing.Point(571, -75);
            pbOSlot3.Name = "pbOSlot3";
            pbOSlot3.Size = new System.Drawing.Size(97, 150);
            pbOSlot3.SizeMode = PictureBoxSizeMode.Zoom;
            pbOSlot3.TabIndex = 16;
            pbOSlot3.TabStop = false;
            pbOSlot3.Visible = false;
            // 
            // pbOSlot4
            // 
            pbOSlot4.BackColor = System.Drawing.Color.Transparent;
            pbOSlot4.Image = Properties.Resources.Card;
            pbOSlot4.Location = new System.Drawing.Point(508, -75);
            pbOSlot4.Name = "pbOSlot4";
            pbOSlot4.Size = new System.Drawing.Size(97, 150);
            pbOSlot4.SizeMode = PictureBoxSizeMode.Zoom;
            pbOSlot4.TabIndex = 17;
            pbOSlot4.TabStop = false;
            pbOSlot4.Visible = false;
            // 
            // pbOSlot5
            // 
            pbOSlot5.BackColor = System.Drawing.Color.Transparent;
            pbOSlot5.Image = Properties.Resources.Card;
            pbOSlot5.Location = new System.Drawing.Point(445, -75);
            pbOSlot5.Name = "pbOSlot5";
            pbOSlot5.Size = new System.Drawing.Size(97, 150);
            pbOSlot5.SizeMode = PictureBoxSizeMode.Zoom;
            pbOSlot5.TabIndex = 18;
            pbOSlot5.TabStop = false;
            pbOSlot5.Visible = false;
            // 
            // pbOSlot6
            // 
            pbOSlot6.BackColor = System.Drawing.Color.Transparent;
            pbOSlot6.Image = Properties.Resources.Card;
            pbOSlot6.Location = new System.Drawing.Point(382, -75);
            pbOSlot6.Name = "pbOSlot6";
            pbOSlot6.Size = new System.Drawing.Size(97, 150);
            pbOSlot6.SizeMode = PictureBoxSizeMode.Zoom;
            pbOSlot6.TabIndex = 19;
            pbOSlot6.TabStop = false;
            pbOSlot6.Visible = false;
            // 
            // pbOSlot7
            // 
            pbOSlot7.BackColor = System.Drawing.Color.Transparent;
            pbOSlot7.Image = Properties.Resources.Card;
            pbOSlot7.Location = new System.Drawing.Point(319, -75);
            pbOSlot7.Name = "pbOSlot7";
            pbOSlot7.Size = new System.Drawing.Size(97, 150);
            pbOSlot7.SizeMode = PictureBoxSizeMode.Zoom;
            pbOSlot7.TabIndex = 20;
            pbOSlot7.TabStop = false;
            pbOSlot7.Visible = false;
            // 
            // pbOSlot8
            // 
            pbOSlot8.BackColor = System.Drawing.Color.Transparent;
            pbOSlot8.Image = Properties.Resources.Card;
            pbOSlot8.Location = new System.Drawing.Point(256, -75);
            pbOSlot8.Name = "pbOSlot8";
            pbOSlot8.Size = new System.Drawing.Size(97, 150);
            pbOSlot8.SizeMode = PictureBoxSizeMode.Zoom;
            pbOSlot8.TabIndex = 21;
            pbOSlot8.TabStop = false;
            pbOSlot8.Visible = false;
            // 
            // pbOSlot9
            // 
            pbOSlot9.BackColor = System.Drawing.Color.Transparent;
            pbOSlot9.Image = Properties.Resources.Card;
            pbOSlot9.Location = new System.Drawing.Point(193, -75);
            pbOSlot9.Name = "pbOSlot9";
            pbOSlot9.Size = new System.Drawing.Size(97, 150);
            pbOSlot9.SizeMode = PictureBoxSizeMode.Zoom;
            pbOSlot9.TabIndex = 22;
            pbOSlot9.TabStop = false;
            pbOSlot9.Visible = false;
            // 
            // lblMyTurn
            // 
            lblMyTurn.AutoSize = true;
            lblMyTurn.BackColor = System.Drawing.Color.Transparent;
            lblMyTurn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblMyTurn.ForeColor = System.Drawing.Color.FromArgb(50, 188, 239);
            lblMyTurn.Location = new System.Drawing.Point(193, 420);
            lblMyTurn.Name = "lblMyTurn";
            lblMyTurn.Size = new System.Drawing.Size(97, 21);
            lblMyTurn.TabIndex = 23;
            lblMyTurn.Text = "É a sua vez!";
            lblMyTurn.Visible = false;
            // 
            // pbEnergy
            // 
            pbEnergy.BackColor = System.Drawing.Color.Transparent;
            pbEnergy.Image = Properties.Resources.EnergySprite;
            pbEnergy.Location = new System.Drawing.Point(745, 181);
            pbEnergy.Name = "pbEnergy";
            pbEnergy.Size = new System.Drawing.Size(60, 60);
            pbEnergy.SizeMode = PictureBoxSizeMode.Zoom;
            pbEnergy.TabIndex = 24;
            pbEnergy.TabStop = false;
            pbEnergy.Visible = false;
            // 
            // pbNature
            // 
            pbNature.BackColor = System.Drawing.Color.Transparent;
            pbNature.Image = Properties.Resources.NatureSprite;
            pbNature.Location = new System.Drawing.Point(745, 261);
            pbNature.Name = "pbNature";
            pbNature.Size = new System.Drawing.Size(60, 60);
            pbNature.SizeMode = PictureBoxSizeMode.Zoom;
            pbNature.TabIndex = 25;
            pbNature.TabStop = false;
            pbNature.Visible = false;
            // 
            // pbWind
            // 
            pbWind.BackColor = System.Drawing.Color.Transparent;
            pbWind.Image = Properties.Resources.WindSprite;
            pbWind.Location = new System.Drawing.Point(825, 181);
            pbWind.Name = "pbWind";
            pbWind.Size = new System.Drawing.Size(60, 60);
            pbWind.SizeMode = PictureBoxSizeMode.Zoom;
            pbWind.TabIndex = 26;
            pbWind.TabStop = false;
            pbWind.Visible = false;
            // 
            // pbSparkle
            // 
            pbSparkle.BackColor = System.Drawing.Color.Transparent;
            pbSparkle.Image = Properties.Resources.SparkleSprite;
            pbSparkle.Location = new System.Drawing.Point(825, 261);
            pbSparkle.Name = "pbSparkle";
            pbSparkle.Size = new System.Drawing.Size(60, 60);
            pbSparkle.SizeMode = PictureBoxSizeMode.Zoom;
            pbSparkle.TabIndex = 27;
            pbSparkle.TabStop = false;
            pbSparkle.Visible = false;
            // 
            // pbWinLose
            // 
            pbWinLose.BackColor = System.Drawing.Color.Transparent;
            pbWinLose.Location = new System.Drawing.Point(100, 181);
            pbWinLose.Name = "pbWinLose";
            pbWinLose.Size = new System.Drawing.Size(140, 140);
            pbWinLose.SizeMode = PictureBoxSizeMode.Zoom;
            pbWinLose.TabIndex = 30;
            pbWinLose.TabStop = false;
            // 
            // btnForward
            // 
            btnForward.BackColor = System.Drawing.SystemColors.Control;
            btnForward.BackgroundImage = Properties.Resources.forward;
            btnForward.BackgroundImageLayout = ImageLayout.Zoom;
            btnForward.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            btnForward.BorderRadius = 10;
            btnForward.BorderSize = 0;
            btnForward.FlatAppearance.BorderSize = 0;
            btnForward.FlatStyle = FlatStyle.Flat;
            btnForward.ForeColor = System.Drawing.SystemColors.ControlText;
            btnForward.Location = new System.Drawing.Point(903, 504);
            btnForward.Name = "btnForward";
            btnForward.Size = new System.Drawing.Size(60, 60);
            btnForward.TabIndex = 31;
            btnForward.UseVisualStyleBackColor = false;
            btnForward.Click += btnForward_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = System.Drawing.SystemColors.Control;
            btnBack.BackgroundImage = Properties.Resources.back;
            btnBack.BackgroundImageLayout = ImageLayout.Zoom;
            btnBack.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            btnBack.BorderRadius = 10;
            btnBack.BorderSize = 0;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.ForeColor = System.Drawing.SystemColors.ControlText;
            btnBack.Location = new System.Drawing.Point(18, 504);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(60, 60);
            btnBack.TabIndex = 32;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnOpponent
            // 
            btnOpponent.BorderColor = System.Drawing.Color.Empty;
            btnOpponent.BorderRadius = 10;
            btnOpponent.BorderSize = 0;
            btnOpponent.FlatAppearance.BorderSize = 0;
            btnOpponent.FlatStyle = FlatStyle.Flat;
            btnOpponent.ForeColor = System.Drawing.SystemColors.ControlText;
            btnOpponent.Location = new System.Drawing.Point(345, 144);
            btnOpponent.Name = "btnOpponent";
            btnOpponent.Size = new System.Drawing.Size(140, 211);
            btnOpponent.TabIndex = 33;
            btnOpponent.UseVisualStyleBackColor = false;
            // 
            // btnMe
            // 
            btnMe.BorderColor = System.Drawing.Color.Empty;
            btnMe.BorderRadius = 10;
            btnMe.BorderSize = 0;
            btnMe.FlatAppearance.BorderSize = 0;
            btnMe.FlatStyle = FlatStyle.Flat;
            btnMe.ForeColor = System.Drawing.SystemColors.ControlText;
            btnMe.Location = new System.Drawing.Point(503, 144);
            btnMe.Name = "btnMe";
            btnMe.Size = new System.Drawing.Size(140, 211);
            btnMe.TabIndex = 34;
            btnMe.UseVisualStyleBackColor = false;
            // 
            // Game
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(984, 611);
            Controls.Add(pbMe);
            Controls.Add(btnMe);
            Controls.Add(pbOpponent);
            Controls.Add(btnOpponent);
            Controls.Add(btnBack);
            Controls.Add(btnForward);
            Controls.Add(pbWinLose);
            Controls.Add(pbSparkle);
            Controls.Add(pbWind);
            Controls.Add(pbNature);
            Controls.Add(pbEnergy);
            Controls.Add(lblMyTurn);
            Controls.Add(pbOSlot9);
            Controls.Add(pbOSlot8);
            Controls.Add(pbOSlot7);
            Controls.Add(pbOSlot6);
            Controls.Add(pbOSlot5);
            Controls.Add(pbOSlot4);
            Controls.Add(pbOSlot3);
            Controls.Add(pbOSlot2);
            Controls.Add(pbOSlot1);
            Controls.Add(lblPlayer);
            Controls.Add(pbSlot9);
            Controls.Add(pbSlot8);
            Controls.Add(pbSlot7);
            Controls.Add(pbSlot6);
            Controls.Add(pbSlot5);
            Controls.Add(pbSlot4);
            Controls.Add(pbSlot3);
            Controls.Add(pbSlot2);
            Controls.Add(pbSlot1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Game";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Elemential";
            FormClosing += Game_FormClosing;
            Load += Game_Load;
            ((System.ComponentModel.ISupportInitialize)pbSlot1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSlot2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSlot3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSlot4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSlot5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSlot6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSlot7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSlot8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSlot9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOpponent).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMe).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOSlot1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOSlot2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOSlot3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOSlot4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOSlot5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOSlot6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOSlot7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOSlot8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOSlot9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEnergy).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbNature).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbWind).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSparkle).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbWinLose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbSlot1;
        private PictureBox pbSlot2;
        private PictureBox pbSlot3;
        private PictureBox pbSlot4;
        private PictureBox pbSlot5;
        private PictureBox pbSlot6;
        private PictureBox pbSlot7;
        private PictureBox pbSlot8;
        private PictureBox pbSlot9;
        private PictureBox pbOpponent;
        private PictureBox pbMe;
        private Label lblPlayer;
        private PictureBox pbOSlot1;
        private PictureBox pbOSlot2;
        private PictureBox pbOSlot3;
        private PictureBox pbOSlot4;
        private PictureBox pbOSlot5;
        private PictureBox pbOSlot6;
        private PictureBox pbOSlot7;
        private PictureBox pbOSlot8;
        private PictureBox pbOSlot9;
        private Label lblMyTurn;
        private PictureBox pbEnergy;
        private PictureBox pbNature;
        private PictureBox pbWind;
        private PictureBox pbSparkle;
        private PictureBox pbWinLose;
        private Components.RoundedButton btnForward;
        private Components.RoundedButton btnBack;
        private Components.RoundedButton btnOpponent;
        private Components.RoundedButton btnMe;
    }
}