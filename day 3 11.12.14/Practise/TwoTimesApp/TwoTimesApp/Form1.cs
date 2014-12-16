using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwoTimesApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double aNumber = Convert.ToDouble(inputTextBox.Text);
            double result = MakeDouble(aNumber);
            outputTextBox.Text = Convert.ToString(result);
        }

        private double MakeDouble(double i)
        {
            return 2*i;
        }
    }
}
