using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retail_Price_Calculator
{
    public partial class Form1 : Form
    {
        float proc;
        float w_cost;
        
        double retail;
        public void CalculateRetail(float cost, float percentage)
        {
            
               

                percentage = percentage / 100;

                retail = Math.Round((cost * percentage) + cost, 2);



                MessageBox.Show("Price: " + retail.ToString() + "$");           


        }

        public Form1()
        {
            
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                w_cost = float.Parse(textBox1.Text);
                proc = float.Parse(textBox2.Text);
                CalculateRetail(w_cost, proc);
            }
            catch {
                MessageBox.Show("Wrong input , try again");
            }

            

        }
    }
}
