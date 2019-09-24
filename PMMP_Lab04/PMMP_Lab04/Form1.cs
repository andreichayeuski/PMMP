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
using System.Windows;
using System.Windows.Forms;

namespace PMMP_Lab04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Image<Bgr, byte> image = new Image<Bgr, byte>("money.jpg");
            Image<Bgr, byte> hierarchy = new Image<Bgr, byte>("money.jpg"); 
            var image1 = image.Convert<Gray, byte>().ThresholdBinary(new Gray(128), new Gray(255));
            var listPoints = new VectorOfVectorOfPoint();
            CvInvoke.FindContours(image1, listPoints, hierarchy, Emgu.CV.CvEnum.RetrType.List, 
                Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);
            CvInvoke.DrawContours(image, listPoints, -1, new MCvScalar(0, 0, 255));
            var q = listPoints.Size;
            this.imageBox1.Image = image1;
            this.imageBox2.Image = image;

            Image<Gray, byte> image3 = new Image<Gray, byte>("street.jpg").ThresholdBinary(new Gray(128), new Gray(255));
            Image<Bgr, byte> image4 = new Image<Bgr, byte>("street.jpg");//.ThresholdBinary(new Gray(128), new Gray(255));
            LineSegment2D[] lines = null;
            UMat umat = new UMat();
            VectorOfPointF vectorOfPointF = new VectorOfPointF();
            lines = CvInvoke.HoughLinesP(image3,
               1, //Distance resolution in pixel-related units
               Math.PI, //Angle resolution measured in radians.
               20, //threshold
               20, //min Line width
               10);
            var q1 = vectorOfPointF.Size;
            foreach (var line in lines)
            {
                image4.Draw(line, new Bgr (0, 0, 255), 1);
            }

            this.imageBox3.Image = image3;
            this.imageBox4.Image = image4;

            Image<Gray, byte> image5 = new Image<Gray, byte>("money.jpg");//.ThresholdBinary(new Gray(128), new Gray(255));
            Image<Bgr, byte> image6 = new Image<Bgr, byte>("money.jpg");//.ThresholdBinary(new Gray(128), new Gray(255));
            //CircleF[][] circlesAll = image6.HoughCircles(new Bgr(100, 100, 100), new Bgr(255, 255, 255), 1, 1);
            CircleF[][] circlesAll = image5.HoughCircles(new Gray(255), new Gray(50), 1, image6.Height / 8, 10, 80);

            foreach (var circles in circlesAll)
            {
                foreach (CircleF circle in circles)
                {
                    image6.Draw(circle, new Bgr(Color.Red), 2);
                }
            }
            this.imageBox5.Image = image6;
            this.imageBox6.Image = image5.ThresholdBinary(new Gray(128), new Gray(255));
        }
    }
}
