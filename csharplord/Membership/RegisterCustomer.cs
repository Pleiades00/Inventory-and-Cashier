using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharplord.Membership
{
    public partial class RegisterCustomer : Form
    {
        public RegisterCustomer()
        {
            InitializeComponent();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            reg_cust.Save(txt_name.Text, txt_address.Text, Convert.ToInt32(txt_contact_no.Text));
        }

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txt_contact_no_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
