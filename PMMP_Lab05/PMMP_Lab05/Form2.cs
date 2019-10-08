using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Features2D;
using Emgu.CV.Tracking;
using Emgu.CV.Structure;
using Emgu.Util;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            var image = new Image<Gray, byte>("books.jpg");
            var image2 = new Image<Gray, byte>("books.jpg");
            var image1 = image2.Convert<Gray, byte>().ThresholdBinary(new Gray(87), new Gray(255));
            foreach (var mKeyPoint in new GFTTDetector(500).Detect(image1))
            {
                image2.Draw(new CircleF(mKeyPoint.Point, 1), new Gray(250), 1);
            }

            this.imageBox1.Image = image;
            this.imageBox2.Image = image2;

            var form3 = new Form3();
            form3.Show();
        }
    }
}
