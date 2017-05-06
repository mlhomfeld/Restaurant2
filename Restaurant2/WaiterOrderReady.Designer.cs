namespace Restaurant2
{
    partial class WaiterOrderReady
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
            this.lblReadyOrders = new System.Windows.Forms.Label();
            this.lstReadyOrders = new System.Windows.Forms.ListBox();
            this.btnDeliverOrder = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblReadyOrders
            // 
            this.lblReadyOrders.AutoSize = true;
            this.lblReadyOrders.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReadyOrders.Location = new System.Drawing.Point(13, 13);
            this.lblReadyOrders.Name = "lblReadyOrders";
            this.lblReadyOrders.Size = new System.Drawing.Size(113, 21);
            this.lblReadyOrders.TabIndex = 0;
            this.lblReadyOrders.Text = "Ready Orders";
            // 
            // lstReadyOrders
            // 
            this.lstReadyOrders.FormattingEnabled = true;
            this.lstReadyOrders.Location = new System.Drawing.Point(17, 59);
            this.lstReadyOrders.Name = "lstReadyOrders";
            this.lstReadyOrders.Size = new System.Drawing.Size(200, 316);
            this.lstReadyOrders.TabIndex = 1;
            // 
            // btnDeliverOrder
            // 
            this.btnDeliverOrder.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeliverOrder.Location = new System.Drawing.Point(245, 173);
            this.btnDeliverOrder.Name = "btnDeliverOrder";
            this.btnDeliverOrder.Size = new System.Drawing.Size(194, 56);
            this.btnDeliverOrder.TabIndex = 2;
            this.btnDeliverOrder.Text = "Deliver Order";
            this.btnDeliverOrder.UseVisualStyleBackColor = true;
            this.btnDeliverOrder.Click += new System.EventHandler(this.btnDeliverOrder_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(349, 377);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(90, 32);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(245, 59);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(194, 61);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // WaiterOrderReady
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 421);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeliverOrder);
            this.Controls.Add(this.lstReadyOrders);
            this.Controls.Add(this.lblReadyOrders);
            this.Name = "WaiterOrderReady";
            this.Text = "WaiterOrderReady";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReadyOrders;
        private System.Windows.Forms.ListBox lstReadyOrders;
        private System.Windows.Forms.Button btnDeliverOrder;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnRefresh;
    }
}