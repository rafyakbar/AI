using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AI
{
    public partial class ProgressLearningForm : Form
    {
        private Control parent;

        public ProgressLearningForm(Control parent)
        {
            InitializeComponent();
            this.parent = parent;
            this.FormClosed += ProgressLearningForm_FormClosed;
        }

        private void ProgressLearningForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.parent.Enabled = true;
        }

        public void addFormTitle(string text)
        {
            this.Text += text;
        }
    }
}
