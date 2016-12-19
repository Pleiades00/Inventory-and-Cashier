namespace csharplord
{
    partial class MembershipMenu
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
            this.btn_addmember = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_viewmember = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_addmember
            // 
            this.btn_addmember.Location = new System.Drawing.Point(34, 31);
            this.btn_addmember.Name = "btn_addmember";
            this.btn_addmember.Size = new System.Drawing.Size(216, 33);
            this.btn_addmember.TabIndex = 0;
            this.btn_addmember.Text = "Add";
            this.btn_addmember.UseVisualStyleBackColor = true;
            this.btn_addmember.Click += new System.EventHandler(this.btn_addmember_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(34, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_viewmember
            // 
            this.btn_viewmember.Location = new System.Drawing.Point(34, 189);
            this.btn_viewmember.Name = "btn_viewmember";
            this.btn_viewmember.Size = new System.Drawing.Size(216, 33);
            this.btn_viewmember.TabIndex = 2;
            this.btn_viewmember.Text = "View";
            this.btn_viewmember.UseVisualStyleBackColor = true;
            this.btn_viewmember.Click += new System.EventHandler(this.btn_viewmember_Click);
            // 
            // MembershipMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_viewmember);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_addmember);
            this.Name = "MembershipMenu";
            this.Text = "Membership";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_addmember;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_viewmember;
    }
}