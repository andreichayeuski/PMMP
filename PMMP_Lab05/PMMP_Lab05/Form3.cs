using Emgu.CV;
using Emgu.CV.Features2D;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            var image = new Image<Gray, byte>("coupon.png");
            var image1 = new Image<Gray, byte>("coupon.png");
            PointF[] srcs = new PointF[4];
            srcs[0] = new PointF(100, 300);
            srcs[1] = new PointF(410, 163);
            srcs[2] = new PointF(311, 35);
            srcs[3] = new PointF(46, 129);


            PointF[] dsts = new PointF[4];
            dsts[0] = new PointF(0, 300);
            dsts[1] = new PointF(400, 300);
            dsts[2] = new PointF(400, 0);
            dsts[3] = new PointF(0, 0);
            Mat mywarpmat = CvInvoke.GetPerspectiveTransform(srcs, dsts);
            CvInvoke.WarpPerspective(image, image1, mywarpmat, image.Size);
            this.imageBox1.Image = image;
            this.imageBox2.Image = image1;
        }
    }
}
