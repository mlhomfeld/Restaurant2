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
            this.lstOrder = new System.Windows.Forms.ListView();
            this.btnburger = new System.Windows.Forms.Button();
            this.btncheeseBurger = new System.Windows.Forms.Button();
            this.btnmilkShake = new System.Windows.Forms.Button();
            this.btnsoftDrink = new System.Windows.Forms.Button();
            this.btnfries = new System.Windows.Forms.Button();
            this.btnsalad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstOrder
            // 
            this.lstOrder.Location = new System.Drawing.Point(12, 12);
            this.lstOrder.Name = "lstOrder";
            this.lstOrder.Size = new System.Drawing.Size(174, 313);
            this.lstOrder.TabIndex = 1;
            this.lstOrder.UseCompatibleStateImageBehavior = false;
            // 
            // btnburger
            // 
            this.btnburger.Location = new System.Drawing.Point(222, 24);
            this.btnburger.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnburger.Name = "btnburger";
            this.btnburger.Size = new System.Drawing.Size(97, 28);
            this.btnburger.TabIndex = 2;
            this.btnburger.Text = "Burger $6";
            this.btnburger.UseVisualStyleBackColor = true;
            this.btnburger.Click += new System.EventHandler(this.btnburger_Click);
            // 
            // btncheeseBurger
            // 
            this.btncheeseBurger.Location = new System.Drawing.Point(222, 81);
            this.btncheeseBurger.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btncheeseBurger.Name = "btncheeseBurger";
            this.btncheeseBurger.Size = new System.Drawing.Size(97, 28);
            this.btncheeseBurger.TabIndex = 3;
            this.btncheeseBurger.Text = "CheeseBurger $7";
            this.btncheeseBurger.UseVisualStyleBackColor = true;
            // 
            // btnmilkShake
            // 
            this.btnmilkShake.Location = new System.Drawing.Point(222, 137);
            this.btnmilkShake.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnmilkShake.Name = "btnmilkShake";
            this.btnmilkShake.Size = new System.Drawing.Size(97, 28);
            this.btnmilkShake.TabIndex = 4;
            this.btnmilkShake.Text = "MilkShake $3.50";
            this.btnmilkShake.UseVisualStyleBackColor = true;
            // 
            // btnsoftDrink
            // 
            this.btnsoftDrink.Location = new System.Drawing.Point(222, 189);
            this.btnsoftDrink.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnsoftDrink.Name = "btnsoftDrink";
            this.btnsoftDrink.Size = new System.Drawing.Size(97, 28);
            this.btnsoftDrink.TabIndex = 5;
            this.btnsoftDrink.Text = "Soft Drink $1.50";
            this.btnsoftDrink.UseVisualStyleBackColor = true;
            this.btnsoftDrink.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnfries
            // 
            this.btnfries.Location = new System.Drawing.Point(222, 242);
            this.btnfries.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnfries.Name = "btnfries";
            this.btnfries.Size = new System.Drawing.Size(97, 28);
            this.btnfries.TabIndex = 6;
            this.btnfries.Text = "Fries $2.00";
            this.btnfries.UseVisualStyleBackColor = true;
            // 
            // btnsalad
            // 
            this.btnsalad.Location = new System.Drawing.Point(222, 297);
            this.btnsalad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnsalad.Name = "btnsalad";
            this.btnsalad.Size = new System.Drawing.Size(97, 28);
            this.btnsalad.TabIndex = 7;
            this.btnsalad.Text = "Salad $5";
            this.btnsalad.UseVisualStyleBackColor = true;
            // 
            // WaiterMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 337);
            this.Controls.Add(this.btnsalad);
            this.Controls.Add(this.btnfries);
            this.Controls.Add(this.btnsoftDrink);
            this.Controls.Add(this.btnmilkShake);
            this.Controls.Add(this.btncheeseBurger);
            this.Controls.Add(this.btnburger);
            this.Controls.Add(this.lstOrder);
            this.Name = "WaiterMenu";
            this.Text = "WaiterMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstOrder;
        private System.Windows.Forms.Button btnburger;
        private System.Windows.Forms.Button btncheeseBurger;
        private System.Windows.Forms.Button btnmilkShake;
        private System.Windows.Forms.Button btnsoftDrink;
        private System.Windows.Forms.Button btnfries;
        private System.Windows.Forms.Button btnsalad;
    }
}