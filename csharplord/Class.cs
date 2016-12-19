using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Data;


namespace csharplord
{
    
    abstract class customer //Base class for customer to be inherited into specific type
    {
    }


    class reg_cust : customer //Registered Customers 
    {
        public string cust_id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public int contact_no { get; set; }
        public string date_reg { get; set; }
        public int point { get; set; }

        public static List<DataRow> Get()
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
                return ds_Customer.Tables["Customer"].AsEnumerable().ToList();
            }
        }

       
        public static void Save(string CustomerName, string Address, int ContactNumber)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Properties.Settings.Default.cs_sqllord))
                {
                    using (SqlCommand cmd = new SqlCommand("InsertCustomer", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@name", CustomerName);
                        cmd.Parameters.AddWithValue("@address", Address);
                        cmd.Parameters.AddWithValue("@contact_no", ContactNumber);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Delete(string CustomerID)
        {

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
