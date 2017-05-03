namespace Restaurant2
{
    partial class LogInForm
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
            this.btnLog = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblEId = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.btnCan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(37, 190);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(75, 23);
            this.btnLog.TabIndex = 0;
            this.btnLog.Text = "Login";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(110, 119);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(100, 20);
            this.txtPass.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(110, 49);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 2;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // lblEId
            // 
            this.lblEId.AutoSize = true;
            this.lblEId.Location = new System.Drawing.Point(24, 52);
            this.lblEId.Name = "lblEId";
            this.lblEId.Size = new System.Drawing.Size(70, 13);
            this.lblEId.TabIndex = 3;
            this.lblEId.Text = "Employee ID:";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(37, 122);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(57, 13);
            this.lblPass.TabIndex = 4;
            this.lblPass.Text = "Passcode:";
            // 
            // btnCan
            // 
            this.btnCan.Location = new System.Drawing.Point(160, 190);
            this.btnCan.Name = "btnCan";
            this.btnCan.Size = new System.Drawing.Size(75, 23);
            this.btnCan.TabIndex = 5;
            this.btnCan.Text = "Cancel";
            this.btnCan.UseVisualStyleBackColor = true;
            this.btnCan.Click += new System.EventHandler(this.btnCan_Click);
            // 
            // LogInForm
            // 
            this.AcceptButton = this.btnLog;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnCan);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblEId);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.btnLog);
            this.Name = "LogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "`";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblEId;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Button btnCan;
    }
}

