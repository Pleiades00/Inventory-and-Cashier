using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharplord
{
    abstract class customer //Base class for customer to be inherited into specific type
    {
    }

    sealed class reg_cust : customer //Registered Customers 
    {
        string cust_id;
        string name;
        int contact_no;
        string address;
    }

    sealed class walk_in_cust : customer //Walk in Customers
    {

    }

    abstract class product
    {
        private string _product_id;
        private string _product_name;
        private decimal _product_price;
        private string _product_category;

        public string product_id
        {
            get
            {
                return _product_id;
            }
            set
            {
                _product_id = value;
            }
        }
        public string product_name
        {
            get
            {
                return _product_name;
            }
            set
            {
                _product_name = value;
            }
        }
        public decimal product_price
        {
            get
            {
                return _product_price;
            }
            set
            {
                _product_price = value;
            }
        }
        public string product_category
        {
            get
            {
                return _product_category;
            }
            set
            {
                _product_category = value;
            }
        }

    }
}
