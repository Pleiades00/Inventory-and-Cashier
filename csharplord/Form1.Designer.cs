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
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_add_item = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_grand_total = new System.Windows.Forms.Label();
            this.btnSnack = new System.Windows.Forms.Button();
            this.btnDrinks = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.list_item);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 284);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item List";
            // 
            // list_item
            // 
            this.list_item.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.list_item.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.item,
            this.price});
            this.list_item.FullRowSelect = true;
            this.list_item.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.list_item.Location = new System.Drawing.Point(6, 19);
            this.list_item.Name = "list_item";
            this.list_item.Size = new System.Drawing.Size(329, 288);
            this.list_item.TabIndex = 0;
            this.list_item.UseCompatibleStateImageBehavior = false;
            this.list_item.View = System.Windows.Forms.View.Details;
            this.list_item.SelectedIndexChanged += new System.EventHandler(this.list_item_SelectedIndexChanged);
            // 
            // item
            // 
            this.item.Text = "Item";
            this.item.Width = 244;
            // 
            // price
            // 
            this.price.Text = "Price (RM)";
            this.price.Width = 70;
            // 
            // btn_add_item
            // 
            this.btn_add_item.Location = new System.Drawing.Point(476, 12);
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
            // btnSnack
            // 
            this.btnSnack.Location = new System.Drawing.Point(18, 12);
            this.btnSnack.Name = "btnSnack";
            this.btnSnack.Size = new System.Drawing.Size(75, 23);
            this.btnSnack.TabIndex = 8;
            this.btnSnack.Text = "Snack";
            this.btnSnack.UseVisualStyleBackColor = true;
            this.btnSnack.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDrinks
            // 
            this.btnDrinks.Location = new System.Drawing.Point(129, 12);
            this.btnDrinks.Name = "btnDrinks";
            this.btnDrinks.Size = new System.Drawing.Size(75, 23);
            this.btnDrinks.TabIndex = 9;
            this.btnDrinks.Text = "Drinks";
            this.btnDrinks.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(237, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Diaries";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDrinks);
            this.Controls.Add(this.btnSnack);
            this.Controls.Add(this.txt_grand_total);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_add_item);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView list_item;
        private System.Windows.Forms.ColumnHeader item;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.Button btn_add_item;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txt_grand_total;
        private System.Windows.Forms.Button btnSnack;
        private System.Windows.Forms.Button btnDrinks;
        private System.Windows.Forms.Button button1;
    }
}

