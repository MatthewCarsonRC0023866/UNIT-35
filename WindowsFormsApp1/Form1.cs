using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        class row
        {
            public double time; 
            public double altimeter;
            public double velocity;
            public double aceleration;
        }
//here i have defined the varaible i will be using
		List<row> table = new List<row>();
        public Form1()
        {
            InitializeComponent();
            chart1.Series.Clear();
        }
//here i have formatted the table so it can process correctly

        private void calculateVelocity()
        {
            for (int i=1; i < table.Count; i++)
            {
                double dt = table[i].time - table[i - 1].time;
                double dalt = table[i].altimeter - table[i - 1].altimeter;
                table[i].velocity = dalt / dt;

            }
        }
//here i have calulated the velocity for use later on in the graph
        private void calculateAceleration()
        {
            for (int i = 2; i < table.Count; i++)
            {
                double dv = table[i].velocity - table[i - 1].velocity;
                double dt = table[i].time - table[i - 1].time;
                table[i].aceleration = dv / dt;

            }
        }
//here i have calulated the aceleration for use later on in the graph
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "csv Files|*.csv";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                    {
                        string line = sr.ReadLine();
                        while (!sr.EndOfStream)
                        {
                            table.Add(new row());
                            string[] r = sr.ReadLine().Split(',');
                            table.Last().time = double.Parse(r[0]);
                            table.Last().altimeter = double.Parse(r[1]);
                        }
                    }
                    calculateVelocity();
					calculateAceleration();

                }
                catch (IOException)
                {
                    MessageBox.Show(openFileDialog1.FileName + " failed to open");
                }
                catch (FormatException)
                {
                    MessageBox.Show(openFileDialog1.FileName + " is not in required format.");
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show(openFileDialog1.FileName + " is not in required format.");
                }
                catch (DivideByZeroException)
                {
                    MessageBox.Show(openFileDialog1.FileName + " has rows that have the same time");
                }
            }
        }
//i have coded the menu strip for the "open" opinion also i have defined what file type that will be use for the raw data being processed. Also this is where the aceleration and velocity is calulated using the data from the csv file.
//this section also have error messages coded into it if there are any problems with the file that is used then this will be ran.

        private void velocityToolStripMenuItem_Click(object sender, EventArgs e)
        {

			chart1.Series.Clear();
            chart1.ChartAreas[0].AxisX.IsMarginVisible = false;
            Series series = new Series
            {
                Name = "Velocity",
                Color = Color.Blue,
                IsVisibleInLegend = false,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Spline,
                BorderWidth = 2
            };
			chart1.Series.Add(series);
			foreach (row r in table.Skip(1))
            {
                series.Points.AddXY(r.time, r.velocity);
            }
            chart1.ChartAreas[0].AxisX.Title = "time /s";
            chart1.ChartAreas[0].AxisY.Title = "Velocity /m/s";
            chart1.ChartAreas[0].RecalculateAxesScale();
        }
//i have coded the menu strip for "velocity" this is where the graph creates the velocity graph using velocity and time for the graph. Plotting the graph after it has been clicked.

		private void saveCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "csv Files|*.csv";
            DialogResult results = saveFileDialog1.ShowDialog();
            if (results == DialogResult.OK)
            {
				try
				{
					using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
					{
						sw.WriteLine("Time /s, Altitude /m, Velocity /m/s, Aceleration / m/s");
						foreach (row r in table)
						{
							sw.WriteLine(r.time + "," + r.altimeter + "," + r.velocity + "," + r.aceleration);
						}
					}
				}
				catch
				{
					MessageBox.Show(saveFileDialog1.FileName + " failed to save.");
				}
            }
        }
//here i have coded the menu strip "save CSV" opinion this is where the generated graph is saved as a CSV file where all the process data is saved.
		private void savePNGToolStripMenuItem_Click(object sender, EventArgs e)
		{
			saveFileDialog1.FileName = "";
			saveFileDialog1.Filter = "png Files|*.png";
			DialogResult results = saveFileDialog1.ShowDialog();
			if (results == DialogResult.OK)
			{
				try
				{
					chart1.SaveImage(saveFileDialog1.FileName, ChartImageFormat.Png);
				}
				catch
				{
					MessageBox.Show(saveFileDialog1.FileName + " failed to save");
				}
			}
		}
//here i have coded the menu strip "save PNG" opinion this is where the generated graph is saved as a PNG file where all the process data is saved.
		private void rateOfChangeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			{
				chart1.Series.Clear();
				chart1.ChartAreas[0].AxisX.IsMarginVisible = false;
				Series series = new Series
				{
					Name = "Altitude",
					Color = Color.Blue,
					IsVisibleInLegend = false,
					IsXValueIndexed = true,
					ChartType = SeriesChartType.Spline,
					BorderWidth = 2
				};
				chart1.Series.Add(series);
				foreach (row r in table.Skip(1))
				{
					series.Points.AddXY(r.time, r.altimeter);
				}
				chart1.ChartAreas[0].AxisX.Title = "time /s";
				chart1.ChartAreas[0].AxisY.Title = "altitude /m";
				chart1.ChartAreas[0].RecalculateAxesScale();
			}
		}
//i have coded the menu strip for "altitude" this is where the graph creates the velocity graph using altitude and time for the graph. Plotting the graph after it has been clicked. In the code it is named rate of change because i couldnt change it to "altitude"
		private void altitudeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			{
				chart1.Series.Clear();
				chart1.ChartAreas[0].AxisX.IsMarginVisible = false;
				Series series = new Series
				{
					Name = "Aceleration",
					Color = Color.Blue,
					IsVisibleInLegend = false,
					IsXValueIndexed = true,
					ChartType = SeriesChartType.Spline,
					BorderWidth = 2
				};
				chart1.Series.Add(series);
				foreach (row r in table.Skip(1))
				{
					series.Points.AddXY(r.time, r.aceleration);
				}
				chart1.ChartAreas[0].AxisX.Title = "time /s";
				chart1.ChartAreas[0].AxisY.Title = "aceleration /m/s";
				chart1.ChartAreas[0].RecalculateAxesScale();
			}
//i have coded the menu strip for "aceleration" this is where the graph creates the velocity graph using aceleration and time for the graph. Plotting the graph after it has been clicked. In the code it reads "altitude because i wasnt able to change it to "aceleration" at a later point"
		}
	}
}
