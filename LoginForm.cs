using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEGFI_1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void logIn_button_Click(object sender, EventArgs e)
        {
            object userLogin = new LoginHelper(textBox1.Text.ToString(), textBox2.Text.ToString());
            
            //this is an admin access bypassing all the DB, placeholder essentially
            if (textBox1.Text.ToString() == "admin"  &&  textBox2.Text.ToString() == "admin")
            {
                //get to main screen
                new MainScreen().Show(); ;
                //Form newForm = new MainScreen();
                //newForm.Show();
                //hide login form
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong credentials");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //nothing here
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
