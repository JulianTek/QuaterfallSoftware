using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvenOddAlgo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool IsEven(int input)
        {
            int result = input % 2;
            if (result == 0)
            {
                return true;
            }

            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           label1.Text = IsEven((int)numericUpDown1.Value).ToString();
           label1.Visible = true;
        }
    }
}
