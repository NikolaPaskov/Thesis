using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;

namespace ThreadsChartsPaskov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            listBox.Items.Insert(0, "No sleep in the whole execution");
            listBox.Items.Insert(0, "Sleep before the mutex");
            listBox.Items.Insert(0, "Bottleneck");
            listBox.Items.Insert(0, "Amdahl 25 %");
            listBox.Items.Insert(0, "Amdahl 50 %");
            listBox.Items.Insert(0, "Amdahl 75 %");
            listBox.Items.Insert(0, "Amdahl 95 %");
            listBox.Items.Insert(0, "Amdahl common");
            listBox.Items.Insert(0, "Amdahl Linux/Windows Version");
        }

        private void btnLoadnoSleep_Click(object sender, EventArgs e)
        {
            string curItem = listBox.SelectedItem.ToString();
            if (curItem.Equals("No sleep in the whole execution"))
            {
                lblAxisX.Text = "Time(s)";
                Thread.Sleep(1000);
                List<int> column0 = new List<int>();
                List<double> column1 = new List<double>();
                string[] lines = System.IO.File.ReadAllLines(@"C:\Users\nikol\OneDrive\Desktop\TestFiles\NoSleepFile.txt");
                foreach (string line in lines)
                {
                    string[] arr = line.Split(' ');
                    column0.Add(int.Parse(arr[0]));
                    column1.Add(double.Parse(arr[1]));
                }

                cartesianChart1.Series = new SeriesCollection
                {
                    new LineSeries
                        {
                            Values = new ChartValues<ObservablePoint>()
                            {
                                new ObservablePoint(column0[0],column1[0]),
                                new ObservablePoint(column0[1],column1[1]),
                                new ObservablePoint(column0[2],column1[2]),
                                new ObservablePoint(column0[3],column1[3]),
                                new ObservablePoint(column0[4],column1[4]),
                                new ObservablePoint(column0[5],column1[5]),
                                new ObservablePoint(column0[6],column1[6]),
                            },
                            PointGeometrySize = 0,
                        }
                };

                tableLayoutPanel1.Controls.Clear();
                tableLayoutPanel1.ColumnCount = 3;
                tableLayoutPanel1.RowCount = 1;
                tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label() { Text = "Number of Threads" }, 0, 0);
                tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label() { Text = "Time Consumption" }, 1, 0);

                for (int i = 0; i < column0.Count; i++)
                {
                    tableLayoutPanel1.RowCount = tableLayoutPanel1.RowCount + 1;
                    tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label() { Text = column0[i].ToString() }, 0, tableLayoutPanel1.RowCount);
                    tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label() { Text = column1[i].ToString() }, 1, tableLayoutPanel1.RowCount);
                }
            }
            else if (curItem.Equals("Bottleneck"))
            {
                lblAxisX.Text = "Time(s)";
                Thread.Sleep(1000);
                List<int> column0 = new List<int>();
                List<double> column1 = new List<double>();
                string[] lines = System.IO.File.ReadAllLines(@"C:\Users\nikol\OneDrive\Desktop\TestFiles\Bottleneck.txt");
                foreach (string line in lines)
                {
                    string[] arr = line.Split(' ');
                    column0.Add(int.Parse(arr[0]));
                    column1.Add(double.Parse(arr[1]));
                }

                cartesianChart1.Series = new SeriesCollection
                {
                    new LineSeries
                        {
                            Values = new ChartValues<ObservablePoint>()
                            {
                                new ObservablePoint(column0[0],column1[0]),
                                new ObservablePoint(column0[1],column1[1]),
                                new ObservablePoint(column0[2],column1[2]),
                                new ObservablePoint(column0[3],column1[3]),
                                new ObservablePoint(column0[4],column1[4]),
                                new ObservablePoint(column0[5],column1[5]),
                                new ObservablePoint(column0[6],column1[6]),
                                new ObservablePoint(column0[7],column1[7]),
                                new ObservablePoint(column0[8],column1[8]),
                            },
                            PointGeometrySize = 0,
                        }
                };

                tableLayoutPanel1.Controls.Clear();
                tableLayoutPanel1.ColumnCount = 3;
                tableLayoutPanel1.RowCount = 1;
                tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label() { Text = "Number of Threads" }, 0, 0);
                tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label() { Text = "Time Consumption" }, 1, 0);

                for (int i = 0; i < column0.Count; i++)
                {
                    tableLayoutPanel1.RowCount = tableLayoutPanel1.RowCount + 1;
                    tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label() { Text = column0[i].ToString() }, 0, tableLayoutPanel1.RowCount);
                    tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label() { Text = column1[i].ToString() }, 1, tableLayoutPanel1.RowCount);
                }
            }
            else if (curItem.Equals("Sleep before the mutex"))
            {
                lblAxisX.Text = "Speed Up";
                Thread.Sleep(1000);
                List<int> column0 = new List<int>();
                List<double> column1 = new List<double>();
                string[] lines = System.IO.File.ReadAllLines(@"C:\Users\nikol\OneDrive\Desktop\TestFiles\SleepBeforeTheMutex.txt");
                foreach (string line in lines)
                {
                    string[] arr = line.Split(' ');
                    column0.Add(int.Parse(arr[0]));
                    column1.Add(double.Parse(arr[1]));
                }

                cartesianChart1.Series = new SeriesCollection
                {
                    new LineSeries
                        {
                            Values = new ChartValues<ObservablePoint>()
                            {
                                new ObservablePoint(column0[0],column1[0]),
                                new ObservablePoint(column0[1],column1[1]),
                                new ObservablePoint(column0[2],column1[2]),
                                new ObservablePoint(column0[3],column1[3]),
                                new ObservablePoint(column0[4],column1[4]),
                                new ObservablePoint(column0[5],column1[5]),
                                new ObservablePoint(column0[6],column1[6]),
                                new ObservablePoint(column0[7],column1[7]),
                                new ObservablePoint(column0[8],column1[8]),
                            },
                            PointGeometrySize = 0,
                        }
                };

                tableLayoutPanel1.Controls.Clear();
                tableLayoutPanel1.ColumnCount = 3;
                tableLayoutPanel1.RowCount = 1;
                tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label() { Text = "Number of Threads" }, 0, 0);
                tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label() { Text = "Speed Up" }, 1, 0);

                for (int i = 0; i < column0.Count; i++)
                {
                    tableLayoutPanel1.RowCount = tableLayoutPanel1.RowCount + 1;
                    tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label() { Text = column0[i].ToString() }, 0, tableLayoutPanel1.RowCount);
                    tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label() { Text = column1[i].ToString() }, 1, tableLayoutPanel1.RowCount);
                }


            }
            else if (curItem.Equals("Amdahl 25 %"))
            {
                lblAxisX.Text = "Speed Up";
                Thread.Sleep(1000);
                List<int> column0 = new List<int>();
                List<double> column1 = new List<double>();
                string[] lines = System.IO.File.ReadAllLines(@"C:\Users\nikol\OneDrive\Desktop\TestFiles\Amdahl25.txt");
                foreach (string line in lines)
                {
                    string[] arr = line.Split(' ');
                    column0.Add(int.Parse(arr[0]));
                    column1.Add(double.Parse(arr[1]));
                }

                cartesianChart1.Series = new SeriesCollection
                {
                    new LineSeries
                        {
                            Values = new ChartValues<ObservablePoint>()
                            {
                                new ObservablePoint(column0[0],column1[0]),
                                new ObservablePoint(column0[1],column1[1]),
                                new ObservablePoint(column0[2],column1[2]),
                                new ObservablePoint(column0[3],column1[3]),
                                new ObservablePoint(column0[4],column1[4]),
                                new ObservablePoint(column0[5],column1[5]),
                                new ObservablePoint(column0[6],column1[6]),
                            },
                            PointGeometrySize = 0,
                        }
                };

                tableLayoutPanel1.Controls.Clear();
                tableLayoutPanel1.ColumnCount = 3;
                tableLayoutPanel1.RowCount = 1;
                tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label() { Text = "Number of Threads" }, 0, 0);
                tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label() { Text = "Speed Up" }, 1, 0);

                for (int i = 0; i < column0.Count; i++)
                {
                    tableLayoutPanel1.RowCount = tableLayoutPanel1.RowCount + 1;
                    tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label() { Text = column0[i].ToString() }, 0, tableLayoutPanel1.RowCount);
                    tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label() { Text = column1[i].ToString() }, 1, tableLayoutPanel1.RowCount);
                }

            }
            else if (curItem.Equals("Amdahl 50 %"))
            {
                lblAxisX.Text = "Speed Up";
                Thread.Sleep(1000);
                List<int> column0 = new List<int>();
                List<double> column1 = new List<double>();
                string[] lines = System.IO.File.ReadAllLines(@"C:\Users\nikol\OneDrive\Desktop\TestFiles\Amdahl50.txt");
                foreach (string line in lines)
                {
                    string[] arr = line.Split(' ');
                    column0.Add(int.Parse(arr[0]));
                    column1.Add(double.Parse(arr[1]));
                }

                cartesianChart1.Series = new SeriesCollection
                {
                    new LineSeries
                        {
                            Values = new ChartValues<ObservablePoint>()
                            {
                                new ObservablePoint(column0[0],column1[0]),
                                new ObservablePoint(column0[1],column1[1]),
                                new ObservablePoint(column0[2],column1[2]),
                                new ObservablePoint(column0[3],column1[3]),
                                new ObservablePoint(column0[4],column1[4]),
                                new ObservablePoint(column0[5],column1[5]),
                                new ObservablePoint(column0[6],column1[6]),
                            },
                            PointGeometrySize = 0,
                        }
                };

                tableLayoutPanel1.Controls.Clear();
                tableLayoutPanel1.ColumnCount = 3;
                tableLayoutPanel1.RowCount = 1;
                tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label() { Text = "Number of Threads" }, 0, 0);
                tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label() { Text = "Speed Up" }, 1, 0);

                for (int i = 0; i < column0.Count; i++)
                {
                    tableLayoutPanel1.RowCount = tableLayoutPanel1.RowCount + 1;
                    tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label() { Text = column0[i].ToString() }, 0, tableLayoutPanel1.RowCount);
                    tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label() { Text = column1[i].ToString() }, 1, tableLayoutPanel1.RowCount);
                }

            }
            else if (curItem.Equals("Amdahl 75 %"))
            {
                lblAxisX.Text = "Speed Up";
                Thread.Sleep(1000);
                List<int> column0 = new List<int>();
                List<double> column1 = new List<double>();
                string[] lines = System.IO.File.ReadAllLines(@"C:\Users\nikol\OneDrive\Desktop\TestFiles\Amdahl75.txt");
                foreach (string line in lines)
                {
                    string[] arr = line.Split(' ');
                    column0.Add(int.Parse(arr[0]));
                    column1.Add(double.Parse(arr[1]));
                }

                cartesianChart1.Series = new SeriesCollection
                {
                    new LineSeries
                        {
                            Values = new ChartValues<ObservablePoint>()
                            {
                                new ObservablePoint(column0[0],column1[0]),
                                new ObservablePoint(column0[1],column1[1]),
                                new ObservablePoint(column0[2],column1[2]),
                                new ObservablePoint(column0[3],column1[3]),
                                new ObservablePoint(column0[4],column1[4]),
                                new ObservablePoint(column0[5],column1[5]),
                                new ObservablePoint(column0[6],column1[6]),
                            },
                            PointGeometrySize = 0,
                        }
                };

                tableLayoutPanel1.Controls.Clear();
                tableLayoutPanel1.ColumnCount = 3;
                tableLayoutPanel1.RowCount = 1;
                tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label() { Text = "Number of Threads" }, 0, 0);
                tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label() { Text = "Speed Up" }, 1, 0);

                for (int i = 0; i < column0.Count; i++)
                {
                    tableLayoutPanel1.RowCount = tableLayoutPanel1.RowCount + 1;
                    tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label() { Text = column0[i].ToString() }, 0, tableLayoutPanel1.RowCount);
                    tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label() { Text = column1[i].ToString() }, 1, tableLayoutPanel1.RowCount);
                }

            }
            else if (curItem.Equals("Amdahl 95 %"))
            {
                lblAxisX.Text = "Speed Up";
                Thread.Sleep(1000);
                List<int> column0 = new List<int>();
                List<double> column1 = new List<double>();
                string[] lines = System.IO.File.ReadAllLines(@"C:\Users\nikol\OneDrive\Desktop\TestFiles\Amdahl95.txt");
                foreach (string line in lines)
                {
                    string[] arr = line.Split(' ');
                    column0.Add(int.Parse(arr[0]));
                    column1.Add(double.Parse(arr[1]));
                }

                cartesianChart1.Series = new SeriesCollection
                {
                    new LineSeries
                        {
                            Values = new ChartValues<ObservablePoint>()
                            {
                                new ObservablePoint(column0[0],column1[0]),
                                new ObservablePoint(column0[1],column1[1]),
                                new ObservablePoint(column0[2],column1[2]),
                                new ObservablePoint(column0[3],column1[3]),
                                new ObservablePoint(column0[4],column1[4]),
                                new ObservablePoint(column0[5],column1[5]),
                                new ObservablePoint(column0[6],column1[6]),
                            },
                            PointGeometrySize = 0,
                        }
                };

                tableLayoutPanel1.Controls.Clear();
                tableLayoutPanel1.ColumnCount = 3;
                tableLayoutPanel1.RowCount = 1;
                tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label() { Text = "Number of Threads" }, 0, 0);
                tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label() { Text = "Speed Up" }, 1, 0);

                for (int i = 0; i < column0.Count; i++)
                {
                    tableLayoutPanel1.RowCount = tableLayoutPanel1.RowCount + 1;
                    tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label() { Text = column0[i].ToString() }, 0, tableLayoutPanel1.RowCount);
                    tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label() { Text = column1[i].ToString() }, 1, tableLayoutPanel1.RowCount);
                }

            }
            else if (curItem.Equals("Amdahl common"))
            {
                lblAxisX.Text = "Speed Up";
                // amdahl 95
                Thread.Sleep(1000);
                List<int> column0 = new List<int>();
                List<double> column1 = new List<double>();
                string[] lines = System.IO.File.ReadAllLines(@"C:\Users\nikol\OneDrive\Desktop\TestFiles\Amdahl95.txt");
                foreach (string line in lines)
                {
                    string[] arr = line.Split(' ');
                    column0.Add(int.Parse(arr[0]));
                    column1.Add(double.Parse(arr[1]));
                }

                //amhdal 75
                Thread.Sleep(1000);
                List<int> column075 = new List<int>();
                List<double> column175 = new List<double>();
                string[] lines75 = System.IO.File.ReadAllLines(@"C:\Users\nikol\OneDrive\Desktop\TestFiles\Amdahl75.txt");
                foreach (string line in lines75)
                {
                    string[] arr = line.Split(' ');
                    column075.Add(int.Parse(arr[0]));
                    column175.Add(double.Parse(arr[1]));
                }

                ////amhdal 50
                Thread.Sleep(1000);
                List<int> column050 = new List<int>();
                List<double> column150 = new List<double>();
                string[] lines50 = System.IO.File.ReadAllLines(@"C:\Users\nikol\OneDrive\Desktop\TestFiles\Amdahl50.txt");
                foreach (string line in lines50)
                {
                    string[] arr = line.Split(' ');
                    column050.Add(int.Parse(arr[0]));
                    column150.Add(double.Parse(arr[1]));
                }

                //amhdal 25
                Thread.Sleep(1000);
                List<int> column025 = new List<int>();
                List<double> column125 = new List<double>();
                string[] lines25 = System.IO.File.ReadAllLines(@"C:\Users\nikol\OneDrive\Desktop\TestFiles\Amdahl25.txt");
                foreach (string line in lines25)
                {
                    string[] arr = line.Split(' ');
                    column025.Add(int.Parse(arr[0]));
                    column125.Add(double.Parse(arr[1]));
                }

                cartesianChart1.Series = new SeriesCollection
                {

                };

                cartesianChart1.Series.Add(new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>()
                    {
                        new ObservablePoint(column0[0],column1[0]),
                        new ObservablePoint(column0[1],column1[1]),
                        new ObservablePoint(column0[2],column1[2]),
                        new ObservablePoint(column0[3],column1[3]),
                        new ObservablePoint(column0[4],column1[4]),
                        new ObservablePoint(column0[5],column1[5]),
                        new ObservablePoint(column0[6],column1[6]),
                    },
                });

                cartesianChart1.Series.Add(new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>()
                    {
                        new ObservablePoint(column075[0],column175[0]),
                        new ObservablePoint(column075[1],column175[1]),
                        new ObservablePoint(column075[2],column175[2]),
                        new ObservablePoint(column075[3],column175[3]),
                        new ObservablePoint(column075[4],column175[4]),
                        new ObservablePoint(column075[5],column175[5]),
                        new ObservablePoint(column075[6],column175[6]),
                    },
                });

                cartesianChart1.Series.Add(new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>()
                    {
                        new ObservablePoint(column050[0],column150[0]),
                        new ObservablePoint(column050[1],column150[1]),
                        new ObservablePoint(column050[2],column150[2]),
                        new ObservablePoint(column050[3],column150[3]),
                        new ObservablePoint(column050[4],column150[4]),
                        new ObservablePoint(column050[5],column150[5]),
                        new ObservablePoint(column050[6],column150[6]),
                    },
                });

                cartesianChart1.Series.Add(new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>()
                    {
                        new ObservablePoint(column025[0],column125[0]),
                        new ObservablePoint(column025[1],column125[1]),
                        new ObservablePoint(column025[2],column125[2]),
                        new ObservablePoint(column025[3],column125[3]),
                        new ObservablePoint(column025[4],column125[4]),
                        new ObservablePoint(column025[5],column125[5]),
                        new ObservablePoint(column025[6],column125[6]),
                    },
                });

                tableLayoutPanel1.Controls.Clear();
                tableLayoutPanel1.ColumnCount = 5;
                tableLayoutPanel1.RowCount = 1;
                tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label() { Text = "Number of Threads" }, 0, 0);
                tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label() { Text = "Amdahl 95%" }, 1, 0);
                tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label() { Text = "Amdahl 75%" }, 2, 0);
                tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label() { Text = "Amdahl 50%" }, 3, 0);
                tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label() { Text = "Amdahl 25%" }, 4, 0);

                for (int i = 0; i < column0.Count; i++)
                {
                    tableLayoutPanel1.RowCount = tableLayoutPanel1.RowCount + 1;
                    tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label() { Text = column0[i].ToString() }, 0, tableLayoutPanel1.RowCount);
                    tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label() { Text = column1[i].ToString() }, 1, tableLayoutPanel1.RowCount);
                    tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label() { Text = column175[i].ToString() }, 2, tableLayoutPanel1.RowCount);
                    tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label() { Text = column150[i].ToString() }, 3, tableLayoutPanel1.RowCount);
                    tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label() { Text = column125[i].ToString() }, 4, tableLayoutPanel1.RowCount);
                }
            }
            else if (curItem.Equals("Amdahl Linux/Windows Version"))
            {
                lblAxisX.Text = "Speed Up";
                // amdahl 95
                Thread.Sleep(1000);
                List<int> column0 = new List<int>();
                List<double> column1 = new List<double>();
                string[] lines = System.IO.File.ReadAllLines(@"C:\Users\nikol\OneDrive\Desktop\TestFiles\Amdahl95LinuxVersion.txt");
                foreach (string line in lines)
                {
                    string[] arr = line.Split(' ');
                    column0.Add(int.Parse(arr[0]));
                    column1.Add(double.Parse(arr[1]));
                }

                //amhdal 75
                Thread.Sleep(1000);
                List<int> column075 = new List<int>();
                List<double> column175 = new List<double>();
                string[] lines75 = System.IO.File.ReadAllLines(@"C:\Users\nikol\OneDrive\Desktop\TestFiles\Amdahl95.txt");
                foreach (string line in lines75)
                {
                    string[] arr = line.Split(' ');
                    column075.Add(int.Parse(arr[0]));
                    column175.Add(double.Parse(arr[1]));
                }

                //amhdal 75
                Thread.Sleep(1000);
                List<int> column050 = new List<int>();
                List<double> column150 = new List<double>();
                string[] lines50 = System.IO.File.ReadAllLines(@"C:\Users\nikol\OneDrive\Desktop\TestFiles\Amdahl50.txt");
                foreach (string line in lines50)
                {
                    string[] arr = line.Split(' ');
                    column050.Add(int.Parse(arr[0]));
                    column150.Add(double.Parse(arr[1]));
                }

                cartesianChart1.Series = new SeriesCollection
                {

                };

                cartesianChart1.Series.Add(new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>()
                    {
                        new ObservablePoint(column0[0],column1[0]),
                        new ObservablePoint(column0[1],column1[1]),
                        new ObservablePoint(column0[2],column1[2]),
                        new ObservablePoint(column0[3],column1[3]),
                        new ObservablePoint(column0[4],column1[4]),
                        new ObservablePoint(column0[5],column1[5]),
                        new ObservablePoint(column0[6],column1[6]),
                    },
                });

                cartesianChart1.Series.Add(new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>()
                    {
                        new ObservablePoint(column075[0],column175[0]),
                        new ObservablePoint(column075[1],column175[1]),
                        new ObservablePoint(column075[2],column175[2]),
                        new ObservablePoint(column075[3],column175[3]),
                        new ObservablePoint(column075[4],column175[4]),
                        new ObservablePoint(column075[5],column175[5]),
                        new ObservablePoint(column075[6],column175[6]),
                    },
                });

                cartesianChart1.Series.Add(new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>()
                    {
                        new ObservablePoint(column050[0],column150[0]),
                        new ObservablePoint(column050[1],column150[1]),
                        new ObservablePoint(column050[2],column150[2]),
                        new ObservablePoint(column050[3],column150[3]),
                        new ObservablePoint(column050[4],column150[4]),
                        new ObservablePoint(column050[5],column150[5]),
                        new ObservablePoint(column050[6],column150[6]),
                    },
                });

                tableLayoutPanel1.Controls.Clear();
                tableLayoutPanel1.ColumnCount = 5;
                tableLayoutPanel1.RowCount = 1;
                tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label() { Text = "Number of Threads" }, 0, 0);
                tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label() { Text = "Amdahl 95% Windows" }, 1, 0);
                tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label() { Text = "Amdahl 95% Linux" }, 2, 0);
                tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label() { Text = "Amdahl 50%" }, 3, 0);

                for (int i = 0; i < column0.Count; i++)
                {
                    tableLayoutPanel1.RowCount = tableLayoutPanel1.RowCount + 1;
                    tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label() { Text = column0[i].ToString() }, 0, tableLayoutPanel1.RowCount);
                    tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label() { Text = column1[i].ToString() }, 1, tableLayoutPanel1.RowCount);
                    tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label() { Text = column175[i].ToString() }, 2, tableLayoutPanel1.RowCount);
                    tableLayoutPanel1.Controls.Add(new System.Windows.Forms.Label() { Text = column150[i].ToString() }, 3, tableLayoutPanel1.RowCount);
                }
            }
            else
            {

            }
        }
    }
}
