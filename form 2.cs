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
        int die;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RollDieB_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            die = random.Next(1, 6);
            MessageBox.Show("random num = " + die);
        }
        
    }
}
