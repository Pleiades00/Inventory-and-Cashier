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
    public partial class Form1 : Form
    {
        //decimal grand_total;

        public Form1()
        {
            InitializeComponent();
            grand_total = 0;
            
        }


        private void btn_add_item_Click(object sender, EventArgs e)
        {
            /* string newItem_name = txt_item.Text;
             int newItem_quantity = Convert.ToInt32(txt_quantity.Text);
             decimal newItem_price = Convert.ToDecimal(txt_price.Text);
             decimal newItem_subtotal = newItem_quantity * newItem_price;*/

            /*ListViewItem newItem = new ListViewItem(new string[] 
            { newItem_name,
              newItem_quantity.ToString(),
              newItem_price.ToString("0.00"),
              newItem_subtotal.ToString("0.00")
            }, -1);

            list_item.Items.Add(newItem);

            grand_total += Convert.ToDecimal(newItem_subtotal);
            txt_grand_total.Text = "RM" + grand_total.ToString("0.00");*/
        }

        private void txt_item_MouseClick(object sender, MouseEventArgs e)
        {
            txt_item.Text = "";
        }

        private void txt_quantity_MouseClick(object sender, MouseEventArgs e)
        {
            txt_quantity.Text = "";
        }

        private void txt_price_MouseClick(object sender, MouseEventArgs e)
        {
            txt_price.Text = "";
        }

        private void txt_item_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txt_quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txt_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back) e.Handled = true;
        }
    }
}
