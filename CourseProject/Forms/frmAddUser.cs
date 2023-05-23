using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject.Forms
{
    public partial class frmAddUser : Form
    {
        public frmAddUser()
        {
            InitializeComponent();
        }

        private void frmAddUser_Load(object sender, EventArgs e)
        {
            rbtnCashier.Checked = true;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            User newUser = new User();
            newUser.Name = txtFullName.Text;
            newUser.Username = txtUsername.Text;
            newUser.Password = txtPassword.Text;

            if (rbtnCashier.Checked)
                newUser.Role = 2;
            else
                newUser.Role = 1;

            UserDb.CreateUser(newUser);
            MessageBox.Show("User Created Successfully");
        }
    }
}
