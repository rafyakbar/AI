using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AI.NeuralNetwork.Methods;
using System.IO;

namespace LearningAndTesting
{
    public partial class GUI : Form
    {
        private List<List<TextBox>> dataTextBoxList = new List<List<TextBox>>();

        public GUI()
        {
            InitializeComponent();

            dataPanel.VerticalScroll.Visible = true;
            dataPanel.HorizontalScroll.Visible = true;
            dataPanel.AutoScroll = true;
            dataPanel.ResumeLayout();

            targetPanel.VerticalScroll.Visible = true;
            targetPanel.HorizontalScroll.Visible = true;
            targetPanel.AutoScroll = true;
            targetPanel.ResumeLayout();

            aktivasiComboBox.SelectedIndex = 1;

            //inisialisasi awal data view
            dataPanel.Controls.Add(new Label()
            {
                Text = "",
                Size = new Size(30, 30),
                Padding = new Padding(5)
            });
            dataPanel.ColumnCount++;
            tambahHeadData();
            dataPanel.ColumnCount++;
            tambahHeadData();

            dataPanel.RowCount++;
            dataPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            dataPanel.Controls.Add(new Label() {
                Text = "1",
                Size = new Size(30, 30),
                Padding = new Padding(5)
            });
            dataTextBoxList.Add(new List<TextBox>());
            tambahTextBox(0);
            dataPanel.Controls.Add(dataTextBoxList[0][0]);
            tambahTextBox(0);
            dataPanel.Controls.Add(dataTextBoxList[0][1]);

            //inisialisasi awal target view
            targetPanel.ColumnCount++;
            targetPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            targetPanel.Controls.Add(new Label(){
                Text = "",
                Size = new Size(30, 30),
                Padding = new Padding(5)
            });
            targetPanel.RowCount++;
            targetPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tambahTargetNomor();
            tambahTargetTextBox();

            //tambah baris dan kolom
            for(int c = 0; c < 50 - 1; c++)
            {
                tambahBaris();
            }
            for (int c = 0; c < 10 - 2; c++)
            {
                tambahKolom();
            }

            //set
            alphaTextBox.Text = "0,7";
            thetaTextBox.Text = "0,3";
            weightTextBox.Text = "0";
            biasTextBox.Text = "0";
            epochTextBox.Text = "10";
        }

        private void tambahTargetNomor()
        {
            targetPanel.Controls.Add(new Label()
            {
                Text = "" + (dataPanel.RowCount - 1),
                Size = new Size(20, 30),
                TextAlign = ContentAlignment.MiddleCenter,
            }, 0, targetPanel.RowCount - 1);
        }

        private void tambahTargetTextBox()
        {
            targetPanel.Controls.Add(new TextBox()
            {
                Multiline = true,
                Size = new Size(75, 21),
                Margin = new Padding(3, 3, 3, 6)
            }, 1, targetPanel.RowCount - 1);
        }

        private void tambahHeadData()
        {
            dataPanel.Controls.Add(new Label()
            {
                Text = "x" + (dataPanel.ColumnCount - 1),
                Size = new Size(75, 30),
                Padding = new Padding(5),
                TextAlign = ContentAlignment.MiddleCenter
            }, dataPanel.ColumnCount - 1, 0);
        }

        private void tambahNomorBaris()
        {
            dataPanel.Controls.Add(new Label()
            {
                Text = "" + (dataPanel.RowCount - 1),
                Size = new Size(30, 30),
                TextAlign = ContentAlignment.MiddleCenter,
            }, 0, dataPanel.RowCount - 1);
        }

        private void tambahTextBox(int baris)
        {
            dataTextBoxList[baris].Add(new TextBox()
            {
                Multiline = true,
                Size = new Size(75, 21),
                Margin = new Padding(3)
            });
        }

        private void tambahKolom()
        {
            dataPanel.ColumnCount++;
            dataPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            tambahHeadData();

            for (int c = 0; c < dataPanel.RowCount - 1; c++)
            {
                tambahTextBox(c);
                dataPanel.Controls.Add(dataTextBoxList[c][dataTextBoxList[c].Count - 1], dataPanel.ColumnCount - 1, c + 1);
            }
        }

        private void tambahBaris()
        {
            dataPanel.RowCount++;
            dataPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            tambahNomorBaris();

            dataTextBoxList.Add(new List<TextBox>());
            for (int c = 0; c < dataTextBoxList[0].Count; c++)
            {
                tambahTextBox(dataTextBoxList.Count - 1);
                dataPanel.Controls.Add(dataTextBoxList[dataTextBoxList.Count - 1][dataTextBoxList[dataTextBoxList.Count - 1].Count - 1]);
            }

            targetPanel.RowCount++;
            targetPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tambahTargetNomor();
            tambahTargetTextBox();
        }

        private void tambahKolomButton_Click(object sender, EventArgs e)
        {
            tambahKolom();
        }

        private void tambahBarisButton_Click(object sender, EventArgs e)
        {
            tambahBaris();
        }

