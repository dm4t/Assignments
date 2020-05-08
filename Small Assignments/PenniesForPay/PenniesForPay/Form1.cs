using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PenniesForPay
{
    public partial class Form1 : Form
    {
        int days;
        double pay = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            pay = 1;
            try
            {
               days =  Int32.Parse(textBox1.Text);

                if (days > 0)
                {
                    for (int i = 0; i < days; i++)
                    {
                        listBox1.Items.Add(pay);
                        pay += pay;

                    }
                }
                else { MessageBox.Show("Number is negative"); }

            }
            catch { MessageBox.Show("Wrong input. Try again!"); }

            
        }
    }
}
