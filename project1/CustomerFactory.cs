using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Project1
{
    class CustomerFactory
    {

        public DataSet getData(SqlConnection conn, SqlDataAdapter da, DataSet ds)
        {
            //don't forget to escape slashes
            string connString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\PROG34998\\finalProject\\Project1\\Store.mdf;Integrated Security=True;User Instance=True";
            try
            {
                conn = new SqlConnection(connString);
                conn.Open();

                string sql = "SELECT * FROM [tCustomer]";
                da = new SqlDataAdapter(sql, conn);

                ds = new DataSet();
                da.Fill(ds, "tCustomer");
                conn.Close();

            }
            catch (SqlException ex)
            {
                if (conn != null)
                {
                    conn.Close();
                }
                MessageBox.Show(ex.Message, "Error Retrieving from DataBase");
            }

            return ds;
        }

        public DataSet writeData(SqlConnection conn, SqlDataAdapter da, DataSet ds, string cid, string fn, string ln, string pc, string pn)
        {
            //don't forget to escape slashes
            string connString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\PROG34998\\finalProject\\Project1\\Store.mdf;Integrated Security=True;User Instance=True";
            try
            {
                conn = new SqlConnection(connString);
                conn.Open();

                string sql = "SELECT * FROM [tCustomer]";
                da = new SqlDataAdapter(sql, conn);

                ds = new DataSet();
                da.Fill(ds, "tCustomer");
                conn.Close();

            }
            catch (SqlException ex)
            {
                if (conn != null)
                {
                    conn.Close();
                }
                MessageBox.Show(ex.Message, "Error Retrieving from DataBase");
            }

            DataRow dr = ds.Tables["tCustomer"].NewRow();
            dr["customerId"] = cid;
            dr["firstname"] = fn;
            dr["lastname"] = ln;
            dr["postalcode"] = pc;
            dr["phone"] = pn;

            ds.Tables["tCustomer"].Rows.Add(dr);
            //removeText();

            SqlCommand cmd = new SqlCommand();
            string sql2 = "INSERT INTO [tCustomer] ([customerId], [firstname], [lastname], [postalcode], [phone]) VALUES (@cid, @fn, @ln, @pc, @pn)";
            cmd.Connection = conn;
            cmd.CommandText = sql2;
            cmd.Parameters.Add("@cid", SqlDbType.VarChar, 10, "customerId");
            cmd.Parameters.Add("@fn", SqlDbType.VarChar, 20, "firstname");
            cmd.Parameters.Add("@ln", SqlDbType.VarChar, 20, "lastname");
            cmd.Parameters.Add("@pc", SqlDbType.VarChar, 10, "postalcode");
            cmd.Parameters.Add("@pn", SqlDbType.VarChar, 15, "phone");
            da.InsertCommand = cmd;

            try
            {
                conn.Open();
                da.Update(ds, "tCustomer");
                conn.Close();
            }
            catch (SqlException ex)
            {
                if (conn != null)
                {
                    conn.Close();
                }
                MessageBox.Show(ex.Message, "Error adding to DataBase");
            }

            return ds;
        }

    }
}
