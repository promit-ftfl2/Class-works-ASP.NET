using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankInterestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bankname = banknameComboBox.Text;
            string year = textBox1.Text;
            string amount = textBox2.Text;
            double interest=0;
            if (bankname == "BRAC")
            {
                interest = (6*Convert.ToDouble(year)*Convert.ToDouble(amount)/100);
            }
            if (bankname == "HSBC")
            {
                interest = (8 * Convert.ToDouble(year) * Convert.ToDouble(amount) / 100);
            }
            if (bankname == "DBBL")
            {
                interest = (7 * Convert.ToDouble(year) * Convert.ToDouble(amount) / 100);
            }
            label4.Text = Convert.ToString(interest);
        }
    }
}
