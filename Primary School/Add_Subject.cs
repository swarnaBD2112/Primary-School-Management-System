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
    public partial class Add_Subject : Form
    {
        HomePage h = new HomePage();
        public Add_Subject()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            try
            {
                #region InsertRegion
                string cString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Binayak_Ray\Documents\PrimaryDB.mdf;Integrated Security=True;Connect Timeout=30";
                SqlConnection con = new SqlConnection(cString);
                con.Open();

               // DateTime date = dateTimePicker1.Value.Date;

                string query = "INSERT INTO tbl_subject (Subject_name, Class_name,Teacher_Id) VALUES ('" +Sub_name_comboBox.Text + "','" + Class_comboBox.Text + "','" + textBox_teacher_name.Text + "' )";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader r = cmd.ExecuteReader();
                r.Close();
                MessageBox.Show("Subject Info Saved.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //con.Close();
               // ShowOnDataGridView();
                ShowOnSubject_dataGridView();
                
                
                #endregion
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show("Add your necessary data.");
            }
        }
        private void ShowOnSubject_dataGridView()
        {
            string cString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Binayak_Ray\Documents\PrimaryDB.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection con = new SqlConnection(cString);
            con.Open();

            string query = "Select * From tbl_subject";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader r = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(r);
           // Subject_dataGridView.DataSource = dt;

            r.Close();
        }

        private void Subject_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void backSub_Click(object sender, EventArgs e)
        {
          
            this.Close();
            HomePage hp = new HomePage();
            hp.Show();
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        }
}

