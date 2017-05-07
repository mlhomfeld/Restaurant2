namespace Restaurant2
{
    partial class ManagerForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
            this.btnCreateEmployee = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.btnModifyEmployee = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.txtRmvEmployee = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EmployeeID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreateEmployee
            // 
            this.btnCreateEmployee.Location = new System.Drawing.Point(15, 290);
            this.btnCreateEmployee.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCreateEmployee.Name = "btnCreateEmployee";
            this.btnCreateEmployee.Size = new System.Drawing.Size(167, 34);
            this.btnCreateEmployee.TabIndex = 0;
            this.btnCreateEmployee.Text = "Create Employee";
            this.btnCreateEmployee.UseVisualStyleBackColor = true;
            this.btnCreateEmployee.Click += new System.EventHandler(this.btnCreateEmployee_Click);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(15, 341);
            this.btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(167, 31);
            this.btn.TabIndex = 1;
            this.btn.Text = "Remove Employee";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnModifyEmployee
            // 
            this.btnModifyEmployee.Location = new System.Drawing.Point(15, 386);
            this.btnModifyEmployee.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnModifyEmployee.Name = "btnModifyEmployee";
            this.btnModifyEmployee.Size = new System.Drawing.Size(167, 35);
            this.btnModifyEmployee.TabIndex = 2;
            this.btnModifyEmployee.Text = "Modify Employee";
            this.btnModifyEmployee.UseVisualStyleBackColor = true;
            this.btnModifyEmployee.Click += new System.EventHandler(this.btnModifyEmployee_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(416, 388);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(85, 31);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // txtRmvEmployee
            // 
            this.txtRmvEmployee.Location = new System.Drawing.Point(355, 341);
            this.txtRmvEmployee.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtRmvEmployee.Name = "txtRmvEmployee";
            this.txtRmvEmployee.Size = new System.Drawing.Size(203, 28);
            this.txtRmvEmployee.TabIndex = 4;
            this.txtRmvEmployee.TextChanged += new System.EventHandler(this.txtRmvEmployee_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // EmployeeID
            // 
            this.EmployeeID.AutoSize = true;
            this.EmployeeID.Location = new System.Drawing.Point(395, 297);
            this.EmployeeID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.Size = new System.Drawing.Size(117, 21);
            this.EmployeeID.TabIndex = 6;
            this.EmployeeID.Text = "Employee ID:";
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(600, 449);
            this.Controls.Add(this.EmployeeID);
            this.Controls.Add(this.txtRmvEmployee);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnModifyEmployee);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.btnCreateEmployee);
            this.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ManagerForm";
            this.Text = "ManagerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateEmployee;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btnModifyEmployee;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TextBox txtRmvEmployee;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label EmployeeID;
    }
}