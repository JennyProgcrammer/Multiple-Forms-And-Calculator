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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form logInPage = new Form1();
            logInPage.Show();
            this.Hide();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string choice = "";

            if (radioBtnCalcu.Checked)
            {
                choice = radioBtnCalcu.Text;
                MessageBox.Show(choice);
                Form3 basicCalculator = new Form3();
                basicCalculator.Show();
                this.Hide();
            }
            if (radioBtnAreaSquare.Checked)
            {

                choice = radioBtnAreaSquare.Text;
                MessageBox.Show(choice);
                Form4 areaOfSquareCalcu = new Form4();
                areaOfSquareCalcu.Show();
                this.Hide();
            }
            if (radioBtnAreaCircle.Checked)
            {

                choice = radioBtnAreaCircle.Text;
                MessageBox.Show(choice);
                Form5 areaOfCircleCalcu = new Form5();
                areaOfCircleCalcu.Show();
                this.Hide();
            }
            if (radioBtnFeedback.Checked)
            {

                choice = radioBtnFeedback.Text;
                MessageBox.Show(choice);
                Form6 feedbackList = new Form6();
                feedbackList.Show();
                this.Hide();
            }
        }

        private void radioBtnCalcu_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
} 

