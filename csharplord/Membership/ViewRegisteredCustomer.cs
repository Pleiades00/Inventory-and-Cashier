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
            foreach (DataRow dr in reg_cust.Get())
            {
                listview_customer.Items.Add(new ListViewItem(new string[]
                {
                    dr[0].ToString(), 
                    dr[1].ToString(),
                    dr[2].ToString(),
                    dr[3].ToString(),
                    dr[4].ToString(),
                    dr[5].ToString()
                }, -1));
            }

            for (int x = 0; x < listview_customer.Columns.Count; x++)
            {
                listview_customer.Columns[x].Width = -2;
            }
        }

            
    }
    
}
