using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonInArrayApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ArrayList aList=new ArrayList();
        private int i = 0;
        private void saveButton_Click(object sender, EventArgs e)
        {

            if (i < 10)
            {
                aList.Add(nameTextBox.Text);


                label3.Text = (i + 1) + " person added";
                i++;
            }
            
            
                
          if(i==10)

            MessageBox.Show("List is full");

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            showListBox.Items.Clear();
            for(int j=0;j<i;j++)
            showListBox.Items.Add(aList[j]);
        }
    }
}
