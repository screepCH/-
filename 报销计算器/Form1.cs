using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 报销计算器
{
    public partial class Form1 : Form
    {
        int startmile;
        int endmile;
        double price;
        public Form1()
        { 
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            startmile = (int)numericUpDown1.Value;
        }
    }
}
