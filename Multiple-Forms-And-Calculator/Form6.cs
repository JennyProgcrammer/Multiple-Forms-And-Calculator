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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string feedback = ""; 

            if (checkBoxColorPalette.CheckState == CheckState.Checked)
            {
                feedback += "Color Palette, "; 
            }
            if (checkBoxFunctions.CheckState == CheckState.Checked)
            {
                feedback += "Functions, "; 
            }
            if (checkBoxBasicCalcu.CheckState == CheckState.Checked)
            {
                feedback += "Basic Calculator, ";
            }
            if (checkBoxSize.CheckState == CheckState.Checked)
            {
                feedback += "Size of the forms, ";
            }
            if (checkBoxCreator.CheckState == CheckState.Checked)
            {
                feedback += "Creator, ";
            }

            MessageBox.Show("You liked the following: " + feedback + "Thank you!"); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form logInPage = new Form1();
            logInPage.Show();
            this.Hide();
        }
    }
}
