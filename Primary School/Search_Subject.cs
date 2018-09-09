using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primary_School
{
    public partial class Search_Subject : Form
    {
        public Search_Subject()
        {
            InitializeComponent();
        }

        private void OnClickSubjectSearch(object sender, EventArgs e)
        {
            try
            {
                int match = 0;
                SqlConnection con = Connection_Methods.CreateConnection();
                String query1 = "select Subject_name, Class_name from tbl_subject";
                SqlCommand cmd = new SqlCommand(query1, con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (reader["Class_name"].ToString().Equals(class_search_comboBox.Text) && reader["Subject_name"].ToString().Equals(Sub_comboBox2.Text))
                    {
                        match = 1;
                        break;
                    }
                }
                con.Close();
                if (match == 1)
                {
                    if (class_search_comboBox.Text == "" && Sub_comboBox2.Text == "")
                    {
                        MessageBox.Show("Did not match Subject name");
                    }
                    else
                    {
                        SqlConnection conn = Connection_Methods.CreateConnection();
                        String query = "select * from tbl_subject WHERE Subject_name='" + Sub_comboBox2.Text + "'and  Class_name='" +class_search_comboBox.Text + "'";
                        SqlDataAdapter ad = new SqlDataAdapter(query, conn);
                        DataTable ds = new DataTable();
                        ad.Fill(ds);
                        dataGridViewSubject.DataSource = ds;
                    }
                }
                else
                {
                    MessageBox.Show("Did not match Subject");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OnBackSubject(object sender, EventArgs e)
        {       
            this.Close();
            HomePage hp = new HomePage();
            hp.Show();
        }
    }
}
