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
            this.btnRetrieveOrder = new System.Windows.Forms.Button();
            this.btnPreppingOrder = new System.Windows.Forms.Button();
            this.btnOrderReady = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRetrieveOrder
            // 
            this.btnRetrieveOrder.BackColor = System.Drawing.SystemColors.InfoText;
            this.btnRetrieveOrder.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetrieveOrder.ForeColor = System.Drawing.Color.Red;
            this.btnRetrieveOrder.Location = new System.Drawing.Point(24, 296);
            this.btnRetrieveOrder.Name = "btnRetrieveOrder";
            this.btnRetrieveOrder.Size = new System.Drawing.Size(168, 112);
            this.btnRetrieveOrder.TabIndex = 1;
            this.btnRetrieveOrder.Text = "You Have An Order";
            this.btnRetrieveOrder.UseVisualStyleBackColor = false;
            this.btnRetrieveOrder.Click += new System.EventHandler(this.btnRetrieveOrder_Click);
            // 
            // btnPreppingOrder
            // 
            this.btnPreppingOrder.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnPreppingOrder.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreppingOrder.ForeColor = System.Drawing.Color.Red;
            this.btnPreppingOrder.Location = new System.Drawing.Point(240, 296);
            this.btnPreppingOrder.Name = "btnPreppingOrder";
            this.btnPreppingOrder.Size = new System.Drawing.Size(168, 112);
            this.btnPreppingOrder.TabIndex = 2;
            this.btnPreppingOrder.Text = "Prepping Order";
            this.btnPreppingOrder.UseVisualStyleBackColor = false;
            // 
            // btnOrderReady
            // 
            this.btnOrderReady.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnOrderReady.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderReady.ForeColor = System.Drawing.Color.Red;
            this.btnOrderReady.Location = new System.Drawing.Point(464, 296);
            this.btnOrderReady.Name = "btnOrderReady";
            this.btnOrderReady.Size = new System.Drawing.Size(152, 112);
            this.btnOrderReady.TabIndex = 3;
            this.btnOrderReady.Text = "Order Ready";
            this.btnOrderReady.UseVisualStyleBackColor = false;
            // 
            // CookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(642, 444);
            this.Controls.Add(this.btnOrderReady);
            this.Controls.Add(this.btnPreppingOrder);
            this.Controls.Add(this.btnRetrieveOrder);
            this.Name = "CookForm";
            this.Text = "CookForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRetrieveOrder;
        private System.Windows.Forms.Button btnPreppingOrder;
        private System.Windows.Forms.Button btnOrderReady;
    }
}