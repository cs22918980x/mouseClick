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
    }
}
