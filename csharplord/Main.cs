using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharplord
{
    public partial class Main : Form
    {
        decimal grand_total;

        public Main()
        {
            InitializeComponent();
            grand_total = 0;

        }

        private void Main_Load(object sender, EventArgs e)
        {
            txt_grand_total.Text = "RM" + grand_total.ToString("0.00");
        }

        private void btn_member_Click(object sender, EventArgs e)
        {
            MembershipMenu member = new MembershipMenu();
            member.Show();
        }

        private void list_item_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