        private void learnButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<double> target = new List<double>();
                for (int c = 1; c < targetPanel.RowCount; c++)
                {
                    if (targetPanel.GetControlFromPosition(1, c).Text == null || targetPanel.GetControlFromPosition(1, c).Text == "")
                    {
                        break;
                    }
                    else
                    {
                        target.Add(Convert.ToDouble(targetPanel.GetControlFromPosition(1, c).Text));
                    }
                }
                List<List<double>> data = new List<List<double>>();
                for (int c = 0; c < dataTextBoxList.Count; c++)
                {
                    if (dataTextBoxList[c][0].Text == null || dataTextBoxList[c][0].Text == "")
                        break;
                    else
                    {
                        data.Add(new List<double>());
                        for (int i = 0; i < dataTextBoxList[0].Count; i++)
                        {
                            if (dataTextBoxList[c][i].Text == null || dataTextBoxList[c][i].Text == "")
                                break;
                            else
                            {
                                data[c].Add(Convert.ToDouble(dataTextBoxList[c][i].Text));
                            }
                        }
                    }
                }

                int epoch = Convert.ToInt32(epochTextBox.Text);
                double alpha = Convert.ToDouble(alphaTextBox.Text);
                double theta = Convert.ToDouble(thetaTextBox.Text);
                double bias = Convert.ToDouble(biasTextBox.Text);
                double weight = Convert.ToDouble(weightTextBox.Text);
                if ((string)aktivasiComboBox.SelectedItem == "Biner Sigmoid")
                {
                    (new Perceptron(this, target, data, epoch, alpha, theta, bias, weight)).learnWith("biner sigmoid", viewCheckBox.Checked);
                }
                else if ((string)aktivasiComboBox.SelectedItem == "Linear Piecewise")
                {
                    (new Perceptron(this, target, data, epoch, alpha, theta, bias, weight)).learnWith("linear piecewise", viewCheckBox.Checked);
                }
                else if ((string)aktivasiComboBox.SelectedItem == "Bipolar Sigmoid")
                {
                    (new Perceptron(this, target, data, epoch, alpha, theta, bias, weight)).learnWith("bipolar sigmoid", viewCheckBox.Checked);
                }
                else if ((string)aktivasiComboBox.SelectedItem == "Linear")
                {
                    (new Perceptron(this, target, data, epoch, alpha, theta, bias, weight)).learnWith("linear", viewCheckBox.Checked);
                }
                else if ((string)aktivasiComboBox.SelectedItem == "Biner Treshold")
                {
                    (new Perceptron(this, target, data, epoch, alpha, theta, bias, weight)).learnWith("biner treshold", viewCheckBox.Checked);
                }
                else if ((string)aktivasiComboBox.SelectedItem == "Bipolar Treshold")
                {
                    (new Perceptron(this, target, data, epoch, alpha, theta, bias, weight)).learnWith("bipolar treshold", viewCheckBox.Checked);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private string[] browse(bool learning)
        {
            OpenFileDialog chooseFile = new OpenFileDialog();

            chooseFile.InitialDirectory = "D:\\";
            chooseFile.Filter = "txt files (*.txt)|*.txt";
            chooseFile.FilterIndex = 1;
            chooseFile.RestoreDirectory = true;
            chooseFile.Multiselect = false;

            if (chooseFile.ShowDialog() == DialogResult.OK)
            {
                if (learning)
                    infoPathTextBox.Text = chooseFile.FileName;
                else
                    infoPathWeightTextBox.Text = chooseFile.FileName;
                try
                {
                    return File.ReadAllLines(chooseFile.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            return new string[0];

        }

        private void browseDataButton_Click(object sender, EventArgs e)
        {
            try
            {
                int b = 0;
                int b_awal = dataTextBoxList.Count(), k_awal = dataTextBoxList[b].Count();
                foreach (string baris in browse(true))
                {
                    int k = 0;
                    foreach (string kolom in baris.Split(' '))
                    {
                        if (k == k_awal)
                        {
                            tambahKolom();
                            k_awal++;
                        }
                        dataTextBoxList[b][k].Text = kolom;
                        k++;
                    }
                    if (b == b_awal)
                    {
                        tambahBaris();
                        b_awal++;
                    }
                    b++;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void browseTargetButton_Click(object sender, EventArgs e)
        {
            try
            {
                int b = 0;
                foreach (string baris in browse(true))
                {
                    targetPanel.GetControlFromPosition(1, ++b).Text = baris;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<double> data = new List<double>();
                List<double> weight = new List<double>();
                double alpha = Convert.ToDouble(alphaTestingTextBox.Text);
                double bias = Convert.ToDouble(biasTestingTextBox.Text);
                double theta = Convert.ToDouble(thetaTestingTextBox.Text);

                foreach (string baris in dataTestingTextBox.Text.Split(' '))
                {
                    if (baris == null || baris == "")
                        break;
                    else
                        data.Add(Convert.ToDouble(baris));
                }
                foreach (string baris in weightTestingTextBox.Text.Split('\n'))
                {
                    if (baris == null || baris == "")
                        break;
                    else
                        weight.Add(Convert.ToDouble(baris));
                }
                (new Perceptron(weight, alpha, theta, bias)).test(data, aktivasiComboBox.Text.ToLower());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void browseWeightButton_Click(object sender, EventArgs e)
        {
            weightTestingTextBox.Text = "";
            try
            {
                foreach (string baris in browse(false))
                {
                    weightTestingTextBox.AppendText(baris + "\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void browseAlphaBiasThetaButton_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (string baris in browse(false))
                {
                    alphaTestingTextBox.Text = baris.Split(' ')[0];
                    biasTestingTextBox.Text = baris.Split(' ')[1];
                    thetaTestingTextBox.Text = baris.Split(' ')[2];
                    aktivasiTestingComboBox.Text = baris.Split(' ')[3].Replace('_', ' ');
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
