using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factorial_Calculator
{
    public partial class Form1 : Form
    {
        int number;
        double factorial;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                factorial = 1;
                number = Int32.Parse(textBox1.Text);
                if (number > 0)
                {

                    for (int i = 1; i <= number; i++)
                    {
                        factorial = factorial * i;
                    }
                    label1.Text = "Factorial from number  '"+ number +"'  is:  " +factorial.ToString();
                }
                else { MessageBox.Show("Number is negativ "); }
            }
            catch { MessageBox.Show("Wrong input, Try again "); }
        }
    }
}
