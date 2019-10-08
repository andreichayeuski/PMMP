using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMMP_Lab05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var image = new Image<Gray, byte>("books.jpg");
            var image2 = new Image<Gray, float>(image.Size);
            CvInvoke.CornerHarris(image, image2, 2);
            var image1 = image2.Convert<Gray, byte>().ThresholdBinary(new Gray(47), new Gray(255));
            this.imageBox1.Image = image;
            this.imageBox2.Image = image1;
            var form2 = new Form2();
            form2.Show();
        }
    }
}
