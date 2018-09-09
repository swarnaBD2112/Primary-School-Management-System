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

namespace Primary_School
{
    public partial class SearchResult : Form
    {
        int p;
        public SearchResult(int p)
        {
            this.p = p;
            
            InitializeComponent();
        }

        private void On_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage hp = new HomePage();
            hp.ShowDialog();
        }

        private void On_Search_Click(object sender, EventArgs e)
        {
            
        }

        private void SearchResult_Load(object sender, EventArgs e)
        {

            if (p == 1)
            {
                panel_student.Show();
            }
            else
                panel_class.Show();

        }

        private void On_Term(object sender, EventArgs e)
        {
            SqlConnection conn = Connection_Methods.CreateConnection();
            string query = "Select * From result Where Student_Id = '" + st_textBox_Stu_ID.Text + "'and class = '"+ st_comboBox_class.Text +"' and term = '"+ st_comboBox_term.Text +"' ";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader r = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(r);
            dataGridView1.DataSource = dt;
        }

        private void cls_comboBox_class_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cls_comboBox_term_SelectedIndexChanged(object sender, EventArgs e)
        {
             if(!cls_comboBox_term.Equals("all"))
             {
                 SqlConnection conn = Connection_Methods.CreateConnection();
                 string query = "Select * From result Where class = '" + cls_comboBox_class.Text + "'and term = '" + cls_comboBox_term.Text + "'  ";
                 SqlCommand cmd = new SqlCommand(query, conn);
                 SqlDataReader r = cmd.ExecuteReader();

                 DataTable dt = new DataTable();
                 dt.Load(r);
                 dataGridView1.DataSource = dt;
             }
             else if(cls_comboBox_term.Equals("All"))
             {
                 MessageBox.Show("oppa");
                 SqlConnection conn = Connection_Methods.CreateConnection();
                 string query1 = "Select * From result as S , result as T  Where class = '" + cls_comboBox_class.Text + "'and S.Student_Id = T.Student_Id " ;
                 SqlCommand cmd = new SqlCommand(query1, conn);
                 SqlDataReader r = cmd.ExecuteReader();
                 DataTable dt1 = new DataTable();
                 dt1.Load(r);
                 dataGridView1.DataSource = dt1;
             }

        }
    }
}
