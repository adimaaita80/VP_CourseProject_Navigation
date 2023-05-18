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

        public frmMain()
        {
            InitializeComponent();
            currentForm = new Form();
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
    }
}
