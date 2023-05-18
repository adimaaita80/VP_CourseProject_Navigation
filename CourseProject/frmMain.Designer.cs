namespace CourseProject
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlSideMenu = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnNavAddFoodCategory = new System.Windows.Forms.Button();
            this.btnNavAddFoodItem = new System.Windows.Forms.Button();
            this.btnMakeOrder = new System.Windows.Forms.Button();
            this.pnlSideMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSideMenu
            // 
            this.pnlSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlSideMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSideMenu.Controls.Add(this.btnMakeOrder);
            this.pnlSideMenu.Controls.Add(this.btnNavAddFoodItem);
            this.pnlSideMenu.Controls.Add(this.btnNavAddFoodCategory);
            this.pnlSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlSideMenu.Name = "pnlSideMenu";
            this.pnlSideMenu.Size = new System.Drawing.Size(231, 796);
            this.pnlSideMenu.TabIndex = 0;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(231, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1058, 796);
            this.pnlMain.TabIndex = 1;
            // 
            // btnNavAddFoodCategory
            // 
            this.btnNavAddFoodCategory.Location = new System.Drawing.Point(33, 51);
            this.btnNavAddFoodCategory.Name = "btnNavAddFoodCategory";
            this.btnNavAddFoodCategory.Size = new System.Drawing.Size(162, 49);
            this.btnNavAddFoodCategory.TabIndex = 0;
            this.btnNavAddFoodCategory.Text = "Add Category";
            this.btnNavAddFoodCategory.UseVisualStyleBackColor = true;
            this.btnNavAddFoodCategory.Click += new System.EventHandler(this.btnNavAddFoodCategory_Click);
            // 
            // btnNavAddFoodItem
            // 
            this.btnNavAddFoodItem.Location = new System.Drawing.Point(33, 147);
            this.btnNavAddFoodItem.Name = "btnNavAddFoodItem";
            this.btnNavAddFoodItem.Size = new System.Drawing.Size(162, 49);
            this.btnNavAddFoodItem.TabIndex = 1;
            this.btnNavAddFoodItem.Text = "Add Food Item";
            this.btnNavAddFoodItem.UseVisualStyleBackColor = true;
            this.btnNavAddFoodItem.Click += new System.EventHandler(this.btnNavAddFoodItem_Click);
            // 
            // btnMakeOrder
            // 
            this.btnMakeOrder.Location = new System.Drawing.Point(33, 248);
            this.btnMakeOrder.Name = "btnMakeOrder";
            this.btnMakeOrder.Size = new System.Drawing.Size(162, 49);
            this.btnMakeOrder.TabIndex = 2;
            this.btnMakeOrder.Text = "Make Order";
            this.btnMakeOrder.UseVisualStyleBackColor = true;
            this.btnMakeOrder.Click += new System.EventHandler(this.btnMakeOrder_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 796);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSideMenu);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.pnlSideMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSideMenu;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnMakeOrder;
        private System.Windows.Forms.Button btnNavAddFoodItem;
        private System.Windows.Forms.Button btnNavAddFoodCategory;
    }
}

