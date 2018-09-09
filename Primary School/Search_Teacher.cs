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
    public partial class Search_Teacher : Form
    {
        public Search_Teacher()
        {
            InitializeComponent();
        }

       

        private void OnClickTeacher(object sender, EventArgs e)
        {
            
        }
        private void OnBackClick(object sender, EventArgs e)
        {
            this.Close();
            HomePage hp = new HomePage();
            hp.Show();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
           // MessageBox.Show("No message.");
            try
            {
                int match = 0;
                SqlConnection con = Connection_Methods.CreateConnection();
                String query1 = "select Full_Name from tbl_teacher";
                SqlCommand cmd = new SqlCommand(query1, con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (reader["Full_Name"].ToString().Equals(textbox_search_teacher_name.Text))
                    {
                        match = 1;
                        break;
                    }

                }

                con.Close();
                if (match == 1)
                {
                    if (textbox_search_teacher_name.Text == "")
                    {
                        MessageBox.Show("Do not match Name");
                    }
                    else
                    {
                        SqlConnection conn = Connection_Methods.CreateConnection();
                        String query = "select Full_Name, Address, Designation, Educational_Qualification, Phone, Email from tbl_teacher WHERE  Full_Name='" + textbox_search_teacher_name.Text + "'";
                        SqlDataAdapter ad = new SqlDataAdapter(query, conn);
                        DataTable ds = new DataTable();
                        ad.Fill(ds);
                        dataGridView1_search.DataSource = ds;
                    }
                }
                else
                {
                    MessageBox.Show("Do not match Teacher Name!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           // MessageBox.Show("No messege");
        }

        private void dataGridView1_search_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Referesh_Teacher_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Connection_Methods.CreateConnection();
            String query = "select * from tbl_teacher ";
            SqlDataAdapter ad = new SqlDataAdapter(query, conn);
            DataTable ds = new DataTable();
            ad.Fill(ds);
            dataGridView1_search.DataSource = ds;
        }

        private void Delete_Teacher_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn1 = Connection_Methods.CreateConnection();
                String query = "delete  from tbl_teacher where  Full_Name='" + textbox_search_teacher_name.Text + "'";
                SqlCommand cmd = new SqlCommand(query, conn1);


                MessageBox.Show("Confirm delete?", "Save Record", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("pau pau");
            UpdateTeacherForm utf = new UpdateTeacherForm(Convert.ToInt32(dataGridView1_search.SelectedRows[0].Cells[0].Value));
            
            this.Close();
            utf.Show();
        }
        
    }
}
