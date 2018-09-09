using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//namespace Primary_School

    public class Connection_Methods
    {
        public static SqlConnection CreateConnection()
        {
            string ConnString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\3-1\4 db\4. lab\Code\PrimaryDB.mdf;Integrated Security=True;Connect Timeout=30";
            //string ConnString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\(3-1) CSE 3101 DataBase Systems\Database Project\Deaprtmental Store Sales Management\Deaprtmental Store Sales Management\Departmental Store Sales Management.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection Conn = new SqlConnection(ConnString);
            Conn.Open();
            return Conn;
        }
        public void disconnect(SqlConnection conn)
        {
            conn.Close();
        }


        public Boolean Search(string a)
        {
            int sh = 0;
            SqlConnection conn = Connection_Methods.CreateConnection();
            SqlCommand cmd = new SqlCommand(a, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            sh = dt.Rows.Count;
            if (sh != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void SaveInformation(string query)
        {
            try
            {
                SqlConnection Conn = Connection_Methods.CreateConnection();
                SqlCommand cmd = new SqlCommand(query, Conn);
                cmd.ExecuteNonQuery();
                Conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

