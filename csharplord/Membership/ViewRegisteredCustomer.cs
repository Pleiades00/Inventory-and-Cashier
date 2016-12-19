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
    public partial class ViewRegisteredCustomer : Form
    {
        public ViewRegisteredCustomer()
        {
            InitializeComponent();
            List<reg_cust> list_reg = reg_cust.Populate();

            for (int x = 0; x < list_reg.Count(); x++)
            {
                listview_customer.Items.Add(new ListViewItem(new string[]
                {
                    list_reg[x].cust_id,
                    list_reg[x].name
                },-1));
            }
        }
    }
}
