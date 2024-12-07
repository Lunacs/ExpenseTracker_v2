using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.UI.WinForms; // Ensure you have the correct namespace for Bunifu controls

namespace Expense_Tracker_v2
{
    public partial class LoadingScreen : Form
    {
        private BackgroundWorker backgroundWorker;

        public LoadingScreen()
        {
            InitializeComponent();

            InitializeBackgroundWorker();

            // Set the SizeMode property
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            // Handle the Paint event
            pictureBox1.Paint += PictureBox1_Paint;
        }

        private void InitializeBackgroundWorker()
        {
            backgroundWorker = new BackgroundWorker();
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.DoWork += new DoWorkEventHandler(backgroundWorker_DoWork);
            backgroundWorker.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker_ProgressChanged);
            backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker_RunWorkerCompleted);
        }

        private void LoadingScreen_Load(object sender, EventArgs e)
        {
            backgroundWorker.RunWorkerAsync();
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i <= 100; i += 2)
            {
                backgroundWorker.ReportProgress(i);
                System.Threading.Thread.Sleep(50); // Simulate work being done
            }
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            UpdateProgressBar(e.ProgressPercentage);
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Close();
        }

        // Method to update the progress bar
        public void UpdateProgressBar(int value)
        {
            if (bunifuProgressBar1.InvokeRequired)
            {
                bunifuProgressBar1.Invoke(new Action(() => bunifuProgressBar1.Value = value));
            }
            else
            {
                bunifuProgressBar1.Value = value;
            }
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                e.Graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                e.Graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                e.Graphics.DrawImage(pictureBox1.Image, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
            }
        }
    }
}
