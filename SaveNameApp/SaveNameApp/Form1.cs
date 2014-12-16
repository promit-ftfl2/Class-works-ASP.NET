using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveNameApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] name = new string[10];
        private int i = 0;

        private void savebutton_Click(object sender, EventArgs e)
        {
            name[i] = nametextBox1.Text;
            nametextBox1.Clear();

            showcountlabel3.Text = (i + 1) + "persons";
            i++;
            if (i == 10)
            {
                MessageBox.Show("list is full");
            }
        }

        private void showbutton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int j = 0; j < 10; j++)
            {
                listBox1.Items.Add(name[j]);
            }
        }
    }
}
