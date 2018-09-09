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
    public partial class Add_Gurdian : Form
    {
        HomePage h = new HomePage();
        public Add_Gurdian()
        {
            InitializeComponent();
        }

        private void Gurdian_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage hp = new HomePage();
            hp.Show();
        }

        private void Gurdian_Add_Click(object sender, EventArgs e)
        {
            try
            {
                #region InsertRegion
                string cString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Binayak_Ray\Documents\PrimaryDB.mdf;Integrated Security=True;Connect Timeout=30";
                SqlConnection con = new SqlConnection(cString);
                con.Open();

              //  DateTime date = dateTimePicker1.Value.Date;

                string query = "INSERT INTO tbl_gurdian (G_Id, Full_Name, Student_Id, Class_name, Age, Relationship, Phone, Email) VALUES (" + textBox_G_Id.Text + ", '" + textBox_G_Name.Text + "'," + textBox_St_Id.Text + ",'" + comboBox_Gurdian.Text + "'," + textBox_G_Age.Text + ", '" + textBox_RelationShip.Text + "','" + textBox_Phone.Text + "', '" + textBox_G_Email.Text + "' )";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader r = cmd.ExecuteReader();
                r.Close();
                MessageBox.Show("Gurdian Info Saved.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //con.Close();
               // ShowOnDataGridView();
                ShowDataGridView_Gurdian();
                Clear();
                #endregion
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show("Add your necessary data.");
            }
        }

        private void ShowDataGridView_Gurdian()
        {
            string cString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Binayak_Ray\Documents\PrimaryDB.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection con = new SqlConnection(cString);
            con.Open();

            string query = "Select * From tbl_gurdian";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader r = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(r);
            dataGridView_Gurdian.DataSource = dt;
            r.Close();
        }

        private void Clear()
        {
            
        }
    }
}
