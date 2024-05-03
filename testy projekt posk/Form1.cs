using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testy_projekt_posk
{
    public partial class Form1 : Form
    {
        bool wizualnyGoesOn = false;
        bool akustycznyGoesOn = false;
        int measuredNumber = 0;
        Random rnd = new Random();
        List<int> wizualnyTestResults = new List<int>();
        List<int> akustycznyTestResults = new List<int>();
        Stopwatch measuredTime = new Stopwatch();

        public Form1()
        {
            InitializeComponent(); 
            wizualnyPanel.Hide();
            akustyczny.Hide();
            resultsTextBox.Enabled = false;
            chart1.Enabled = false;
        }

        private void akustyczneButton_Click(object sender, EventArgs e)
        {
            menuPanel.Hide();
            akustyczny.Show();
            measuredNumber = 0;

        }

        private void menuPanel_Click(object sender, EventArgs e)
        {

        }

        private void menuPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void wizualnyPrzycisk_Click(object sender, EventArgs e)
        {
            menuPanel.Hide();
            wizualnyPanel.Show();
            measuredNumber = 0;
            testButton.Enabled = false;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            wizualnyPanel.Hide();
            menuPanel.Show();
            wizualnyGoesOn = false;
            checkBox1.Enabled = true;
            startstopButton.Text = "Start";
            measuredNumber = 0;
            measuredTime.Stop();
            wizualnyTestResults = new List<int>();
            resultsTextBox.Text = "";
            testTimer.Enabled = false;
            averageLabel.Text = "Średnia:";
            resultChart.Series[0].Points.Clear();
        }

        private void startstopButton_Click(object sender, EventArgs e)
        {
            wizualnyGoesOn = !wizualnyGoesOn;

            if (wizualnyGoesOn)
            {
                startstopButton.Text = "Stop";
                checkBox1.Enabled = false;
                testButton.Enabled = true;
                testTimer.Interval = (rnd.Next(4000) + 4000);
                testTimer.Enabled = true;

            }
            else
            {
                startstopButton.Text = "Start";
                checkBox1.Enabled = true;
                testButton.Enabled = false;
                testTimer.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!measuredTime.IsRunning)
            {
                measuredTime.Reset();
                if (akustycznyGoesOn) Console.Beep();
                else if (wizualnyGoesOn) testButton.BackColor = Color.Green;
                measuredTime.Start();

            }
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            if(measuredTime.IsRunning)
            {
                measuredTime.Stop();
                testButton.BackColor = Color.Red;
                if (!checkBox1.Checked)
                {
                    int reactionTime = (int)measuredTime.ElapsedMilliseconds;
                    testTimer.Interval = (rnd.Next(4000) + 4000);
                    measuredNumber++;
                    resultsTextBox.Text += (reactionTime.ToString() + " ms \r\n");
                    resultChart.Series[0].Points.AddXY(measuredNumber, reactionTime);
                    wizualnyTestResults.Add(reactionTime);
                    averageLabel.Text = "Średnia: " + Math.Round(wizualnyTestResults.Average(), 2).ToString() + " ms";

                }
            }
            else
            {
                MessageBox.Show("Kliknąłeś zbyt szybko!");
                wizualnyGoesOn = false;
                checkBox1.Enabled = true;
                startstopButton.Text = "Start";
                measuredNumber = 0;
                measuredTime.Stop();
                wizualnyTestResults = new List<int>();
                resultsTextBox.Text = "";
                testTimer.Enabled = false;
                testButton.Enabled = false;
            }
        }

        private void resultChart_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Start_akust_Click(object sender, EventArgs e)
        {
            akustycznyGoesOn = !akustycznyGoesOn;
            if (akustycznyGoesOn)
            {
                Start_akust.Text = "Stop";
                checkBox2.Enabled = false;
                testButton.Enabled = true;
                testTimer.Interval = (rnd.Next(4000) + 4000);
                testTimer.Enabled = true;

            }
            else
            {
                Start_akust.Text = "Start";
                checkBox2.Enabled = true;
                testButton.Enabled = false;
                testTimer.Enabled = false;
            }

        }

        private void stop_acustic_Click(object sender, EventArgs e)
        {
            akustyczny.Hide();
            menuPanel.Show();
            akustycznyGoesOn = false;
            checkBox2.Enabled = true;
            startstopButton.Text = "Start";
            measuredNumber = 0;
            measuredTime.Stop();
            akustycznyTestResults = new List<int>();
            textBox1.Text = "";
            testTimer.Enabled = false;
            label3.Text = "Średnia:";
            chart1.Series[0].Points.Clear();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (measuredTime.IsRunning)
            {
                measuredTime.Stop();
                if (!checkBox2.Checked)
                {
                    int reactionTime = (int)measuredTime.ElapsedMilliseconds;
                    testTimer.Interval = (rnd.Next(4000) + 4000);
                    measuredNumber++;
                    textBox1.Text += (reactionTime.ToString() + " ms \r\n");
                    chart1.Series[0].Points.AddXY(measuredNumber, reactionTime);
                    akustycznyTestResults.Add(reactionTime);
                    label3.Text = "Średnia: " + Math.Round(akustycznyTestResults.Average(), 2).ToString() + " ms";

                }
            }
            else
            {
                MessageBox.Show("Kliknąłeś zbyt szybko!");
                akustycznyGoesOn = false;
                checkBox2.Enabled = true;
                startstopButton.Text = "Start";
                measuredNumber = 0;
                measuredTime.Stop();
                akustycznyTestResults = new List<int>();
                chart1.Text = "";
                testTimer.Enabled = false;
                testButton.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
