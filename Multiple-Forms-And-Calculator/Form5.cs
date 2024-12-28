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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void textBoxValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double val = Convert.ToDouble(textBoxValue.Text);
            double ans;

            ans = 3.1416 * val * val;

            textBoxAns.Text = Convert.ToString(ans);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form previousForm = new Form2();
            previousForm.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form logInPage = new Form1();
            logInPage.Show();
            this.Hide();
        }
    }
}
