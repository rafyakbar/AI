using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AI.NeuralNetwork
{
    public class ActivationFunction
    {
        public static object linearPiecewise(double theta, double y)
        {
            if (y < -theta)
            {
                return -1;
            }
            if (-theta <= y && y <= theta)
            {
                return y;
            }
            if (y >= theta)
            {
                return 1;
            }
            return "Tidak memenuhi syarat!";
        }

        public static object linear(double alpha, double y)
        {
            return alpha * y;
        }

        public static object bipolarSigmoid(double alpha, double y)
        {
            double f = (Math.Exp((alpha * y)) - Math.Exp((-alpha * y))) / (Math.Exp((alpha * y)) + Math.Exp((-alpha * y)));
            if(-1 <= f && f <= 1)
            {
                return f;
            }
            return "Tidak memenuhi syarat!";
        }

        public static object binerSigmoid(double alpha, double y)
        {
            double f = 1 / (1 + Math.Exp(-alpha * y));

            if(0 <= f && f <= 1)
                return f;

            return "Tidak memenuhi syarat!";
        }

        public static object binerTreshold(double y)
        {
            if(y < 0)
            {
                return 0;
            }
            if(y >= 0)
            {
                return 1;
            }
            return "Tidak memenuhi syarat!";
        }

        public static object bipolarTreshold(double y)
        {
            if (y < 0)
            {
                return -1;
            }
            if (y >= 0)
            {
                return 1;
            }
            return "Tidak memenuhi syarat!";
        }
    }
}
