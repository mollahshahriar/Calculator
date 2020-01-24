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


        private void Button17_Click(object sender, EventArgs e)
        {
            Result2.Clear();
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            Result2.Text = Result2.Text + ".";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double Firstnumber;
            double.TryParse(Result2.Text, out Firstnumber);
            double kilo = 1.60934;
            double answer = Firstnumber * kilo;

            Result2.Text = answer.ToString();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            double Firstnumber;
            double.TryParse(Result2.Text, out Firstnumber);
            double miles = 0.621371;
            double answer = Firstnumber * miles;

            Result2.Text = answer.ToString();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            double Firstnumber;
            double.TryParse(Result2.Text, out Firstnumber);
            double kilom = 0.453592;
            double answer = Firstnumber * kilom;

            Result2.Text = answer.ToString();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            double Firstnumber;
            double.TryParse(Result2.Text, out Firstnumber);
            double kilom = 2.20462;
            double answer = Firstnumber * kilom;

            Result2.Text = answer.ToString();
        }
    }
}
