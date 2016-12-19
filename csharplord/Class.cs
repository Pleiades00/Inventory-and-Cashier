using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace csharplord
{
    abstract class customer //Base class for customer to be inherited into specific type
    {
    }

    sealed class reg_cust : customer //Registered Customers 
    {
        string _cust_id;
        string _name;
        string address;
        int contact_no;
        string date_reg;
        int point;

        public string cust_id
        {
            get
            {
                return _cust_id;
            }
            set
            {
                _cust_id = value;
            }
        }

        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public static List<reg_cust> Populate()
        {
            using (SqlConnection con = new SqlConnection(Properties.Settings.Default.cs_sqllord))
            {
                con.Open();
                SqlDataAdapter da_Customer = new SqlDataAdapter("SELECT * FROM Customer", con);
                DataSet ds_Customer = new DataSet("Customer");
                da_Customer.FillSchema(ds_Customer, SchemaType.Source, "Customer");
                da_Customer.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                da_Customer.Fill(ds_Customer, "Customer");
                DataTable dt_Customer = ds_Customer.Tables["Customer"];
                con.Close();

                List<reg_cust> cust = new List<reg_cust>();
                foreach (DataRow dr_Customer in dt_Customer.Rows)
                {
                   

                    cust.Add(new reg_cust
                        (
                        dr_Customer["cust_id"].ToString(),
                        dr_Customer["name"].ToString(),
                        dr_Customer["address"].ToString(),
                        Convert.ToInt32(dr_Customer["contact_no"]),  
                        dr_Customer["date_registered"].ToString(),
                        Convert.ToInt32(dr_Customer["point"])
                        )
                        );
                }

                return cust;
            }
        }

        public static void RegisterNewCustomer(string CustomerName, string Address, int ContactNumber)
        {
            using (SqlConnection con = new SqlConnection(Properties.Settings.Default.cs_sqllord))
            {
                con.Open();
                SqlDataAdapter da_Customer = new SqlDataAdapter("SELECT * FROM Customer", con);
                DataSet ds_Customer = new DataSet("Customer");
                da_Customer.FillSchema(ds_Customer, SchemaType.Source, "Customer");
                da_Customer.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                da_Customer.Fill(ds_Customer, "Customer");
                con.Close();

                using (DataRow newCustomerRow = ds_Customer.Tables["Customer"].NewRow())
                {
                    newCustomerRow["cust_id"] = "C" + (ds_Customer.Tables["Customer"].Rows.Count + 1).ToString("000");
                    newCustomerRow["name"] = CustomerName;
                    newCustomerRow["address"] = Address;
                    newCustomerRow["contact_no"] = ContactNumber;
                    newCustomerRow["date_registered"] = DateTime.Now.ToString("yyyy-MM-dd");
                    newCustomerRow["point"] = 0;

                    ds_Customer.Tables["Customer"].Rows.Add(newCustomerRow);
                    
                }
            }
        }

        public reg_cust()
        { 
        }

        private reg_cust(string CustomerID, string CustomerName, string Address, int ContactNumber, string DateRegistered, int PointAccumulated)
        {
            cust_id = CustomerID;
            name = CustomerName;
            contact_no = ContactNumber;
            address = Address;
            date_reg = DateRegistered;
            point = PointAccumulated;
        }
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
