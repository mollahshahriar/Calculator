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
    public partial class Form1 : Form
    {
        double FirstNumber;
        string Operation;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(Result1.Text);
            Result1.Text = "0";
            Operation = "-";
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Result1.Text = Result1.Text + "1";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Result1.Text = Result1.Text + "2";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Result1.Text = Result1.Text + "3";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Result1.Text = Result1.Text + "4";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Result1.Text = Result1.Text + "5";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Result1.Text = Result1.Text + "6";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Result1.Text = Result1.Text + "7";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Result1.Text = Result1.Text + "8";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Result1.Text = Result1.Text + "9";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Result1.Text = Result1.Text + "0";
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            Result1.Clear();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(Result1.Text);
            Result1.Text = "0";
            Operation = "+";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(Result1.Text);
            Result1.Text = "0";
            Operation = "*";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(Result1.Text);
            Result1.Text = "0";
            Operation = "/";
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble(Result1.Text);

            if (Operation == "+")
            {
                Result = (FirstNumber + SecondNumber);
                Result1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                Result1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                Result1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "/")
            {
                Result = (FirstNumber / SecondNumber);
                Result1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            Result1.Text = Result1.Text + ".";

        }
    }
}
