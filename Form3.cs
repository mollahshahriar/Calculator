using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Result2.Text = Result2.Text + "1";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Result2.Text = Result2.Text + "2";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Result2.Text = Result2.Text + "3";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Result2.Text = Result2.Text + "4";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Result2.Text = Result2.Text + "5";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Result2.Text = Result2.Text + "6";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Result2.Text = Result2.Text + "7";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Result2.Text = Result2.Text + "8";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Result2.Text = Result2.Text + "9";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Result2.Text = Result2.Text + "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Result2.Text = Result2.Text + ".";
        }
    }
}
