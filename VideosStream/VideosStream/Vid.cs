using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;

namespace VideosStream
{

    public partial class Vid : Form
    {

        public Vid()
        {
            // create JPEG video source
            JPEGStream stream = new JPEGStream("some url");
            // set NewFrame event handler
            stream.NewFrame += new NewFrameEventHandler(video_NewFrame);

            stream.VideoSourceError += new VideoSourceErrorEventHandler(stream_VideoSource);

            stream.Login = "1jfiegbqbk2xq";
            stream.Password = "Alchurman1!";
            stream.RequestTimeout = 10000;
            stream.Source = "http://192.168.0.33/nphMotionJpeg?Resolution=320x240&Quality=Standard";
            
            // start the video source
            stream.Start();
            // ...
            // signal to stop
            stream.SignalToStop();
            // ...
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Vid vid = new Vid();
        }

        private void stream_VideoSource(object sender, VideoSourceErrorEventArgs eventArgs)
        {
            throw new NotImplementedException();
        }

        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            // get new frame
            Bitmap bitmap = eventArgs.Frame;

            pictureBox1.Image = bitmap;
            // process the frame
        }




    }
}













/*  private FilterInfoCollection videoDevices;
    private VideoCaptureDevice vidSource;


    private string currentDevice;

    private BitmapImage image;
    private string ipCameraUrl;

    private bool isDesktopSource;
    private bool isIpCameraSource;
    private bool isWebSource;

    #region Constructor
    public Vid()
    {
        InitializeComponent();
        IsDesktopSource = true;
        StartSourceCommand = new RelayCommand(StartCamera);
        StopSourceCommand = new RelayCommand(StopCamera);
        StartRecordingCommand = new RelayCommand(StartRecording);
        StopRecordingCommand = new RelayCommand(StopRecording);
        SaveSnapShotCommand = new RelayCommand(SaveSnapshot);
       // IpCameraUrl = "";
    }

    #endregion

    #region Properties

    public ObservableCollection<string> VideoDevices { get; set; }

    public BitmapImage Image
    {
        get { return image; }
        set { Set(ref image, value); }
    }

    public bool IsDesktopSource
    {
        get { return isDesktopSource; }
        set { Set(ref isDesktopSource, value); }
    }

    /*public bool IsWebcamSource
    {
        get { return isWebcamSource; }
        set { Set(ref isWebcamSource, value); }
    }

    public ICommand StartSourceCommand { get; private set; }
    public ICommand StopSourceCommand { get; private set; }
    public ICommand StartRecordingCommand { get; private set; }
    public ICommand StopRecordingCommand { get; private set; }
    public ICommand SaveSnapShotCommand { get; private set; }

    #endregion

    private void Form1_Load(object sender, EventArgs e)
    {
        videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
    }

    private void StartCamera()
    {

    }

    private void StopCamera()
    {

    }

    private void StopRecording()
    {

    }

    private void StartRecording()
    {

    }

    private void SaveSnapshot()
    {

    }
    */
