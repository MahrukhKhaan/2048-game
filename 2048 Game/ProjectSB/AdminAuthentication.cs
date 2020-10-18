using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjectSB
{
    public partial class AdminAuthentication : Form
    {
        public AdminAuthentication()
        {
            InitializeComponent();
            label3.Hide();
        }

        private void AdminAuthentication_Load(object sender, EventArgs e)
        {
            
        }


        private void submitbtn_Click_1(object sender, EventArgs e)
        {
            if (username.Text == "" || pwd.Text == "")
            {
                label3.Show();
            }
            else 
            {
                this.Hide();
                SuccessfulAdminAuthentication obj = new SuccessfulAdminAuthentication();
                obj.Show();
               
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
