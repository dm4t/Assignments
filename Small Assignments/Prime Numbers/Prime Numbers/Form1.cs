using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prime_Numbers
{
    public partial class Form1 : Form
    {

        void isPrime(int number)
        {
            try
            {
                int  i, m = 0, flag = 0;
                
                m = number / 2;
                for (i = 2; i <= m; i++)
                {
                    if (number % i == 0)
                    {
                        MessageBox.Show("Number is not Prime");
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0)
                    MessageBox.Show("Number is Prime.");
            } catch
                { }



        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(textBox1.Text);
                isPrime(n);
            }
            catch { MessageBox.Show("Error: Wrong Input"); }
        }
    }
}
