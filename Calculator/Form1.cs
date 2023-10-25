using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double Add(double a, double b)
        {
            return a + b;
        }
        private double Sub(double a, double b)
        {
            return a - b;
        }
        private double Multiply(double a, double b)
        {
            return a * b;
        }
        private double Divide(double a, double b)
        {
            return a / b;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            LblOperation.Text = "+";
        }

        private void BtnSub_Click(object sender, EventArgs e)
        {
            LblOperation.Text = "-";

        }

        private void BtnMulti_Click(object sender, EventArgs e)
        {
            LblOperation.Text = "x";

        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            LblOperation.Text = "/";

        }

        private void BtnAns_Click(object sender, EventArgs e)
        {
            double a, b;
            if (double.TryParse(TxtNum1.Text, out a) && double.TryParse(TxtNum2.Text, out b))
            {
                if (LblOperation.Text == "+")
                {
                    TxtAns.Text = Add(a, b).ToString();
                }
                else if(LblOperation.Text == "-") 
                {
                    TxtAns.Text = Sub(a, b).ToString();

                }
                else if (LblOperation.Text == "x") 
                {
                    TxtAns.Text = Multiply(a, b).ToString();

                }
                else if (LblOperation.Text == "/")
                {
                    TxtAns.Text = Divide(a, b).ToString();

                }
                else
                {
                    MessageBox.Show("Invalid, Please enter Operation first.");

                }
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter valid numbers.");
            }

            
        }
    }
}
