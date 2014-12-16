using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberUiApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long num=Convert.ToInt32(numtextBox1.Text);
            

            for (int i = 1; i <= num; i++)
            {
                numberlistBox1.Items.Add(i);
            }
            numtextBox1.Clear();
        }
    }
}
