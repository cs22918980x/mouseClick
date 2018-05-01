using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mouseClick
{
    public partial class mouseClick : Form
    {
        double time  = 0;
        public mouseClick()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            time = 0;
            timeLabel.Text = "You have clicked " + time + " time";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            time++;
            timeLabel.Text = "You have clicked " + time + " time";
            
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            if (time > 10) 
                MessageBox.Show("Yor are Master so good");
            else if (time == 10)
                MessageBox.Show("click again");
            else 
                MessageBox.Show("too slow");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string text="";
            int i=1;
            while (i <= 9)
            {
                text += time + " * " + i + "=" + i*time +"\r\n";
                i++;
            }
            MessageBox.Show(text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string text = "";
            for (int a = 1;a <=9; a++  )
            {
                for(int b = 1;b <=9; b++)
                {
                    text += a + " * " + b + "=" + a * b + "\r\n";
                }
            }
            MessageBox.Show(text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sequenceButton_Click(object sender, EventArgs e)
        {
            string text = "";
            int b = (int)sequence1.Value;
            for (int i =1;i <=9;i++)
            {
                text += i + " * " + b + " = " + i * b + "\r\n";
            }
            MessageBox.Show(text);
        }  
    }
}
