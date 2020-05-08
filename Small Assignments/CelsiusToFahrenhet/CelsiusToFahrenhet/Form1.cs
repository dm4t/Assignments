using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CelsiusToFahrenhet
{
    public partial class Form1 : Form
    {
        double f = 0;
        double celsius = 0;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 0; i <= 20; i++) {
                listBox1.Items.Add(i);
            
            }       


        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            foreach( var cel in listBox1.Items) {
                celsius = double.Parse(cel.ToString());
                f = (celsius * 9) / 5 + 32;                
                listBox2.Items.Add(f+ " F") ;

            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }
    }
}
