namespace csharplord.Membership
{
    partial class ViewRegisteredCustomer
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
            this.listview_customer = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contact = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date_registered = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.point = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cust_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listview_customer
            // 
            this.listview_customer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cust_id,
            this.name,
            this.address,
            this.contact,
            this.date_registered,
            this.point});
            this.listview_customer.FullRowSelect = true;
            this.listview_customer.Location = new System.Drawing.Point(12, 4);
            this.listview_customer.Name = "listview_customer";
            this.listview_customer.Size = new System.Drawing.Size(768, 575);
            this.listview_customer.TabIndex = 0;
            this.listview_customer.UseCompatibleStateImageBehavior = false;
            this.listview_customer.View = System.Windows.Forms.View.Details;
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 56;
            // 
            // address
            // 
            this.address.Text = "Address";
            this.address.Width = 50;
            // 
            // contact
            // 
            this.contact.Text = "Contact";
            this.contact.Width = 49;
            // 
            // date_registered
            // 
            this.date_registered.Text = "Date Registered";
            this.date_registered.Width = 105;
            // 
            // point
            // 
            this.point.Text = "Point Accmulated";
            this.point.Width = 446;
            // 
            // cust_id
            // 
            this.cust_id.Text = "ID";
            this.cust_id.Width = 44;
            // 
            // ViewRegisteredCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(792, 582);
            this.Controls.Add(this.listview_customer);
            this.Name = "ViewRegisteredCustomer";
            this.Text = "ViewRegisteredCustomer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listview_customer;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader address;
        private System.Windows.Forms.ColumnHeader contact;
        private System.Windows.Forms.ColumnHeader date_registered;
        private System.Windows.Forms.ColumnHeader point;
        private System.Windows.Forms.ColumnHeader cust_id;
    }
}