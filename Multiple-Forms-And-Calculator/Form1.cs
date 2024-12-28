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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string UserName = textBoxUsername.Text;
            string passWord = textBoxPassword.Text; 

            if (UserName == "Jennymarinay03" && passWord == "2003")
            {
                MessageBox.Show("Log-in Succcesful!");
                Form2 form = new Form2();
                form.Visible = true;
                this.Hide(); 
            }
            else { MessageBox.Show("Invalid Credentials, Please Try Again!");  }
        }
    }
}
