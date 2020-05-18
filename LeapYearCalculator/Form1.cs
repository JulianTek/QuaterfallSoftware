using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeapYearCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool IsLeapYear(int year)
        {
            double y = year / 4.0;
            if (y % 1 == 0)
            {
                y = year / 100.0;
                if (!(y % 1 == 0))
                {
                    return true;
                }

                y = year / 400.0;
                if (y % 1 == 0)
                {
                    return true;
                }
            }

            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = IsLeapYear((int) numericUpDown1.Value).ToString();
            label1.Visible = true;
        }
    }
}
