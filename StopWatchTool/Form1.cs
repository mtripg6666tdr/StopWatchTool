using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatchTool
{
    public partial class Form1 : Form
    {
        Stopwatch MainStopwatch = null;
        int SplitCount = 1;
        bool FormMoving = false;

        public Form1()
        {
            this.InitializeComponent();

            this.MainStopwatch = new Stopwatch();

            Task.Run(() =>
            {
                Thread.Sleep(1000);
                while(true)
                {
                    string timeStr = (string)this.Invoke(new Func<string>(this.GetStopWatchTime));
                    this.Invoke(new Action<string>(this.SetStopWatchValue), timeStr);
                    Thread.Sleep(20);
                }
            });
        }

        private void SetStopWatchValue(string str)
        {
            this.StopWatchValueHolder.Text = str;
        }

        private string GetStopWatchTime()
        {
            return this.MainStopwatch.Elapsed.ToString();
        }

        private void StopWatchStartStopButton_Click(object sender, EventArgs e)
        {
            Button senderButton = (Button)sender;
            if(senderButton.Text == "Start")
            {
                this.MainStopwatch.Start();
                this.StopWatchStartStopButton.Text = "Stop";
                this.StopWatchSplitResetButton.Text = "Split";
                return;
            }
            if(senderButton.Text == "Stop")
            {
                this.MainStopwatch.Stop();
                this.StopWatchStartStopButton.Text = "Start";
                this.StopWatchSplitResetButton.Text = "Reset";
                return;
            }
        }

        private void StopWatchSplitResetButton_Click(object sender, EventArgs e)
        {
            Button senderButton = (Button)sender;
            if(senderButton.Text == "Split")
            {
                string str = this.StopWatchValueHolder.Text;
                int splitCount = this.SplitCount;
                Task.Run(() =>
                {
                    MessageBox.Show($"Split Time {splitCount}\r\n{str}", $"Split Time {splitCount}");
                });
                this.SplitCount++;
            }
            if(senderButton.Text == "Reset")
            {
                this.MainStopwatch.Stop();
                this.MainStopwatch.Reset();
            }
        }

        private void CustomFormCloseButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("The StopWatchTool is going to quit.\r\nIf it quit, the time will be erase.", "Attention", MessageBoxButtons.OKCancel)==DialogResult.OK)
            {
                this.Close();
            }
        }

        private async void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button != MouseButtons.Left)
            {
                return;
            }
            Point difference = new Point(MousePosition.X - this.Location.X, MousePosition.Y - this.Location.Y);
            this.FormMoving = true;
            while (this.FormMoving)
            {
                this.Location = new Point(MousePosition.X - difference.X, MousePosition.Y - difference.Y);
                await Task.Run(() =>
                {
                    Thread.Sleep(100);
                });
            }
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
            this.FormMoving = false;
        }
    }
}
