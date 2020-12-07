using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANHANG.DAL
{
    public class Invoice
    {
        public List<Model.Invoice> GetAllProduct()
        {
            List<Model.Invoice> invoices = new List<Model.Invoice>();
            string query = "";
            ConnectDB.DbConnection();
            SqlCommand cmd = new SqlCommand(query, ConnectDB.db);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.HasRows)
            {
                while (reader.Read())
                {
                    Model.Invoice invoice = new Model.Invoice();
                    invoice.invoice_name = reader.GetString(1);
                    invoice.customer_ID = Convert.ToInt32(reader.GetString(2));
                    invoice.shipper_ID = Convert.ToInt32(reader.GetString(3));
                    invoice.total_money = reader.GetString(4);
                    invoice.customer_address = reader["customer_address"].ToString();
                    invoices.ship_date = Convert.ToDateTime(reader["ship_date"].ToString());
                    invoices.Add(invoice);
                }
                reader.NextResult();
            }
            return invoices;
        }

        public void AddInvoice()
        {

        }
    }
}
