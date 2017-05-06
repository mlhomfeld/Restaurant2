namespace Restaurant2
{
    partial class WaiterMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WaiterMenu));
            this.btnBurger = new System.Windows.Forms.Button();
            this.btnCheeseburger = new System.Windows.Forms.Button();
            this.btnMilkshake = new System.Windows.Forms.Button();
            this.btnSoftDrink = new System.Windows.Forms.Button();
            this.btnFries = new System.Windows.Forms.Button();
            this.btnSalad = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnSubmitOrder = new System.Windows.Forms.Button();
            this.lblCurrentOrder = new System.Windows.Forms.Label();
            this.lstOrder = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnBurger
            // 
            this.btnBurger.Location = new System.Drawing.Point(288, 64);
            this.btnBurger.Margin = new System.Windows.Forms.Padding(2);
            this.btnBurger.Name = "btnBurger";
            this.btnBurger.Size = new System.Drawing.Size(145, 59);
            this.btnBurger.TabIndex = 2;
            this.btnBurger.Text = "Burger $6.00";
            this.btnBurger.UseVisualStyleBackColor = true;
            this.btnBurger.Click += new System.EventHandler(this.btnBurger_Click);
            // 
            // btnCheeseburger
            // 
            this.btnCheeseburger.Location = new System.Drawing.Point(454, 64);
            this.btnCheeseburger.Margin = new System.Windows.Forms.Padding(2);
            this.btnCheeseburger.Name = "btnCheeseburger";
            this.btnCheeseburger.Size = new System.Drawing.Size(136, 59);
            this.btnCheeseburger.TabIndex = 3;
            this.btnCheeseburger.Text = "CheeseBurger $7.00";
            this.btnCheeseburger.UseVisualStyleBackColor = true;
            this.btnCheeseburger.Click += new System.EventHandler(this.btnCheeseburger_Click);
            // 
            // btnMilkshake
            // 
            this.btnMilkshake.Location = new System.Drawing.Point(288, 154);
            this.btnMilkshake.Margin = new System.Windows.Forms.Padding(2);
            this.btnMilkshake.Name = "btnMilkshake";
            this.btnMilkshake.Size = new System.Drawing.Size(145, 56);
            this.btnMilkshake.TabIndex = 4;
            this.btnMilkshake.Text = "MilkShake $3.50";
            this.btnMilkshake.UseVisualStyleBackColor = true;
            this.btnMilkshake.Click += new System.EventHandler(this.btnMilkshake_Click);
            // 
            // btnSoftDrink
            // 
            this.btnSoftDrink.Location = new System.Drawing.Point(454, 154);
            this.btnSoftDrink.Margin = new System.Windows.Forms.Padding(2);
            this.btnSoftDrink.Name = "btnSoftDrink";
            this.btnSoftDrink.Size = new System.Drawing.Size(136, 56);
            this.btnSoftDrink.TabIndex = 5;
            this.btnSoftDrink.Text = "Soft Drink $1.50";
            this.btnSoftDrink.UseVisualStyleBackColor = true;
            this.btnSoftDrink.Click += new System.EventHandler(this.btnSoftDrink_Click);
            // 
            // btnFries
            // 
            this.btnFries.Location = new System.Drawing.Point(288, 236);
            this.btnFries.Margin = new System.Windows.Forms.Padding(2);
            this.btnFries.Name = "btnFries";
            this.btnFries.Size = new System.Drawing.Size(145, 54);
            this.btnFries.TabIndex = 6;
            this.btnFries.Text = "Fries $2.00";
            this.btnFries.UseVisualStyleBackColor = true;
            this.btnFries.Click += new System.EventHandler(this.btnFries_Click);
            // 
            // btnSalad
            // 
            this.btnSalad.Location = new System.Drawing.Point(454, 236);
            this.btnSalad.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalad.Name = "btnSalad";
            this.btnSalad.Size = new System.Drawing.Size(136, 54);
            this.btnSalad.TabIndex = 7;
            this.btnSalad.Text = "Salad $5.00";
            this.btnSalad.UseVisualStyleBackColor = true;
            this.btnSalad.Click += new System.EventHandler(this.btnSalad_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.BackColor = System.Drawing.Color.IndianRed;
            this.btnRemoveItem.Location = new System.Drawing.Point(382, 325);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(125, 52);
            this.btnRemoveItem.TabIndex = 8;
            this.btnRemoveItem.Text = "Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = false;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnSubmitOrder
            // 
            this.btnSubmitOrder.Location = new System.Drawing.Point(382, 398);
            this.btnSubmitOrder.Name = "btnSubmitOrder";
            this.btnSubmitOrder.Size = new System.Drawing.Size(125, 51);
            this.btnSubmitOrder.TabIndex = 9;
            this.btnSubmitOrder.Text = "Submit Order";
            this.btnSubmitOrder.UseVisualStyleBackColor = true;
            this.btnSubmitOrder.Click += new System.EventHandler(this.btnSubmitOrder_Click);
            // 
            // lblCurrentOrder
            // 
            this.lblCurrentOrder.AutoSize = true;
            this.lblCurrentOrder.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentOrder.Location = new System.Drawing.Point(12, 33);
            this.lblCurrentOrder.Name = "lblCurrentOrder";
            this.lblCurrentOrder.Size = new System.Drawing.Size(125, 21);
            this.lblCurrentOrder.TabIndex = 10;
            this.lblCurrentOrder.Text = "Current Order :";
            // 
            // lstOrder
            // 
            this.lstOrder.FormattingEnabled = true;
            this.lstOrder.ItemHeight = 15;
            this.lstOrder.Location = new System.Drawing.Point(13, 64);
            this.lstOrder.Name = "lstOrder";
            this.lstOrder.Size = new System.Drawing.Size(247, 364);
            this.lstOrder.TabIndex = 11;
            // 
            // WaiterMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(602, 461);
            this.Controls.Add(this.lstOrder);
            this.Controls.Add(this.lblCurrentOrder);
            this.Controls.Add(this.btnSubmitOrder);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnSalad);
            this.Controls.Add(this.btnFries);
            this.Controls.Add(this.btnSoftDrink);
            this.Controls.Add(this.btnMilkshake);
            this.Controls.Add(this.btnCheeseburger);
            this.Controls.Add(this.btnBurger);
            this.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WaiterMenu";
            this.Text = "WaiterMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBurger;
        private System.Windows.Forms.Button btnCheeseburger;
        private System.Windows.Forms.Button btnMilkshake;
        private System.Windows.Forms.Button btnSoftDrink;
        private System.Windows.Forms.Button btnFries;
        private System.Windows.Forms.Button btnSalad;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnSubmitOrder;
        private System.Windows.Forms.Label lblCurrentOrder;
        private System.Windows.Forms.ListBox lstOrder;
    }
}