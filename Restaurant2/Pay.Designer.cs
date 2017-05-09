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
            this.lblYourTotal = new System.Windows.Forms.Label();
            this.lblOrderList = new System.Windows.Forms.Label();
            this.btnPayOrder = new System.Windows.Forms.Button();
            this.lstOrderedItems = new System.Windows.Forms.ListBox();
            this.lblOrderedItems = new System.Windows.Forms.Label();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.lblRemainingBalance = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.txtRemainingBalance = new System.Windows.Forms.TextBox();
            this.txtTotalPaid = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDisplaySelectedOrder = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstOrders
            // 
            this.lstOrders.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lstOrders.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstOrders.FormattingEnabled = true;
            this.lstOrders.ItemHeight = 15;
            this.lstOrders.Location = new System.Drawing.Point(38, 84);
            this.lstOrders.Name = "lstOrders";
            this.lstOrders.Size = new System.Drawing.Size(198, 304);
            this.lstOrders.TabIndex = 0;
            // 
            // txtYourTotal
            // 
            this.txtYourTotal.Location = new System.Drawing.Point(377, 424);
            this.txtYourTotal.Name = "txtYourTotal";
            this.txtYourTotal.Size = new System.Drawing.Size(97, 19);
            this.txtYourTotal.TabIndex = 1;
            // 
            // lblYourTotal
            // 
            this.lblYourTotal.AutoSize = true;
            this.lblYourTotal.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourTotal.Location = new System.Drawing.Point(299, 427);
            this.lblYourTotal.Name = "lblYourTotal";
            this.lblYourTotal.Size = new System.Drawing.Size(69, 15);
            this.lblYourTotal.TabIndex = 2;
            this.lblYourTotal.Text = "Your Total:";
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
            this.btnPayOrder.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayOrder.Location = new System.Drawing.Point(310, 501);
            this.btnPayOrder.Name = "btnPayOrder";
            this.btnPayOrder.Size = new System.Drawing.Size(111, 27);
            this.btnPayOrder.TabIndex = 4;
            this.btnPayOrder.Text = "Pay";
            this.btnPayOrder.UseVisualStyleBackColor = true;
            this.btnPayOrder.Click += new System.EventHandler(this.btnPayOrder_Click);
            // 
            // lstOrderedItems
            // 
            this.lstOrderedItems.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lstOrderedItems.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstOrderedItems.FormattingEnabled = true;
            this.lstOrderedItems.ItemHeight = 15;
            this.lstOrderedItems.Location = new System.Drawing.Point(301, 84);
            this.lstOrderedItems.Name = "lstOrderedItems";
            this.lstOrderedItems.Size = new System.Drawing.Size(197, 304);
            this.lstOrderedItems.TabIndex = 5;
            // 
            // lblOrderedItems
            // 
            this.lblOrderedItems.AutoSize = true;
            this.lblOrderedItems.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderedItems.Location = new System.Drawing.Point(297, 36);
            this.lblOrderedItems.Name = "lblOrderedItems";
            this.lblOrderedItems.Size = new System.Drawing.Size(124, 22);
            this.lblOrderedItems.TabIndex = 6;
            this.lblOrderedItems.Text = "Ordered Items";
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelOrder.Location = new System.Drawing.Point(427, 501);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(111, 27);
            this.btnCancelOrder.TabIndex = 7;
            this.btnCancelOrder.Text = "Cancel Order";
            this.btnCancelOrder.UseVisualStyleBackColor = true;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblRemainingBalance
            // 
            this.lblRemainingBalance.AutoSize = true;
            this.lblRemainingBalance.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemainingBalance.Location = new System.Drawing.Point(91, 489);
            this.lblRemainingBalance.Name = "lblRemainingBalance";
            this.lblRemainingBalance.Size = new System.Drawing.Size(114, 15);
            this.lblRemainingBalance.TabIndex = 9;
            this.lblRemainingBalance.Text = "Remaining Balance:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 470);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 14);
            this.label5.TabIndex = 11;
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.Location = new System.Drawing.Point(149, 528);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(56, 15);
            this.lblPayment.TabIndex = 13;
            this.lblPayment.Text = "Payment:";
            // 
            // txtRemainingBalance
            // 
            this.txtRemainingBalance.Location = new System.Drawing.Point(211, 487);
            this.txtRemainingBalance.Name = "txtRemainingBalance";
            this.txtRemainingBalance.Size = new System.Drawing.Size(76, 19);
            this.txtRemainingBalance.TabIndex = 14;
            // 
            // txtTotalPaid
            // 
            this.txtTotalPaid.Location = new System.Drawing.Point(211, 524);
            this.txtTotalPaid.Name = "txtTotalPaid";
            this.txtTotalPaid.Size = new System.Drawing.Size(76, 19);
            this.txtTotalPaid.TabIndex = 15;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(38, 416);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 25);
            this.btnRefresh.TabIndex = 16;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDisplaySelectedOrder
            // 
            this.btnDisplaySelectedOrder.AutoSize = true;
            this.btnDisplaySelectedOrder.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplaySelectedOrder.Location = new System.Drawing.Point(119, 416);
            this.btnDisplaySelectedOrder.Name = "btnDisplaySelectedOrder";
            this.btnDisplaySelectedOrder.Size = new System.Drawing.Size(143, 25);
            this.btnDisplaySelectedOrder.TabIndex = 17;
            this.btnDisplaySelectedOrder.Text = "Display Selected Order";
            this.btnDisplaySelectedOrder.UseVisualStyleBackColor = true;
            this.btnDisplaySelectedOrder.Click += new System.EventHandler(this.btnDisplaySelectedOrder_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(255, 569);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(94, 30);
            this.btnReturn.TabIndex = 18;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // Pay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(600, 611);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDisplaySelectedOrder);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtTotalPaid);
            this.Controls.Add(this.txtRemainingBalance);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblRemainingBalance);
            this.Controls.Add(this.btnCancelOrder);
            this.Controls.Add(this.lblOrderedItems);
            this.Controls.Add(this.lstOrderedItems);
            this.Controls.Add(this.btnPayOrder);
            this.Controls.Add(this.lblOrderList);
            this.Controls.Add(this.lblYourTotal);
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
        private System.Windows.Forms.Label lblYourTotal;
        private System.Windows.Forms.Label lblOrderList;
        private System.Windows.Forms.Button btnPayOrder;
        private System.Windows.Forms.ListBox lstOrderedItems;
        private System.Windows.Forms.Label lblOrderedItems;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.Label lblRemainingBalance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.TextBox txtRemainingBalance;
        private System.Windows.Forms.TextBox txtTotalPaid;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDisplaySelectedOrder;
        private System.Windows.Forms.Button btnReturn;
    }
}