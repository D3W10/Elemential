using Elemential.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Elemential
{
    public partial class Finish : Form
    {
        public Finish(bool win)
        {
            InitializeComponent();

            if (win)
            {
                pbFinish.Image = Resources.ResourceManager.GetObject("Trophy") as Bitmap;
                lblFinish.Text = "Parabéns, és um mestre elementar!";
            }
            else
            {
                pbFinish.Image = Resources.ResourceManager.GetObject("Bang") as Bitmap;
                lblFinish.Text = "Perdeste. Continua a tentar!";
            }
        }
    }
}