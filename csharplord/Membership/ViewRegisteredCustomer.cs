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

namespace csharplord.Membership
{
    public partial class ViewRegisteredCustomer : Form
    {
        public ViewRegisteredCustomer()
        {
            InitializeComponent();
            foreach (reg_cust rg in reg_cust.Get())
            {
                listview_customer.Items.Add(new ListViewItem(new string[]
                {
                    rg.cust_id.ToString(),  
                    rg.name.ToString(),
                    rg.address.ToString(),
                    rg.contact_no.ToString(),
                    rg.date_reg.ToString(),
                    rg.point.ToString()
                }, -1));
            }

            for (int x = 0; x < listview_customer.Columns.Count; x++)
            {
                listview_customer.Columns[x].Width = -2;
            }
        }

            
    }
    
}
