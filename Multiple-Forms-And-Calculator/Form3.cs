using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marinay___Activity_4
{
    public partial class Form3 : Form
    {
        double FirstNum;
        string Operation; 
        public Form3()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBoxNum.Clear(); 
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (textBoxNum.Text == "0" && textBoxNum.Text !=null)
            { textBoxNum.Text = "1"; }
            else
            {
                textBoxNum.Text = textBoxNum.Text + "1"; 
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (textBoxNum.Text == "0" && textBoxNum.Text != null)
            { textBoxNum.Text = "2"; }
            else
            {
                textBoxNum.Text = textBoxNum.Text + "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (textBoxNum.Text == "0" && textBoxNum.Text != null)
            { textBoxNum.Text = "3"; }
            else
            {
                textBoxNum.Text = textBoxNum.Text + "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (textBoxNum.Text == "0" && textBoxNum.Text != null)
            { textBoxNum.Text = "4"; }
            else
            {
                textBoxNum.Text = textBoxNum.Text + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (textBoxNum.Text == "0" && textBoxNum.Text != null)
            { textBoxNum.Text = "5"; }
            else
            {
                textBoxNum.Text = textBoxNum.Text + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (textBoxNum.Text == "0" && textBoxNum.Text != null)
            { textBoxNum.Text = "6"; }
            else
            {
                textBoxNum.Text = textBoxNum.Text + "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (textBoxNum.Text == "0" && textBoxNum.Text != null)
            { textBoxNum.Text = "7"; }
            else
            {
                textBoxNum.Text = textBoxNum.Text + "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (textBoxNum.Text == "0" && textBoxNum.Text != null)
            { textBoxNum.Text = "8"; }
            else
            {
                textBoxNum.Text = textBoxNum.Text + "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (textBoxNum.Text == "0" && textBoxNum.Text != null)
            { textBoxNum.Text = "9"; }
            else
            {
                textBoxNum.Text = textBoxNum.Text + "9";
            }
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            if (textBoxNum.Text == "0" && textBoxNum.Text != null)
            { textBoxNum.Text = "."; }
            else
            {
                textBoxNum.Text = textBoxNum.Text + ".";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (textBoxNum.Text == "0" && textBoxNum.Text != null)
            { textBoxNum.Text = "0"; }
            else
            {
                textBoxNum.Text = textBoxNum.Text + "0";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FirstNum = Convert.ToDouble(textBoxNum.Text);
            textBoxNum.Text = "0";
            Operation = "+"; 
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            FirstNum = Convert.ToDouble(textBoxNum.Text);
            textBoxNum.Text = "0";
            Operation = "-";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            FirstNum = Convert.ToDouble(textBoxNum.Text);
            textBoxNum.Text = "0";
            Operation = "*";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            FirstNum = Convert.ToDouble(textBoxNum.Text);
            textBoxNum.Text = "0";
            Operation = "/";
        }

        private void btnAns_Click(object sender, EventArgs e)
        {
            double SecondNum;
            double Result;

            SecondNum = Convert.ToDouble(textBoxNum.Text);
            if (Operation == "+")
            {
                Result = (FirstNum + SecondNum);
                textBoxNum.Text = Convert.ToString(Result);
                FirstNum = Result; 
            }
            if (Operation == "-")
            {
                Result = (FirstNum - SecondNum);
                textBoxNum.Text = Convert.ToString(Result);
                FirstNum = Result;
            }
            if (Operation == "*")
            {
                Result = (FirstNum * SecondNum);
                textBoxNum.Text = Convert.ToString(Result);
                FirstNum = Result;
            }
            if (Operation == "/")
            {
                if (SecondNum == 0)
                {
                    textBoxNum.Text = "Cannot divide by zero"; 
                }
                else
                {
                    Result = (FirstNum / SecondNum);
                    textBoxNum.Text = Convert.ToString(Result);
                    FirstNum = Result; 
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form previousForm = new Form2();
            previousForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form logInPage = new Form1();
            logInPage.Show();
            this.Hide();
        }
    }
}
