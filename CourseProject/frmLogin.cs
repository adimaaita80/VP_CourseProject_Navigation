using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject
{
    public partial class frmLogin : Form
    {
        User defaultUser;

        public frmLogin()
        {
            InitializeComponent();

            defaultUser = new User();
            defaultUser.Name = "Adi Maaita";
            defaultUser.Username = "adi";
            defaultUser.Password = "123";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == defaultUser.Username && txtPassword.Text == defaultUser.Password)
            {
                frmMain mainForm = new frmMain(defaultUser);
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid login information");
            }
            
        }
    }
}
