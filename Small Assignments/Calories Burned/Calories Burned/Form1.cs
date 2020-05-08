using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calories_Burned
{
    public partial class Form1 : Form
    {
        
        float calories = 3.9f;
        float sum = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 10; i <= 30;)
            {
                for (int n = 1; n <= i; n++)
                {
                    sum = sum + calories;
                }
                listBox1.Items.Add(sum.ToString()+" calories");
                sum = 0;
                i = i + 5;
            }
        }
    }
}
