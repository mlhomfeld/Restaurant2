namespace Restaurant2
{
    partial class CookForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnRetrieveOrder = new System.Windows.Forms.Button();
            this.btnPreppingOrder = new System.Windows.Forms.Button();
            this.btnOrderReady = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(64, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 20);
            this.textBox1.TabIndex = 0;
            // 
            // btnRetrieveOrder
            // 
            this.btnRetrieveOrder.BackColor = System.Drawing.SystemColors.InfoText;
            this.btnRetrieveOrder.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetrieveOrder.ForeColor = System.Drawing.Color.Red;
            this.btnRetrieveOrder.Location = new System.Drawing.Point(80, 144);
            this.btnRetrieveOrder.Name = "btnRetrieveOrder";
            this.btnRetrieveOrder.Size = new System.Drawing.Size(128, 80);
            this.btnRetrieveOrder.TabIndex = 1;
            this.btnRetrieveOrder.Text = "You Have An Order";
            this.btnRetrieveOrder.UseVisualStyleBackColor = false;
            // 
            // btnPreppingOrder
            // 
            this.btnPreppingOrder.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnPreppingOrder.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreppingOrder.ForeColor = System.Drawing.Color.Red;
            this.btnPreppingOrder.Location = new System.Drawing.Point(240, 144);
            this.btnPreppingOrder.Name = "btnPreppingOrder";
            this.btnPreppingOrder.Size = new System.Drawing.Size(104, 80);
            this.btnPreppingOrder.TabIndex = 2;
            this.btnPreppingOrder.Text = "Prepping Order";
            this.btnPreppingOrder.UseVisualStyleBackColor = false;
            // 
            // btnOrderReady
            // 
            this.btnOrderReady.Location = new System.Drawing.Point(368, 152);
            this.btnOrderReady.Name = "btnOrderReady";
            this.btnOrderReady.Size = new System.Drawing.Size(104, 72);
            this.btnOrderReady.TabIndex = 3;
            this.btnOrderReady.Text = "Order Ready";
            this.btnOrderReady.UseVisualStyleBackColor = true;
            // 
            // CookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 488);
            this.Controls.Add(this.btnOrderReady);
            this.Controls.Add(this.btnPreppingOrder);
            this.Controls.Add(this.btnRetrieveOrder);
            this.Controls.Add(this.textBox1);
            this.Name = "CookForm";
            this.Text = "CookForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnRetrieveOrder;
        private System.Windows.Forms.Button btnPreppingOrder;
        private System.Windows.Forms.Button btnOrderReady;
    }
}