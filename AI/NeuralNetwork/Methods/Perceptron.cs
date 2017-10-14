using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace AI.NeuralNetwork.Methods
{
    public class Perceptron : Component
    {
        private ProgressLearningForm progress;


        public Perceptron(Control parent, List<double> target, List<List<double>> data, int epoch, double alpha, double theta, double bias, double weight)
        {
            this.Target = target;
            this.Data = data;
            this.Epoch = epoch;
            this.Alpha = alpha;
            this.Theta = theta;
            this.Bias = bias;
            this.Initial_weight = weight;
            this.Weight = new List<double>();
            generateWeight();

            parent.Enabled = false;
            progress = new ProgressLearningForm(parent);
            progress.Show(parent);

            progress.progressBar.Maximum = this.Epoch * this.Data.Count;
            progress.progressBar.Step = 1;
            progress.progressBar.Value = 0;
        }

        public Perceptron(List<double> weight, double alpha, double theta, double bias)
        {
            this.Alpha = alpha;
            this.Theta = theta;
            this.Bias = bias;
            this.Weight = weight;
        }

        private void generateWeight()
        {
            for (int c = 0; c < this.Data[0].Count; c++)
            {
                this.Weight.Add(this.Initial_weight);
            }
        }

        private double count_y(int c, bool view)
        {
            double y = this.Bias;

            if(view)
                progress.progressView.AppendText("y = " + y + " ");

            for (int i = 0; i < this.Data[c].Count; i++)
            {
                if (view)
                    progress.progressView.AppendText("+" + (this.Data[c][i] * this.Weight[i]) + " ");
                y += (this.Data[c][i] * this.Weight[i]);
            }

            if(view)
                progress.progressView.AppendText(" = " + y + "\n");

            return y;
        }

        private void newWeight(int c, bool view)
        {
            for (int i = 0; i < this.Data[0].Count; i++)
            {
                this.Weight[i] += (this.Alpha * this.Target[c] * this.Data[c][i]);
                if (view)
                    progress.progressView.AppendText("Weight-" + (i + 1) + " baru = " + this.Weight[i] + "\n");
            }
        }

        private void newBias(int c, bool view)
        {
            this.Bias += (this.Alpha * this.Target[c]);
            if (view)
                progress.progressView.AppendText("Bias baru = " + this.Bias + "\n");
        }

        private void writeLastWeightAndBias(string activation)
        {
            File.WriteAllText("alpha_bias_theta.txt", this.Alpha + " " + this.Bias + " " + this.Theta + " " + activation.Replace(' ', '_'));
            File.WriteAllLines("weight.txt", this.Weight.Select(w => w.ToString()).ToArray());
        }

        public void learnWith(string activation, bool view)
        {
            try
            {
                Stopwatch timer = new Stopwatch();
                timer.Start();
                activation = activation.ToLower();
                progress.addFormTitle("(Perceptron dengan aktivasi " + activation + ")");
                progress.progressView.AppendText("alpha = " + this.Alpha + ", theta = " + this.Theta + ", weight awal = " + this.Initial_weight + ", bias = " + this.Bias + ", epoch = " + this.Epoch + "\n");

                //proses learning
                for (int iteration = 0; iteration < this.Epoch; iteration++)
                {
                    if (view)
                    {
                        progress.progressView.AppendText("==========================================================================\n");
                        progress.progressView.AppendText("iterasi/epoch " + (iteration + 1) + "\n");
                    }
                    for (int c = 0; c < this.Data.Count; c++)
                    {
                        if (view)
                        {
                            progress.progressView.AppendText("----------------------------------------------------------------------------------------------------------------------------------------\n");
                            progress.progressView.AppendText("data " + (c + 1) + "\n");
                        }

                        double y_activation = 0;
                        if (activation == "linear")
                            y_activation = Convert.ToDouble(ActivationFunction.linear(this.Alpha, count_y(c, view)));
                        else if (activation == "linear piecewise")
                            y_activation = Convert.ToDouble(ActivationFunction.linearPiecewise(this.Theta, count_y(c, view)));
                        else if (activation == "biner sigmoid")
                            y_activation = Convert.ToDouble(ActivationFunction.binerSigmoid(this.Alpha, count_y(c, view)));
                        else if (activation == "bipolar sigmoid")
                            y_activation = Convert.ToDouble(ActivationFunction.bipolarSigmoid(this.Alpha, count_y(c, view)));
                        else if (activation == "biner treshold")
                            y_activation = Convert.ToDouble(ActivationFunction.binerTreshold(count_y(c, view)));
                        else if (activation == "bipolar treshold")
                            y_activation = Convert.ToDouble(ActivationFunction.bipolarTreshold(count_y(c, view)));
                        else
                        {
                            MessageBox.Show("Fungsi aktivasi salah!");
                            break;
                        }

                        if (y_activation != this.Target[c])
                        {
                            if (view)
                            {
                                progress.progressView.AppendText("y != t\n");
                                progress.progressView.AppendText(y_activation + " != " + this.Target[c] + "\n");
                            }
                            newWeight(c, view);
                            newBias(c, view);
                        }
                        else
                        {
                            if (view)
                            {
                                progress.progressView.AppendText("y == t\n");
                                progress.progressView.AppendText(y_activation + " == " + this.Target[c] + "\n");
                            }
                        }
                        progress.progressBar.Value += 1;
                    }
                    if (view)
                        progress.progressView.AppendText("\n");
                }

                //menampilkan weight akhir
                int counter = 1;
                foreach (double w in this.Weight)
                {
                    progress.progressView.AppendText("W" + (counter++) + " = " + w + ", ");
                }
                //menampilkan bias
                progress.progressView.AppendText("Bias = " + this.Bias);
                //buat file .txt untuk bias dan weight
                writeLastWeightAndBias(activation);
                timer.Stop();
                MessageBox.Show("Selesai dalam " + timer.Elapsed.TotalSeconds.ToString() + " detik.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalan! {(" + ex.ToString() + "}");
            }
        }

        public double test(List<double> input, string activation)
        {
            this.Data = new List<List<double>>();
            this.Data.Add(input);
            try
            {
                double y_activation = 0;
                if (activation == "linear")
                    y_activation = Convert.ToDouble(ActivationFunction.linear(this.Alpha, count_y(0, false)));
                else if (activation == "linear piecewise")
                    y_activation = Convert.ToDouble(ActivationFunction.linearPiecewise(this.Theta, count_y(0, false)));
                else if (activation == "biner sigmoid")
                    y_activation = Convert.ToDouble(ActivationFunction.binerSigmoid(this.Alpha, count_y(0, false)));
                else if (activation == "bipolar sigmoid")
                    y_activation = Convert.ToDouble(ActivationFunction.bipolarSigmoid(this.Alpha, count_y(0, false)));
                else if (activation == "biner treshold")
                    y_activation = Convert.ToDouble(ActivationFunction.binerTreshold(count_y(0, false)));
                else if (activation == "bipolar treshold")
                    y_activation = Convert.ToDouble(ActivationFunction.bipolarTreshold(count_y(0, false)));
                else
                    MessageBox.Show("Fungsi aktivasi salah!");
                MessageBox.Show("net = " + count_y(0, false) + " | Hasil testing : " + y_activation);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return 1234567890;
        }
    }
}
