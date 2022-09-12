/* Cameron Faison, 9/11/22, Startup Project*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Homework1
{
    public partial class Form1 : Form
    {
        int number;
        double numToRound;
        public Form1()
        {
            InitializeComponent();
        }

        private void doSomething_Click(object sender, EventArgs e)
        {
            MessageBox.Show("UAT ROCKS");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox.1Text, out number))
            {
                MessageBox.Show("Valid");
            }
            else
            {
                MessageBox.Show("NOT Valid");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
         if (int.double(textBox.2Text, out numToRound))
        {
                numToRound = Math.Round((Double)numToRound), 2);
                textBox2.Text = numToRound.ToString();
        }
        else
            {
                MessageBox.Show("not a valid number");
            }
                   
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
