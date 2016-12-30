using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharplord
{
    public partial class MembershipMenu : Form
    {
        public MembershipMenu()
        {
            InitializeComponent();
        }

        private void btn_addmember_Click(object sender, EventArgs e)
        {
            Membership.RegisterCustomer reg = new Membership.RegisterCustomer();
            reg.Show();
        }

        private void btn_viewmember_Click(object sender, EventArgs e)
        {
            Membership.ViewRegisteredCustomer view = new Membership.ViewRegisteredCustomer();
            view.Show();
        }
    }
}
