using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = emailTextBox.Text;

            // Set Email Globally after login
            User.Email = email;

            MessageBox.Show(email);
        }

        private void buttonGetGlobalVar_Click(object sender, EventArgs e)
        {
            // Get Your Global variable from any where, when needed
            string email = User.Email;

            TBEmail.Text = email;
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
