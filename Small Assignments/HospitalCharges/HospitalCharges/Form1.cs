using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalCharges
{
    public partial class Form1 : Form
    {

        int CalcStayCharger(int days)
        {
            ;
            int sum = 0;
            sum = days * 350;
            return sum;
        }

        int CalcMissCharges(int med, int sur, int lab, int phy)
        {
            int sum;
            return med + sur + lab + phy;
            
        }
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int day = int.Parse(textBox1.Text);
                int med = int.Parse(textBox2.Text);
                int sur = int.Parse(textBox3.Text);
                int lab = int.Parse(textBox4.Text);
                int phu = int.Parse(textBox5.Text);


                int sum = 0;
                sum = CalcStayCharger(day);
                sum =  sum + CalcMissCharges(med,sur,lab,phu);

                MessageBox.Show(sum.ToString()+" $  Cost"); 
               
            }
            catch(Exception Ex) { MessageBox.Show("Wrong input"); }
        }
    }
}
