using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked )
            {
                MessageBox.Show(@"Please Select the Delivery Area!");
                return;
            }

            //ORDER COST
            var zin = 160*(int)numericUpDown1.Value;
            var MacC= 520*(int)numericUpDown2.Value;
            var BMac= 700*(int)numericUpDown3.Value;
            double total = zin + MacC + BMac;

            //24HOUR EXPERIMENT
            var ob=DateTime.Now.TimeOfDay.TotalHours;

            if (ob>=1 && ob<=8)
            {
                total -= (.1 * total);
            }

            //TAX
            total +=(.01 * total);

            //DELIVERY CHARGES
            if (radioButton1.Checked)
            {
                total += 100;
            }
            if (radioButton2.Checked)
            {
                total += 200;
            }
            if (radioButton3.Checked)
            {
                total += 300;
            }

            textBox1.Text = Convert.ToString(total);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
