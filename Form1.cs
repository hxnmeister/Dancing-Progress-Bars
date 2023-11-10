using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DancingProgressBars
{
    public partial class Form1 : Form
    {
        private Thread[] threads = null;
        private int startingWindowHeight;
        private readonly Random rnd = new Random();
        private List<ProgressBar> progressList = new List<ProgressBar>();

        public Form1()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(Math.Floor(NumberOfBarsUpDown.Value));
            int progressBarStartingPointY = ControlGroupBox.Location.Y + ControlGroupBox.Height;
            int barWidth = ControlGroupBox.Width;
            const int indentY = 25;
            const int barHeight = 20;

            threads = new Thread[count];
            startingWindowHeight = this.Height;

            for (int i = 0; i < count; i++)
            {
                ProgressBar progressBar = new ProgressBar()
                {
                    Location = new Point(ControlGroupBox.Location.X, progressBarStartingPointY),
                    Size = new Size(barWidth, barHeight),
                    Maximum = 100,
                    Value = 0,
                    Style = ProgressBarStyle.Continuous
                };

                Controls.Add(progressBar);
                progressList.Add(progressBar);

                threads[i] = new Thread(new ParameterizedThreadStart(RunProgressBar)) { IsBackground = true };
                threads[i].Start(progressBar);

                progressBarStartingPointY += indentY;
                this.Height += indentY;
            }

            ResetButton.Enabled = true;
            SubmitButton.Enabled = false;
            NumberOfBarsUpDown.Enabled = false;
        }

        private void NumberOfBarsUpDown_ValueChanged(object sender, EventArgs e)
        {
            SubmitButton.Enabled = NumberOfBarsUpDown.Value > 0;
        }

        private void RunProgressBar(object item)
        {
            ProgressBar progressBar = (ProgressBar)item;

            while (progressBar.Value < progressBar.Maximum)
            {
                try
                {
                    progressBar.Invoke(new Action(() =>
                    {
                        Monitor.Enter(progressBar);
                        try
                        {
                            progressBar.Value = rnd.Next(1, 100);
                        }
                        finally
                        {
                            Monitor.Exit(progressBar);
                        }
                    }));

                    Thread.Sleep(100);
                }
                catch (ThreadInterruptedException te)
                {
                    MessageBox.Show(te.Message, "Emergency Break!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            foreach (Thread thread in threads)
            {
                if(thread.IsAlive)
                {
                    thread.Interrupt();
                }
            }
            foreach (ProgressBar progressBar in progressList)
            {
                Controls.Remove(progressBar);
            }

            progressList.Clear();

            ResetButton.Enabled = false;
            SubmitButton.Enabled = true;
            NumberOfBarsUpDown.Enabled = true;

            this.Height = startingWindowHeight;
        }
    }
}
