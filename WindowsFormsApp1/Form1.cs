namespace WindowsFormsApp1
{
    using System;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        Process process;
        System.Timers.Timer timer;

        public Form1()
        {
            InitializeComponent();
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

            timer = new System.Timers.Timer();
            timer.Interval = 10;
            timer.Elapsed += OnTimedEvent;
            timer.AutoReset = true;
            timer.Enabled = true;
        }

        private void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            timer.Stop();

            var bitmap = CaptureScreen.SnapShot(3, 34, new Size(500, 750), process);

            if (bitmap != null)
            {
                var memoryStream = new MemoryStream();
                bitmap.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
                var image = Image.FromStream(memoryStream);
                pictureBox1.BackgroundImage = image;
            }

            timer.Start();
        }
    }
}
