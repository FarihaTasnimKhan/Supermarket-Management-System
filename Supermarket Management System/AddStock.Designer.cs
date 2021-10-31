namespace Supermarket_Management_System
{
    partial class AddStock
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.totalcost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.quantitytextbox = new System.Windows.Forms.TextBox();
            this.quantity = new System.Windows.Forms.Label();
            this.item = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.stockcategory = new System.Windows.Forms.ComboBox();
            this.stockCat = new System.Windows.Forms.Label();
            this.refresh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.refresh);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.totalcost);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.price);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.add);
            this.groupBox1.Controls.Add(this.quantitytextbox);
            this.groupBox1.Controls.Add(this.quantity);
            this.groupBox1.Controls.Add(this.item);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.stockcategory);
            this.groupBox1.Controls.Add(this.stockCat);
            this.groupBox1.Location = new System.Drawing.Point(8, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(780, 453);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(200, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 66);
            this.button1.TabIndex = 19;
            this.button1.Text = "ADD TO EXISTING STOCK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // totalcost
            // 
            this.totalcost.Location = new System.Drawing.Point(167, 193);
            this.totalcost.Name = "totalcost";
            this.totalcost.Size = new System.Drawing.Size(160, 20);
            this.totalcost.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(6, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Total Cost";
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(167, 153);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(160, 20);
            this.price.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(6, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Price/Unit";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(411, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(363, 377);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(692, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 27);
            this.button2.TabIndex = 13;
            this.button2.Text = "BACK";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(4, 263);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(162, 66);
            this.add.TabIndex = 12;
            this.add.Text = "INTRODUCE/ ADD A NEW ITEM";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // quantitytextbox
            // 
            this.quantitytextbox.Location = new System.Drawing.Point(167, 110);
            this.quantitytextbox.Name = "quantitytextbox";
            this.quantitytextbox.Size = new System.Drawing.Size(160, 20);
            this.quantitytextbox.TabIndex = 11;
            // 
            // quantity
            // 
            this.quantity.AutoSize = true;
            this.quantity.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.quantity.Font = new System.Drawing.Font("Arial Narrow", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.quantity.Location = new System.Drawing.Point(6, 110);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(61, 20);
            this.quantity.TabIndex = 10;
            this.quantity.Text = "Quantity";
            // 
            // item
            // 
            this.item.Location = new System.Drawing.Point(167, 70);
            this.item.Name = "item";
            this.item.Size = new System.Drawing.Size(160, 20);
            this.item.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(6, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name of Item";
            // 
            // stockcategory
            // 
            this.stockcategory.FormattingEnabled = true;
            this.stockcategory.Items.AddRange(new object[] {
            "Cooking Essentials",
            "Fruit and Vegetables",
            "Meat and Fish",
            "Sauce and Pickles",
            "Snacks and Instant Food",
            "Chocolate and Candies",
            "Baking Needs",
            "Bread,Biscuit and Cakes",
            "Dairy",
            "Beverage",
            "Baby Food and Care",
            "Home Care and Cleaning",
            "Stationary",
            "Gift and Toys",
            "Pet Care"});
            this.stockcategory.Location = new System.Drawing.Point(167, 29);
            this.stockcategory.Name = "stockcategory";
            this.stockcategory.Size = new System.Drawing.Size(160, 21);
            this.stockcategory.TabIndex = 7;
            // 
            // stockCat
            // 
            this.stockCat.AutoSize = true;
            this.stockCat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stockCat.Font = new System.Drawing.Font("Arial Narrow", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockCat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.stockCat.Location = new System.Drawing.Point(6, 29);
            this.stockCat.Name = "stockCat";
            this.stockCat.Size = new System.Drawing.Size(101, 20);
            this.stockCat.TabIndex = 6;
            this.stockCat.Text = "Stock Category";
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.Location = new System.Drawing.Point(575, 10);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(95, 27);
            this.refresh.TabIndex = 20;
            this.refresh.Text = "REFRESH";
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // AddStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Supermarket_Management_System.Properties.Resources.stock8;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddStock";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddStock_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox stockcategory;
        private System.Windows.Forms.Label stockCat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox quantitytextbox;
        private System.Windows.Forms.Label quantity;
        private System.Windows.Forms.TextBox item;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox totalcost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button refresh;
    }
}