using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMMP_Lab02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ConvolutionKernelF Kernel = new ConvolutionKernelF(
            new float[,] {
                {-0.1f, 0.2f, -0.1f,
                 0.2f, 3.0f, 0.2f,
                -0.1f, 0.2f, -0.1f}
            }
        );

            var image = new Image<Bgr, byte>("light.jpg");
            var image2 = image.Copy().Convolution(Kernel);
            CvInvoke.Filter2D(image, image2, Kernel, new Point() { X = -1, Y = -1 });
            this.imageBox1.Image = new Emgu.CV.Image<Bgr, byte>("light.jpg");
            this.imageBox2.Image = image2;
            var image3 = image.Copy();
            CvInvoke.Blur(image, image3, new Size { Height = 100, Width = 100 }, new Point() { X = 11, Y = 11 });
            this.imageBox3.Image = image3;
            var image4 = image.Copy();
            CvInvoke.BoxFilter(image, image4, Emgu.CV.CvEnum.DepthType.Default, new Size { Height = 1, Width = 1 }, new Point() { X = -1, Y = -1 },false);
            this.imageBox4.Image = image4;
            var image5 = image.Copy();
            CvInvoke.GaussianBlur(image, image5, new Size { Height = 201, Width = 201 }, 1);
            this.imageBox5.Image = image5;
            var image6 = image.Copy();
            CvInvoke.MedianBlur(image, image6, 5);
            this.imageBox6.Image = image6;

            var image9 = new Image<Gray, byte>("17.jpg");
            this.imageBox9.Image = image9;
            var image7 = new Image<Gray, byte>("17.jpg");
            CvInvoke.Erode(image9, image7, new Mat(), new Point() { X = -1, Y = -1 }, 1, Emgu.CV.CvEnum.BorderType.Default, new MCvScalar(1));
            this.imageBox7.Image = image7;
            var image8 = new Image<Gray, byte>("17.jpg");
            CvInvoke.Dilate(image9, image8, new Mat(), new Point() { X = -1, Y = -1 }, 1, Emgu.CV.CvEnum.BorderType.Default, new MCvScalar(1));
            this.imageBox8.Image = image8;

            new Form2().Show();
        }
    }
}
