using CourseProject.Forms;
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
    public partial class frmMain : Form
    {
        private Form currentForm;
        private User _user;

        public frmMain(User user)
        {
            InitializeComponent();
            currentForm = new Form();
            _user = user;
        }

        private void btnNavAddFoodCategory_Click(object sender, EventArgs e)
        {
            currentForm.Close();

            currentForm = new frmFoodCategory();
            SetFormSettings();
        }

        private void btnNavAddFoodItem_Click(object sender, EventArgs e)
        {
            currentForm.Close();

            currentForm = new frmFoodItem();
            SetFormSettings();
        }

        
        private void btnMakeOrder_Click(object sender, EventArgs e)
        {
            currentForm.Close();

            currentForm = new frmMakeOrder();
            SetFormSettings();
        }

        // General methods
        private void SetFormSettings()
        {
            currentForm.TopLevel = false;
            currentForm.FormBorderStyle = FormBorderStyle.None;
            currentForm.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(currentForm);
            currentForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentForm.Close();

            currentForm = new frmBigButtons();
            SetFormSettings();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            label1.Text = "Welcome " + _user.Name;
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            currentForm.Close();

            currentForm = new frmAddUser();
            SetFormSettings();
        }
    }
}
