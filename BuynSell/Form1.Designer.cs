namespace BuynSell
{
    partial class Form1
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
            this.Inventory = new System.Windows.Forms.ListBox();
            this.buyButton = new System.Windows.Forms.Button();
            this.sellButton = new System.Windows.Forms.Button();
            this.Shop = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.goldBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Inventory
            // 
            this.Inventory.FormattingEnabled = true;
            this.Inventory.ItemHeight = 16;
            this.Inventory.Location = new System.Drawing.Point(239, 92);
            this.Inventory.Name = "Inventory";
            this.Inventory.Size = new System.Drawing.Size(120, 228);
            this.Inventory.TabIndex = 0;
            this.Inventory.SelectedIndexChanged += new System.EventHandler(this.Inventory_SelectedIndexChanged);
            // 
            // buyButton
            // 
            this.buyButton.Location = new System.Drawing.Point(13, 340);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(215, 98);
            this.buyButton.TabIndex = 1;
            this.buyButton.Text = "Buy";
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // sellButton
            // 
            this.sellButton.Location = new System.Drawing.Point(573, 340);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(215, 98);
            this.sellButton.TabIndex = 2;
            this.sellButton.Text = "Sell";
            this.sellButton.UseVisualStyleBackColor = true;
            this.sellButton.Click += new System.EventHandler(this.sellButton_Click);
            // 
            // Shop
            // 
            this.Shop.FormattingEnabled = true;
            this.Shop.ItemHeight = 16;
            this.Shop.Location = new System.Drawing.Point(450, 92);
            this.Shop.Name = "Shop";
            this.Shop.Size = new System.Drawing.Size(120, 228);
            this.Shop.TabIndex = 3;
            this.Shop.SelectedIndexChanged += new System.EventHandler(this.Shop_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Inventory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(529, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Shop";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Gold:";
            // 
            // goldBox
            // 
            this.goldBox.Location = new System.Drawing.Point(75, 297);
            this.goldBox.Name = "goldBox";
            this.goldBox.ReadOnly = true;
            this.goldBox.Size = new System.Drawing.Size(51, 22);
            this.goldBox.TabIndex = 7;
            this.goldBox.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.goldBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Shop);
            this.Controls.Add(this.sellButton);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.Inventory);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.Button sellButton;
        public System.Windows.Forms.ListBox Inventory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ListBox Shop;
        public System.Windows.Forms.TextBox goldBox;
    }
}

