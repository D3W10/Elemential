using System.Windows.Forms;

namespace Elemential
{
    partial class Finish
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Finish));
            pbFinish = new PictureBox();
            lblFinish = new Label();
            btnOk = new Button();
            ((System.ComponentModel.ISupportInitialize)pbFinish).BeginInit();
            SuspendLayout();
            // 
            // pbFinish
            // 
            pbFinish.Location = new System.Drawing.Point(12, 12);
            pbFinish.Name = "pbFinish";
            pbFinish.Size = new System.Drawing.Size(60, 60);
            pbFinish.SizeMode = PictureBoxSizeMode.Zoom;
            pbFinish.TabIndex = 0;
            pbFinish.TabStop = false;
            // 
            // lblFinish
            // 
            lblFinish.AutoSize = true;
            lblFinish.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblFinish.Location = new System.Drawing.Point(82, 12);
            lblFinish.Name = "lblFinish";
            lblFinish.Size = new System.Drawing.Size(40, 21);
            lblFinish.TabIndex = 0;
            lblFinish.Text = "null";
            // 
            // btnOk
            // 
            btnOk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnOk.Location = new System.Drawing.Point(304, 49);
            btnOk.Name = "btnOk";
            btnOk.Size = new System.Drawing.Size(75, 23);
            btnOk.TabIndex = 0;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            // 
            // Finish
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(394, 86);
            Controls.Add(btnOk);
            Controls.Add(lblFinish);
            Controls.Add(pbFinish);
            Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Finish";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Elemential";
            ((System.ComponentModel.ISupportInitialize)pbFinish).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbFinish;
        private Label lblFinish;
        private Button btnOk;
    }
}