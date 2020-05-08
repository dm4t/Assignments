using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaloriesBurnerWhile
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
            int cout = 0;
            int time = 10;
            int i = 0;
            while (cout != 5)
            {
                i = 0;
                while (i != time) {
                    sum += calories;
                    i++;
                }

                listBox1.Items.Add(sum.ToString()+" Calories");
                sum = 0;
                time+=5;
                cout++;

            }
        }
    }
}
