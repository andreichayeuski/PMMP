using Emgu.CV.Structure;
using System;
using System.Windows.Forms;

namespace PMMP_Lab01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.imageBox1.Image = new Emgu.CV.Image<Gray, byte>("sun.bmp").ThresholdBinary(new Gray(240), new Gray(255));
            this.imageBox2.Image = new Emgu.CV.Image<Bgr, byte>("sun.bmp");

        }
    }
}
