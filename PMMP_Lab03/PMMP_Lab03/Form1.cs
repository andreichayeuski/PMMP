using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;

//DiresctShow
using DirectShowLib;
namespace PMMP_Lab03
{
    public partial class Form1 : Form
    {
        #region Variables
        #region Camera Capture Variables
        private Emgu.CV.VideoCapture _capture = null; //Camera
        private bool _captureInProgress = false; //Variable to track camera state
        int CameraDevice = 0; //Variable to track camera device selected
        Video_Device[] WebCams; //List containing all the camera available
        #endregion
        #region Camera Settings
        int Brightness_Store = 0;
        int Contrast_Store = 0;
        int Sharpness_Store = 0;
        #endregion
        #endregion
        public Form1()
        {
            InitializeComponent();
            Slider_Enable(false); //Disable sliders untill capturing

            //-> Find systems cameras with DirectShow.Net dll
            //thanks to carles lloret
            DsDevice[] _SystemCamereas = DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice);
            WebCams = new Video_Device[_SystemCamereas.Length];
            for (int i = 0; i < _SystemCamereas.Length; i++)
            {
                WebCams[i] = new Video_Device(i, _SystemCamereas[i].Name, _SystemCamereas[i].ClassID); //fill web cam array
                Camera_Selection.Items.Add(WebCams[i].ToString());
            }
            if (Camera_Selection.Items.Count > 0)
            {
                Camera_Selection.SelectedIndex = 0; //Set the selected device the default
                captureButton.Enabled = true; //Enable the start
            }
        }


        private void Slider_Enable(bool State)
        {
            /*Brigtness_SLD.Enabled = State;
            Contrast_SLD.Enabled = State;
            Sharpness_SLD.Enabled = State;*/
        }

        private void CaptureButton_Click(object sender, EventArgs e)
        {
            if (_capture != null)
            {
                if (_captureInProgress)
                {
                    //stop the capture
                    captureButton.Text = "Start Capture"; //Change text on button
                    Slider_Enable(false);
                    _capture.Pause(); //Pause the capture
                    _captureInProgress = false; //Flag the state of the camera
                }
                else
                {
                    //Check to see if the selected device has changed
                    /*if (Camera_Selection.SelectedIndex != CameraDevice)
                    {
                        SetupCapture(Camera_Selection.SelectedIndex); //Setup capture with the new device
                    }*/

                    //RetrieveCaptureInformation(); //Get Camera information
                    captureButton.Text = "Stop"; //Change text on button
                    //StoreCameraSettings(); //Save Camera Settings
                    Slider_Enable(true);  //Enable User Controls
                    _capture.Start(); //Start the capture
                    _captureInProgress = true; //Flag the state of the camera
                }

            }
            else
            {
                //set up capture with selected device
                SetupCapture(Camera_Selection.SelectedIndex);
                //Be lazy and Recall this method to start camera
                CaptureButton_Click(null, null);
            }
        }
        private void SetupCapture(int Camera_Identifier)
        {
            //update the selected device
            CameraDevice = Camera_Identifier;

            //Dispose of Capture if it was created before
            if (_capture != null) _capture.Dispose();
            try
            {
                //Set up capture device
                _capture = new VideoCapture(CameraDevice);
                _capture.ImageGrabbed += ProcessFrame;
            }
            catch (NullReferenceException excpt)
            {
                MessageBox.Show(excpt.Message);
            }
        }

        private void ProcessFrame(object sender, EventArgs arg)
        {
            //***If you want to access the image data the use the following method call***/
            //Image<Bgr, Byte> frame = new Image<Bgr,byte>(_capture.RetrieveBgrFrame().ToBitmap());
            Mat frame = new Mat();//;
            Mat frame1 = new Mat();//;
            _capture.Retrieve(frame);
            _capture.Retrieve(frame1);
            CvInvoke.MedianBlur(frame1, frame, 5);//new Size { Height = 1, Width = 1 }, 1);
            if (RetrieveBgrFrame.Checked)
            {
                //because we are using an autosize picturebox we need to do a thread safe update
                DisplayImage(frame.ToImage<Bgr, byte>().ToBitmap());
            }
            if (RetrieveGrayFrame.Checked)
            {
                //because we are using an autosize picturebox we need to do a thread safe update
                DisplayImage(frame.ToImage<Gray, byte>().ToBitmap());
            }
            if (RetrieveSobel.Checked)
            {
                CvInvoke.Sobel(frame, frame, Emgu.CV.CvEnum.DepthType.Default, 1, 1);
                //because we are using an autosize picturebox we need to do a thread safe update
                DisplayImage(frame.ToImage<Gray, byte>().ThresholdBinary(new Gray(10), new Gray(255)).ToBitmap());
            }
            if (RetrieveLaplas.Checked)
            {
                CvInvoke.Laplacian(frame, frame, Emgu.CV.CvEnum.DepthType.Default);
                //because we are using an autosize picturebox we need to do a thread safe update
                DisplayImage(frame.ToImage<Gray, byte>().ThresholdBinary(new Gray(10), new Gray(255)).ToBitmap());
            }
            if (RetrieveKanny.Checked)
            {
                CvInvoke.Canny(frame1, frame, 10, 10, apertureSize:3);
                //because we are using an autosize picturebox we need to do a thread safe update
                DisplayImage(frame.ToImage<Gray, byte>().ThresholdBinary(new Gray(10), new Gray(255)).ToBitmap());
            }
        }

        private delegate void DisplayImageDelegate(Bitmap Image);
        private void DisplayImage(Bitmap Image)
        {
            if (captureBox.InvokeRequired)
            {
                try
                {
                    DisplayImageDelegate DI = new DisplayImageDelegate(DisplayImage);
                    this.BeginInvoke(DI, new object[] { Image });
                }
                catch (Exception ex)
                {
                }
            }
            else
            {
                captureBox.Image = Image;
            }
        }
    }
}
