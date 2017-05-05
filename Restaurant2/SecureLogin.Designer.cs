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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecureLogin));
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.lblChallenge = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnDecline = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResponse
            // 
            this.txtResponse.Location = new System.Drawing.Point(218, 316);
            this.txtResponse.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.Size = new System.Drawing.Size(367, 28);
            this.txtResponse.TabIndex = 0;
            this.txtResponse.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblChallenge
            // 
            this.lblChallenge.AutoSize = true;
            this.lblChallenge.Location = new System.Drawing.Point(15, 323);
            this.lblChallenge.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblChallenge.Name = "lblChallenge";
            this.lblChallenge.Size = new System.Drawing.Size(166, 21);
            this.lblChallenge.TabIndex = 1;
            this.lblChallenge.Text = "Challenge Response:";
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(289, 375);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(219, 28);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "Enter The Thunderdome";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnDecline
            // 
            this.btnDecline.Location = new System.Drawing.Point(15, 378);
            this.btnDecline.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnDecline.Name = "btnDecline";
            this.btnDecline.Size = new System.Drawing.Size(99, 25);
            this.btnDecline.TabIndex = 3;
            this.btnDecline.Text = "Cancel";
            this.btnDecline.UseVisualStyleBackColor = true;
            this.btnDecline.Click += new System.EventHandler(this.button1_Click);
            // 
            // SecureLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(600, 456);
            this.Controls.Add(this.btnDecline);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lblChallenge);
            this.Controls.Add(this.txtResponse);
            this.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
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