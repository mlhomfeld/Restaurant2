namespace Restaurant2
{
    partial class WaiterForm
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
            this.btnTableOne = new System.Windows.Forms.Button();
            this.btnTableThree = new System.Windows.Forms.Button();
            this.btnTableTwo = new System.Windows.Forms.Button();
            this.btnTableFour = new System.Windows.Forms.Button();
            this.btnTableFive = new System.Windows.Forms.Button();
            this.btnTableSix = new System.Windows.Forms.Button();
            this.btnTableSeven = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTableOne
            // 
            this.btnTableOne.Location = new System.Drawing.Point(40, 61);
            this.btnTableOne.Name = "btnTableOne";
            this.btnTableOne.Size = new System.Drawing.Size(94, 50);
            this.btnTableOne.TabIndex = 0;
            this.btnTableOne.Text = "Table 1";
            this.btnTableOne.UseVisualStyleBackColor = true;
            this.btnTableOne.Click += new System.EventHandler(this.btnTableOne_Click);
            // 
            // btnTableThree
            // 
            this.btnTableThree.Location = new System.Drawing.Point(164, 61);
            this.btnTableThree.Name = "btnTableThree";
            this.btnTableThree.Size = new System.Drawing.Size(91, 50);
            this.btnTableThree.TabIndex = 1;
            this.btnTableThree.Text = "Table 3";
            this.btnTableThree.UseVisualStyleBackColor = true;
            // 
            // btnTableTwo
            // 
            this.btnTableTwo.Location = new System.Drawing.Point(40, 159);
            this.btnTableTwo.Name = "btnTableTwo";
            this.btnTableTwo.Size = new System.Drawing.Size(94, 57);
            this.btnTableTwo.TabIndex = 2;
            this.btnTableTwo.Text = "Table 2";
            this.btnTableTwo.UseVisualStyleBackColor = true;
            // 
            // btnTableFour
            // 
            this.btnTableFour.Location = new System.Drawing.Point(164, 159);
            this.btnTableFour.Name = "btnTableFour";
            this.btnTableFour.Size = new System.Drawing.Size(91, 57);
            this.btnTableFour.TabIndex = 3;
            this.btnTableFour.Text = "Table 4";
            this.btnTableFour.UseVisualStyleBackColor = true;
            // 
            // btnTableFive
            // 
            this.btnTableFive.Location = new System.Drawing.Point(335, 31);
            this.btnTableFive.Name = "btnTableFive";
            this.btnTableFive.Size = new System.Drawing.Size(93, 55);
            this.btnTableFive.TabIndex = 4;
            this.btnTableFive.Text = "Table 5";
            this.btnTableFive.UseVisualStyleBackColor = true;
            // 
            // btnTableSix
            // 
            this.btnTableSix.Location = new System.Drawing.Point(335, 129);
            this.btnTableSix.Name = "btnTableSix";
            this.btnTableSix.Size = new System.Drawing.Size(93, 47);
            this.btnTableSix.TabIndex = 5;
            this.btnTableSix.Text = "Table 6";
            this.btnTableSix.UseVisualStyleBackColor = true;
            // 
            // btnTableSeven
            // 
            this.btnTableSeven.Location = new System.Drawing.Point(335, 224);
            this.btnTableSeven.Name = "btnTableSeven";
            this.btnTableSeven.Size = new System.Drawing.Size(93, 46);
            this.btnTableSeven.TabIndex = 6;
            this.btnTableSeven.Text = "Table 7";
            this.btnTableSeven.UseVisualStyleBackColor = true;
            // 
            // WaiterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 307);
            this.Controls.Add(this.btnTableSeven);
            this.Controls.Add(this.btnTableSix);
            this.Controls.Add(this.btnTableFive);
            this.Controls.Add(this.btnTableFour);
            this.Controls.Add(this.btnTableTwo);
            this.Controls.Add(this.btnTableThree);
            this.Controls.Add(this.btnTableOne);
            this.Name = "WaiterForm";
            this.Text = "WaiterForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTableOne;
        private System.Windows.Forms.Button btnTableThree;
        private System.Windows.Forms.Button btnTableTwo;
        private System.Windows.Forms.Button btnTableFour;
        private System.Windows.Forms.Button btnTableFive;
        private System.Windows.Forms.Button btnTableSix;
        private System.Windows.Forms.Button btnTableSeven;
    }
}