namespace csharplord
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.list_item = new System.Windows.Forms.ListView();
            this.item = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sub_total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_item = new System.Windows.Forms.TextBox();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.btn_add_item = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_grand_total = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.list_item);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 313);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item List";
            // 
            // list_item
            // 
            this.list_item.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.list_item.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.item,
            this.quantity,
            this.price,
            this.sub_total});
            this.list_item.FullRowSelect = true;
            this.list_item.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.list_item.Location = new System.Drawing.Point(6, 19);
            this.list_item.Name = "list_item";
            this.list_item.Size = new System.Drawing.Size(329, 288);
            this.list_item.TabIndex = 0;
            this.list_item.UseCompatibleStateImageBehavior = false;
            this.list_item.View = System.Windows.Forms.View.Details;
            // 
            // item
            // 
            this.item.Text = "Item";
            this.item.Width = 117;
            // 
            // quantity
            // 
            this.quantity.Text = "Quantity";
            // 
            // price
            // 
            this.price.Text = "Price (RM)";
            this.price.Width = 70;
            // 
            // sub_total
            // 
            this.sub_total.Text = "Sub-total (RM)";
            this.sub_total.Width = 80;
            // 
            // txt_item
            // 
            this.txt_item.Location = new System.Drawing.Point(375, 31);
            this.txt_item.Name = "txt_item";
            this.txt_item.Size = new System.Drawing.Size(100, 20);
            this.txt_item.TabIndex = 2;
            this.txt_item.Text = "Item Name";
            this.txt_item.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_item_MouseClick);
            this.txt_item.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_item_KeyPress);
            // 
            // txt_quantity
            // 
            this.txt_quantity.Location = new System.Drawing.Point(375, 69);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(100, 20);
            this.txt_quantity.TabIndex = 3;
            this.txt_quantity.Text = "Quantity";
            this.txt_quantity.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_quantity_MouseClick);
            this.txt_quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_quantity_KeyPress);
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(375, 108);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(100, 20);
            this.txt_price.TabIndex = 4;
            this.txt_price.Text = "Item Price";
            this.txt_price.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_price_MouseClick);
            this.txt_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_price_KeyPress);
            // 
            // btn_add_item
            // 
            this.btn_add_item.Location = new System.Drawing.Point(375, 149);
            this.btn_add_item.Name = "btn_add_item";
            this.btn_add_item.Size = new System.Drawing.Size(75, 23);
            this.btn_add_item.TabIndex = 5;
            this.btn_add_item.Text = "Add Item";
            this.btn_add_item.UseVisualStyleBackColor = true;
            this.btn_add_item.Click += new System.EventHandler(this.btn_add_item_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 15.75F);
            this.label1.Location = new System.Drawing.Point(15, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Grand Total:";
            // 
            // txt_grand_total
            // 
            this.txt_grand_total.AutoSize = true;
            this.txt_grand_total.Font = new System.Drawing.Font("Cambria", 15.75F);
            this.txt_grand_total.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.txt_grand_total.Location = new System.Drawing.Point(194, 328);
            this.txt_grand_total.Name = "txt_grand_total";
            this.txt_grand_total.Size = new System.Drawing.Size(159, 25);
            this.txt_grand_total.TabIndex = 7;
            this.txt_grand_total.Text = "RM 9999999.00";
            this.txt_grand_total.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 366);
            this.Controls.Add(this.txt_grand_total);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_add_item);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.txt_item);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView list_item;
        private System.Windows.Forms.ColumnHeader item;
        private System.Windows.Forms.ColumnHeader quantity;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader sub_total;
        private System.Windows.Forms.TextBox txt_item;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Button btn_add_item;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txt_grand_total;
    }
}

