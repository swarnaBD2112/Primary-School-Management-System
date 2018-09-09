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

namespace Primary_School
{
    public partial class Search_Gurdian : Form
    {
        public Search_Gurdian()
        {
            InitializeComponent();
        }

        private void Search_Gurdian_Load(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {
            try
            {

                int match = 0;
                SqlConnection con1 = Connection_Methods.CreateConnection();
                String query1 = "select Student_Id, Name,Student_Id from tbl_student";

                SqlCommand cmd = new SqlCommand(query1, con1);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if ((reader["Student_Id"].ToString().Equals(textbox2_search_gurdian.Text)) && reader["Name"].ToString().Equals(textbox1_Search_Gurdian.Text))
                    {
                        match = 1;
                        break;
                    }
                }

                con1.Close();
                if (match == 1)
                {
                    if (textbox1_Search_Gurdian.Text == "" || textbox2_search_gurdian.Text == "")
                    {
                        MessageBox.Show("Write The Appropriate Data");
                    }
                    else
                    {
                        SqlConnection conn = Connection_Methods.CreateConnection();
                        String query = "select Gurdian_name,G_Id,RelationShip,Phone from tbl_student WHERE Student_ID='" + textbox2_search_gurdian.Text + "' and Name='" + textbox1_Search_Gurdian.Text + "'";
                        SqlDataAdapter ad = new SqlDataAdapter(query, conn);
                        DataTable ds = new DataTable();
                        ad.Fill(ds);
                        dataGridView_gurdian.DataSource = ds;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            HomePage hp = new HomePage();
            hp.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
