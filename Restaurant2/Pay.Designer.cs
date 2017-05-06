namespace Restaurant2
{
    partial class Pay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pay));
            this.lstOrders = new System.Windows.Forms.ListBox();
            this.txtYourTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOrderList = new System.Windows.Forms.Label();
            this.btnPayOrder = new System.Windows.Forms.Button();
            this.listOrderedItems = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBalance = new System.Windows.Forms.TextBox();
            this.textTotalPaid = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDisplaySelectedOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstOrders
            // 
            this.lstOrders.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lstOrders.FormattingEnabled = true;
            this.lstOrders.ItemHeight = 14;
            this.lstOrders.Location = new System.Drawing.Point(38, 84);
            this.lstOrders.Name = "lstOrders";
            this.lstOrders.Size = new System.Drawing.Size(198, 312);
            this.lstOrders.TabIndex = 0;
            this.lstOrders.SelectedIndexChanged += new System.EventHandler(this.listYourOrder_SelectedIndexChanged);
            // 
            // txtYourTotal
            // 
            this.txtYourTotal.Location = new System.Drawing.Point(377, 424);
            this.txtYourTotal.Name = "txtYourTotal";
            this.txtYourTotal.Size = new System.Drawing.Size(97, 19);
            this.txtYourTotal.TabIndex = 1;
            this.txtYourTotal.TextChanged += new System.EventHandler(this.txtYourTotal_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Your Total:";
            // 
            // lblOrderList
            // 
            this.lblOrderList.AutoSize = true;
            this.lblOrderList.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderList.Location = new System.Drawing.Point(33, 36);
            this.lblOrderList.Name = "lblOrderList";
            this.lblOrderList.Size = new System.Drawing.Size(95, 22);
            this.lblOrderList.TabIndex = 3;
            this.lblOrderList.Text = "Order List";
            // 
            // btnPayOrder
            // 
            this.btnPayOrder.Location = new System.Drawing.Point(302, 545);
            this.btnPayOrder.Name = "btnPayOrder";
            this.btnPayOrder.Size = new System.Drawing.Size(111, 27);
            this.btnPayOrder.TabIndex = 4;
            this.btnPayOrder.Text = "Pay";
            this.btnPayOrder.UseVisualStyleBackColor = true;
            this.btnPayOrder.Click += new System.EventHandler(this.btnPayOrder_Click);
            // 
            // listOrderedItems
            // 
            this.listOrderedItems.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listOrderedItems.FormattingEnabled = true;
            this.listOrderedItems.ItemHeight = 14;
            this.listOrderedItems.Location = new System.Drawing.Point(301, 84);
            this.listOrderedItems.Name = "listOrderedItems";
            this.listOrderedItems.Size = new System.Drawing.Size(197, 312);
            this.listOrderedItems.TabIndex = 5;
            this.listOrderedItems.SelectedIndexChanged += new System.EventHandler(this.listOrderedItems_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(297, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ordered Items";
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.Location = new System.Drawing.Point(419, 545);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(111, 27);
            this.btnCancelOrder.TabIndex = 7;
            this.btnCancelOrder.Text = "Cancel Order";
            this.btnCancelOrder.UseVisualStyleBackColor = true;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 545);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 14);
            this.label4.TabIndex = 9;
            this.label4.Text = "Remaining Balance:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 470);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 14);
            this.label5.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(103, 580);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 14);
            this.label6.TabIndex = 13;
            this.label6.Text = "Total being paid:";
            // 
            // textBalance
            // 
            this.textBalance.Location = new System.Drawing.Point(211, 545);
            this.textBalance.Name = "textBalance";
            this.textBalance.Size = new System.Drawing.Size(76, 19);
            this.textBalance.TabIndex = 14;
            this.textBalance.TextChanged += new System.EventHandler(this.textBalance_TextChanged);
            // 
            // textTotalPaid
            // 
            this.textTotalPaid.Location = new System.Drawing.Point(211, 580);
            this.textTotalPaid.Name = "textTotalPaid";
            this.textTotalPaid.Size = new System.Drawing.Size(76, 19);
            this.textTotalPaid.TabIndex = 15;
            this.textTotalPaid.TextChanged += new System.EventHandler(this.textTotalPaid_TextChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(38, 416);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 25);
            this.btnRefresh.TabIndex = 16;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnDisplaySelectedOrder
            // 
            this.btnDisplaySelectedOrder.AutoSize = true;
            this.btnDisplaySelectedOrder.Location = new System.Drawing.Point(119, 416);
            this.btnDisplaySelectedOrder.Name = "btnDisplaySelectedOrder";
            this.btnDisplaySelectedOrder.Size = new System.Drawing.Size(125, 25);
            this.btnDisplaySelectedOrder.TabIndex = 17;
            this.btnDisplaySelectedOrder.Text = "Display Selected Order";
            this.btnDisplaySelectedOrder.UseVisualStyleBackColor = true;
            // 
            // Pay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(600, 611);
            this.Controls.Add(this.btnDisplaySelectedOrder);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.textTotalPaid);
            this.Controls.Add(this.textBalance);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancelOrder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listOrderedItems);
            this.Controls.Add(this.btnPayOrder);
            this.Controls.Add(this.lblOrderList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtYourTotal);
            this.Controls.Add(this.lstOrders);
            this.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pay";
            this.Text = "Pay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstOrders;
        private System.Windows.Forms.TextBox txtYourTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOrderList;
        private System.Windows.Forms.Button btnPayOrder;
        private System.Windows.Forms.ListBox listOrderedItems;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBalance;
        private System.Windows.Forms.TextBox textTotalPaid;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDisplaySelectedOrder;
    }
}