using System;
using System.Windows.Forms;
using CheckTimerLib;

namespace CheckTimer
{
    public partial class MainWindow : Form
    {
        public MyTimer timer;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            timer = new MyTimer(5000);
            startButton.Enabled = true;
        }
    }
}
