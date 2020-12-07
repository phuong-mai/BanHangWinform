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
    class CustomerDAL
    {
        public DataTable GetAll()
        {
            string query = "select id, username, password, phoneNumber, birthDate, address, joinDate,gender, firstName + ' ' + lastName as name from customer";
            ConnectDB.DbConnection();
            SqlCommand command = new SqlCommand(query, ConnectDB.db);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public Customer GetCusByID(string ID)
        {
            ConnectDB.DbConnection();
            string query = "Select * from customer where ID=@ID";
            SqlCommand cmd = new SqlCommand(query, ConnectDB.db);
            cmd.Parameters.AddWithValue("@ID", ID);
            SqlDataReader dr = cmd.ExecuteReader();
            {
                if (dr.HasRows)
                {
                    if (dr.Read())
                    {
                        return new Customer()
                        {
                            ID = Convert.ToInt32(dr["ID"].ToString()),
                            username = dr["username"].ToString(),
                            password = dr["password"].ToString(),
                            firstName = dr["firstName"].ToString(),
                            lastName = dr["lastName"].ToString(),
                            gender = dr["gender"].ToString(),
                            birthDate = Convert.ToDateTime(dr["birthDate"].ToString()),
                            joinDate = Convert.ToDateTime(dr["joinDate"].ToString()),
                            address = dr["address"].ToString()
                        };
                    }
                }
                return null;
            }
        }
        public void UpdateCus(Customer customer)
        {
            ConnectDB.DbConnection();
            string query = "update customer set firstName =@firstName, lastName =@lastName, gender =@gender, birthDate =@birthDate, address = @address where ID = @ID";
            SqlCommand cmd = new SqlCommand(query, ConnectDB.db);
            cmd.Parameters.AddWithValue("firstName", customer.firstName);
            cmd.Parameters.AddWithValue("lastName", customer.lastName);
            cmd.Parameters.AddWithValue("gender", customer.gender);
            cmd.Parameters.AddWithValue("birthDate", customer.birthDate);
            cmd.Parameters.AddWithValue("address", customer.address);
            cmd.Parameters.AddWithValue("ID", customer.ID);
            cmd.ExecuteNonQuery();
        }
        public void DeleteCus(string ID)
        {
            ConnectDB.DbConnection();
            string query = "delete from customer where ID = @ID";
            SqlCommand cmd = new SqlCommand(query, ConnectDB.db);
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.ExecuteNonQuery();
        }
    }
}
