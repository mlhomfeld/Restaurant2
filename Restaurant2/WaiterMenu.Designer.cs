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
            this.btnburger = new System.Windows.Forms.Button();
            this.btncheeseBurger = new System.Windows.Forms.Button();
            this.btnmilkShake = new System.Windows.Forms.Button();
            this.btnsoftDrink = new System.Windows.Forms.Button();
            this.btnfries = new System.Windows.Forms.Button();
            this.btnsalad = new System.Windows.Forms.Button();
            this.lstOrder = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnburger
            // 
            this.btnburger.Location = new System.Drawing.Point(12, 384);
            this.btnburger.Margin = new System.Windows.Forms.Padding(2);
            this.btnburger.Name = "btnburger";
            this.btnburger.Size = new System.Drawing.Size(113, 32);
            this.btnburger.TabIndex = 2;
            this.btnburger.Text = "Burger $6";
            this.btnburger.UseVisualStyleBackColor = true;
            this.btnburger.Click += new System.EventHandler(this.btnburger_Click);
            // 
            // btncheeseBurger
            // 
            this.btncheeseBurger.Location = new System.Drawing.Point(246, 384);
            this.btncheeseBurger.Margin = new System.Windows.Forms.Padding(2);
            this.btncheeseBurger.Name = "btncheeseBurger";
            this.btncheeseBurger.Size = new System.Drawing.Size(113, 32);
            this.btncheeseBurger.TabIndex = 3;
            this.btncheeseBurger.Text = "CheeseBurger $7";
            this.btncheeseBurger.UseVisualStyleBackColor = true;
            this.btncheeseBurger.Click += new System.EventHandler(this.btncheeseBurger_Click);
            // 
            // btnmilkShake
            // 
            this.btnmilkShake.Location = new System.Drawing.Point(477, 384);
            this.btnmilkShake.Margin = new System.Windows.Forms.Padding(2);
            this.btnmilkShake.Name = "btnmilkShake";
            this.btnmilkShake.Size = new System.Drawing.Size(113, 32);
            this.btnmilkShake.TabIndex = 4;
            this.btnmilkShake.Text = "MilkShake $3.50";
            this.btnmilkShake.UseVisualStyleBackColor = true;
            this.btnmilkShake.Click += new System.EventHandler(this.btnmilkShake_Click);
            // 
            // btnsoftDrink
            // 
            this.btnsoftDrink.Location = new System.Drawing.Point(12, 429);
            this.btnsoftDrink.Margin = new System.Windows.Forms.Padding(2);
            this.btnsoftDrink.Name = "btnsoftDrink";
            this.btnsoftDrink.Size = new System.Drawing.Size(113, 32);
            this.btnsoftDrink.TabIndex = 5;
            this.btnsoftDrink.Text = "Soft Drink $1.50";
            this.btnsoftDrink.UseVisualStyleBackColor = true;
            this.btnsoftDrink.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnfries
            // 
            this.btnfries.Location = new System.Drawing.Point(246, 429);
            this.btnfries.Margin = new System.Windows.Forms.Padding(2);
            this.btnfries.Name = "btnfries";
            this.btnfries.Size = new System.Drawing.Size(113, 32);
            this.btnfries.TabIndex = 6;
            this.btnfries.Text = "Fries $2.00";
            this.btnfries.UseVisualStyleBackColor = true;
            this.btnfries.Click += new System.EventHandler(this.btnfries_Click);
            // 
            // btnsalad
            // 
            this.btnsalad.Location = new System.Drawing.Point(478, 420);
            this.btnsalad.Margin = new System.Windows.Forms.Padding(2);
            this.btnsalad.Name = "btnsalad";
            this.btnsalad.Size = new System.Drawing.Size(113, 32);
            this.btnsalad.TabIndex = 7;
            this.btnsalad.Text = "Salad $5";
            this.btnsalad.UseVisualStyleBackColor = true;
            this.btnsalad.Click += new System.EventHandler(this.btnsalad_Click);
            // 
            // lstOrder
            // 
            this.lstOrder.Location = new System.Drawing.Point(12, 277);
            this.lstOrder.Name = "lstOrder";
            this.lstOrder.Size = new System.Drawing.Size(578, 89);
            this.lstOrder.TabIndex = 1;
            this.lstOrder.UseCompatibleStateImageBehavior = false;
            // 
            // WaiterMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(602, 461);
            this.Controls.Add(this.btnsalad);
            this.Controls.Add(this.btnfries);
            this.Controls.Add(this.btnsoftDrink);
            this.Controls.Add(this.btnmilkShake);
            this.Controls.Add(this.btncheeseBurger);
            this.Controls.Add(this.btnburger);
            this.Controls.Add(this.lstOrder);
            this.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WaiterMenu";
            this.Text = "WaiterMenu";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnburger;
        private System.Windows.Forms.Button btncheeseBurger;
        private System.Windows.Forms.Button btnmilkShake;
        private System.Windows.Forms.Button btnsoftDrink;
        private System.Windows.Forms.Button btnfries;
        private System.Windows.Forms.Button btnsalad;
        private System.Windows.Forms.ListView lstOrder;
    }
}