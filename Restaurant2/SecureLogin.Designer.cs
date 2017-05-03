namespace Restaurant2
{
    partial class SecureLogin
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
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.lblChallenge = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnDecline = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResponse
            // 
            this.txtResponse.Location = new System.Drawing.Point(70, 89);
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.Size = new System.Drawing.Size(144, 20);
            this.txtResponse.TabIndex = 0;
            this.txtResponse.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblChallenge
            // 
            this.lblChallenge.AutoSize = true;
            this.lblChallenge.Location = new System.Drawing.Point(90, 50);
            this.lblChallenge.Name = "lblChallenge";
            this.lblChallenge.Size = new System.Drawing.Size(108, 13);
            this.lblChallenge.TabIndex = 1;
            this.lblChallenge.Text = "Challenge Response:";
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(70, 146);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(144, 23);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "Enter The Thunderdome";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnDecline
            // 
            this.btnDecline.Location = new System.Drawing.Point(111, 191);
            this.btnDecline.Name = "btnDecline";
            this.btnDecline.Size = new System.Drawing.Size(54, 23);
            this.btnDecline.TabIndex = 3;
            this.btnDecline.Text = "Cancel";
            this.btnDecline.UseVisualStyleBackColor = true;
            this.btnDecline.Click += new System.EventHandler(this.button1_Click);
            // 
            // SecureLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnDecline);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lblChallenge);
            this.Controls.Add(this.txtResponse);
            this.Name = "SecureLogin";
            this.Text = "SecureLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.Label lblChallenge;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnDecline;
    }
}