namespace WindowsFormsApp1
{
    using Managed.Adb;
    using System;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        private Process process;
        private System.Timers.Timer timer;
        private Device device = null;

        private Stopwatch sw;
        private Stopwatch sw2;

        private enum MethodOfCapture
        {
            GetWindowRect = 0,
            DeviceScreenshot = 1
        }

        private MethodOfCapture methodOfCapture = MethodOfCapture.GetWindowRect;

        public Form1()
        {
            InitializeComponent();
            this.cboMethodOfCapture.SelectedIndex = (int)methodOfCapture;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer != null)
            {
                timer.Stop();
            }

            this.Text = "";

            var processes = Process.GetProcessesByName("MEmu");

            if (processes.Length == 0)
            {
                this.Text = "Failed to find MEMU !";
                return;
            }
            else if (processes.Length > 1)
            {
                this.Text = "More than one Memu found, using first!";
            }

            process = processes[0];

            var devices = AdbHelper.Instance.GetDevices(AndroidDebugBridge.SocketAddress);
            device = devices[0];

            timer = new System.Timers.Timer();
            timer.Interval = 10;
            timer.Elapsed += OnTimedEvent;
            timer.AutoReset = true;
            timer.Enabled = true;
        }

        private void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            timer.Stop();

            sw = new Stopwatch();
            sw.Start();

            if (methodOfCapture == MethodOfCapture.GetWindowRect)
            {
                GetWindowRect();
            }

            if (methodOfCapture == MethodOfCapture.DeviceScreenshot)
            {
                DeviceScreenShot();
            }

            sw.Stop();
            var text = "Duration: " + sw2.ElapsedMilliseconds + "ms" + " ( " + sw.ElapsedMilliseconds + "ms)";

            if (this.labDuration.InvokeRequired)
            {
                this.labDuration.BeginInvoke((MethodInvoker)delegate () { this.labDuration.Text = text; });
            }
            else
            {
                this.labDuration.Text = text;
            }

            timer.Start();
        }

        private void DeviceScreenShot()
        {
            sw2 = new Stopwatch();
            sw2.Start();

            if (device != null)
            {
                var sh = device.Screenshot;
                sw2.Stop();
                pictureBox1.BackgroundImage = sh.ToImage();
            }
        }

        private void GetWindowRect()
        {
            sw2 = new Stopwatch();
            sw2.Start();

            var bitmap = CaptureScreen.SnapShot(3, 34, new Size(500, 750), process);
            sw2.Stop();
            if (bitmap != null)
            {
                var memoryStream = new MemoryStream();
                bitmap.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
                var image = Image.FromStream(memoryStream);
                pictureBox1.BackgroundImage = image;
            }
        }

        private void cboMethodOfCapture_SelectedIndexChanged(object sender, EventArgs e)
        {
            methodOfCapture = (MethodOfCapture)cboMethodOfCapture.SelectedIndex;
        }
    }
}