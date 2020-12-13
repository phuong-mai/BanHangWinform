using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QUANLYBANHANG.Model;

namespace QUANLYBANHANG.DAL
{
    class ProductDAL
    {
        public DataTable GetAll()
        {
            string query = "select p.ID, p.Product_Name, c.Catalog_Name as catalog, p.Amount, p.Price, p.Image_Name, p.Detail " +
                "from Product as p, Catalog as c " +
                "where p.Catalog_ID=c.ID";
            ConnectDB.DbConnection();
            SqlCommand command = new SqlCommand(query, ConnectDB.db);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public Product GetProByID(string ID)
        {
            ConnectDB.DbConnection();
            string query = "select p.ID, p.Product_Name, c.Catalog_Name as catalog, p.Amount, p.Price, p.Image_Name, p.Detail " +
                "from Product p, Catalog c " +
                "where p.Catalog_ID=c.ID and p.ID=@ID";
            SqlCommand cmd = new SqlCommand(query, ConnectDB.db);
            cmd.Parameters.AddWithValue("@ID", ID);
            SqlDataReader dr = cmd.ExecuteReader();
            {
                if (dr.HasRows)
                {
                    if (dr.Read())
                    {
                        return new Product()
                        {
                            product_ID = Convert.ToInt32(dr["ID"].ToString()),
                            product_name = dr["Product_Name"].ToString(),
                            catalog_ID = Convert.ToInt32(dr["ID"].ToString()),
                            price = dr["Price"].ToString(),
                            amount = Convert.ToInt32(dr["Amount"].ToString()),
                            product_detail = dr["Detail"].ToString(),
                            img = dr["Image_Name"].ToString(),
                        };
                    }
                }
                return null;
            }
        }
        public void DeletePro(string ID)
        {
            ConnectDB.DbConnection();
            string query = "delete from product where ID = @ID";
            SqlCommand cmd = new SqlCommand(query, ConnectDB.db);
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.ExecuteNonQuery();
        }
    }
}
