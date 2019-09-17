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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            var image = new Image<Gray, byte>("light.jpg");
            var image1 = new Image<Gray, byte>("light.jpg");
            CvInvoke.Canny(image, image1, 10, 10, 3);
            this.imageBox1.Image = image1;
            var image2 = new Image<Gray, byte>("light.jpg");
            CvInvoke.EqualizeHist(image, image2);
            this.imageBox2.Image = image2;
        }
    }
}
