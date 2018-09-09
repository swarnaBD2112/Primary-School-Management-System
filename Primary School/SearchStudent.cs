using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace Primary_School
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void OnSearchClick(object sender, EventArgs e)
        {
           // MessageBox.Show("This name and id is not availabl.");
            try
            {

                int match = 0;
                SqlConnection con1 = Connection_Methods.CreateConnection();
                String query1 = "select Student_Id, Name from tbl_student";
                
                SqlCommand cmd = new SqlCommand(query1, con1);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if ((reader["Student_Id"].ToString().Equals(text_search_Student_Id.Text)) && reader["Name"].ToString().Equals(text_search_name.Text))
                    {
                        match = 1;
                        break;
                    }
                }

                con1.Close();
                if (match == 1)
                {
                    if (text_search_Student_Id.Text == "" || text_search_name.Text=="" )
                    {
                        MessageBox.Show("Write The Appropriate Data");
                    }
                    else
                    {
                        SqlConnection conn = Connection_Methods.CreateConnection();
                        String query = "select * from tbl_student WHERE Student_ID='" + text_search_Student_Id.Text + "' and Name='" + text_search_name.Text + "'";
                        SqlDataAdapter ad = new SqlDataAdapter(query, conn);
                        DataTable ds = new DataTable();
                        ad.Fill(ds);
                        dataGridView_search.DataSource = ds;
                    }
                }
               
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
                
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OnBackClick(object sender, EventArgs e)
        {
        }

        private void Search_Load(object sender, EventArgs e)
        {

        }

        private void search_comboBox_SelectedValueChanged(object sender, EventArgs e)
        {
           SqlConnection con = Connection_Methods.CreateConnection();

            string query = "Select * From tbl_student Where Class_name = '" + search_comboBox.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader r = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(r);

            dataGridView_search.DataSource = dt;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            
        }

        private void Search_name_Click(object sender, EventArgs e)
        {
            try
            {

                int match = 0;
                SqlConnection con1 = Connection_Methods.CreateConnection();
                String query1 = "select Name from tbl_student";

                SqlCommand cmd = new SqlCommand(query1, con1);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (reader["Name"].ToString().Equals(text_search_name.Text))
                    {
                        match = 1;
                        break;
                    }
                }

                //  con1.Close();
                if (match == 1)
                {
                    if (text_search_Student_Id.Text == "" && text_search_name.Text == "" && search_comboBox.Text == "")
                    {
                        MessageBox.Show("Write The Appropriate Data");
                    }
                    else
                    {
                        SqlConnection conn = Connection_Methods.CreateConnection();
                        String query = "select * from tbl_student WHERE Name='" + text_search_name.Text + "'";
                        SqlDataAdapter ad = new SqlDataAdapter(query, conn);
                        DataTable ds = new DataTable();
                        ad.Fill(ds);
                        dataGridView_search.DataSource = ds;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            
        }

        private void Update_Student_Click(object sender, EventArgs e)
        {
            
 //           MessageBox.Show();
           
        }

        private void search_Id_Click(object sender, EventArgs e)
        {
            try
            {

                int match = 0;
                SqlConnection con1 = Connection_Methods.CreateConnection();
                String query1 = "select Student_Id from tbl_student";

                SqlCommand cmd = new SqlCommand(query1, con1);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (reader["Student_Id"].ToString().Equals(text_search_Student_Id.Text))
                    {
                        match = 1;
                        break;
                    }
                }

                //  con1.Close();
                if (match == 1)
                {
                    if (text_search_Student_Id.Text == "" && text_search_name.Text == "" && search_comboBox.Text == "")
                    {
                        MessageBox.Show("Write The Appropriate Data");
                    }
                    else
                    {
                        SqlConnection conn = Connection_Methods.CreateConnection();
                        String query = "select * from tbl_student WHERE Student_Id='" + text_search_Student_Id.Text + "'";
                        SqlDataAdapter ad = new SqlDataAdapter(query, conn);
                        DataTable ds = new DataTable();
                        ad.Fill(ds);
                        dataGridView_search.DataSource = ds;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void clear()
        {
            text_search_name.Text = null;
            text_search_Student_Id.Text = null;
            search_comboBox.Text = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Refresh_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = Connection_Methods.CreateConnection();
            String query = "select * from tbl_student ";
            SqlDataAdapter ad = new SqlDataAdapter(query, conn);
            DataTable ds = new DataTable();
            ad.Fill(ds);
            dataGridView_search.DataSource = ds;
        }

        private void Update_Student_Click_1(object sender, EventArgs e)
        {
            try
            {
                updateStudentForm uf = new updateStudentForm(Convert.ToInt32(dataGridView_search.SelectedRows[0].Cells[0].Value));
                this.Close();
                uf.Show();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void delete_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn1 = Connection_Methods.CreateConnection();
                String query = "delete  from tbl_student where  Name='" + text_search_name.Text + "' and Student_ID='" + text_search_Student_Id.Text + "'";
                SqlCommand cmd = new SqlCommand(query, conn1);


                MessageBox.Show("Confirm delete?", "Save Record", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            HomePage hp = new HomePage();
            hp.Show();
            
           
        }

        private void search_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
