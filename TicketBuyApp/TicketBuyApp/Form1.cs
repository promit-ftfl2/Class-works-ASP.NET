using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketBuyApp
{
    public partial class Form1 : Form
    {
        string name;
        double num=0;
        double price=0;
        
           
        public Form1()
        {
            InitializeComponent();
        }
        
           
        private void button1_Click(object sender, EventArgs e)
        {
            name = nametextBox1.Text;
            num = Convert.ToDouble(numtextBox2.Text);
            price = num * 10;
           
            MessageBox.Show(name + ", please pay " + price + " taka to buy tickets");

            nametextBox1.Text = "";
            numtextBox2.Clear();





        }

        private void button2_Click(object sender, EventArgs e)
        {
           
           
           
            MessageBox.Show("Customer name:" + name +  " \nNo of tickets:" + num + "\nTotal price:" + price);
            nametextBox1.Clear();
            numtextBox2.Clear();

        }
    }
}
