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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CookForm));
            this.btnPreppingOrder = new System.Windows.Forms.Button();
            this.btnOrderReady = new System.Windows.Forms.Button();
            this.lblPendingOrders = new System.Windows.Forms.Label();
            this.lstPendingOrders = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstMenuItemsDisplay = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnPreppingOrder
            // 
            this.btnPreppingOrder.BackColor = System.Drawing.SystemColors.Control;
            this.btnPreppingOrder.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreppingOrder.ForeColor = System.Drawing.Color.Black;
            this.btnPreppingOrder.Location = new System.Drawing.Point(427, 148);
            this.btnPreppingOrder.Name = "btnPreppingOrder";
            this.btnPreppingOrder.Size = new System.Drawing.Size(152, 42);
            this.btnPreppingOrder.TabIndex = 2;
            this.btnPreppingOrder.Text = "Prepping Order";
            this.btnPreppingOrder.UseVisualStyleBackColor = false;
            this.btnPreppingOrder.Click += new System.EventHandler(this.btnPreppingOrder_Click);
            // 
            // btnOrderReady
            // 
            this.btnOrderReady.BackColor = System.Drawing.SystemColors.Control;
            this.btnOrderReady.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderReady.ForeColor = System.Drawing.Color.Black;
            this.btnOrderReady.Location = new System.Drawing.Point(427, 254);
            this.btnOrderReady.Name = "btnOrderReady";
            this.btnOrderReady.Size = new System.Drawing.Size(152, 42);
            this.btnOrderReady.TabIndex = 3;
            this.btnOrderReady.Text = "Order Ready";
            this.btnOrderReady.UseVisualStyleBackColor = false;
            this.btnOrderReady.Click += new System.EventHandler(this.btnOrderReady_Click);
            // 
            // lblPendingOrders
            // 
            this.lblPendingOrders.AutoSize = true;
            this.lblPendingOrders.BackColor = System.Drawing.Color.White;
            this.lblPendingOrders.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendingOrders.Location = new System.Drawing.Point(21, 9);
            this.lblPendingOrders.Name = "lblPendingOrders";
            this.lblPendingOrders.Size = new System.Drawing.Size(128, 21);
            this.lblPendingOrders.TabIndex = 4;
            this.lblPendingOrders.Text = "Pending Orders";
            // 
            // lstPendingOrders
            // 
            this.lstPendingOrders.FormattingEnabled = true;
            this.lstPendingOrders.ItemHeight = 14;
            this.lstPendingOrders.Location = new System.Drawing.Point(12, 46);
            this.lstPendingOrders.Name = "lstPendingOrders";
            this.lstPendingOrders.Size = new System.Drawing.Size(148, 368);
            this.lstPendingOrders.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Menu Items";
            // 
            // lstMenuItemsDisplay
            // 
            this.lstMenuItemsDisplay.FormattingEnabled = true;
            this.lstMenuItemsDisplay.ItemHeight = 14;
            this.lstMenuItemsDisplay.Location = new System.Drawing.Point(213, 46);
            this.lstMenuItemsDisplay.Name = "lstMenuItemsDisplay";
            this.lstMenuItemsDisplay.Size = new System.Drawing.Size(156, 368);
            this.lstMenuItemsDisplay.TabIndex = 7;
            // 
            // CookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(600, 478);
            this.Controls.Add(this.lstMenuItemsDisplay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstPendingOrders);
            this.Controls.Add(this.lblPendingOrders);
            this.Controls.Add(this.btnOrderReady);
            this.Controls.Add(this.btnPreppingOrder);
            this.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CookForm";
            this.Text = "CookForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPreppingOrder;
        private System.Windows.Forms.Button btnOrderReady;
        private System.Windows.Forms.Label lblPendingOrders;
        private System.Windows.Forms.ListBox lstPendingOrders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstMenuItemsDisplay;
    }
}