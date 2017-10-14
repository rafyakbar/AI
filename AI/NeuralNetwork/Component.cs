using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI.NeuralNetwork
{
    public class Component : ActivationFunction
    {
        private double alpha, theta, bias, initial_weight;

        private int epoch;

        private List<double> weight;

        private List<List<double>> data;

        private List<double> target;

        public double Alpha
        {
            get
            {
                return alpha;
            }

            set
            {
                alpha = value;
            }
        }

        public double Theta
        {
            get
            {
                return theta;
            }

            set
            {
                theta = value;
            }
        }

        public double Bias
        {
            get
            {
                return bias;
            }

            set
            {
                bias = value;
            }
        }

        public double Initial_weight
        {
            get
            {
                return initial_weight;
            }

            set
            {
                initial_weight = value;
            }
        }

        public int Epoch
        {
            get
            {
                return epoch;
            }

            set
            {
                epoch = value;
            }
        }

        public List<double> Weight
        {
            get
            {
                return weight;
            }

            set
            {
                weight = value;
            }
        }

        public List<List<double>> Data
        {
            get
            {
                return data;
            }

            set
            {
                data = value;
            }
        }

        public List<double> Target
        {
            get
            {
                return target;
            }

            set
            {
                target = value;
            }
        }
    }
}
