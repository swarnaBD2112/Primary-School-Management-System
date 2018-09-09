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
    public partial class Admit : Form
    {
        //Show_Student_Information ssi = new Show_Student_Information();
        public Admit()
        {
            InitializeComponent();
        }

        private void OnAddClick(object sender, EventArgs e)
        {

            try
            {
                
                //ssi.Show();
                #region InsertRegion
                SqlConnection conn1 = Connection_Methods.CreateConnection();
                 DateTime date = dateTimePicker1.Value.Date;
                string query = "INSERT INTO tbl_student (Student_Id, Name, Class_name, Age, Address, DOB, Gender, Gurdian_name,G_Id, RelationShip, Quata, Phone, Email, Nationality) VALUES (" + text_Studet_ID.Text + ", '" + text_Name.Text + "', '" + Class_comboBox.Text + "', " + text_Age.Text + ", '" + text_Address.Text + "', '" + date + "', '" + comboBox_gender.Text + "', '" + textBox_Gurdian.Text + "',"+ textBox_G_Id.Text+",'"+ comboBox_relationship.Text+"','"+comboBox_quata.Text+"',"+textBox_G_Phone.Text+",'"+ textBox_G_Email.Text+"','"+textBox_nationality.Text+"' )";
                SqlCommand cmd = new SqlCommand(query, conn1);
                SqlDataReader r = cmd.ExecuteReader();
                r.Close();
                MessageBox.Show("Admission Complete !!.","Confirmation",MessageBoxButtons.OK,MessageBoxIcon.Information);
                //con.Close();
             //   ShowOnDataGridView();
                Clear();
                #endregion
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show("Add your necessary data.");
            }


        }

        private void ShowOnDataGridView()
        {
            SqlConnection con = Connection_Methods.CreateConnection();

            string query = "Select * From tbl_student";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader r = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(r);
            
           // dataGridView1.DataSource = dt;

            r.Close();
        }

        private void backButtonClick(object sender, EventArgs e)
        {      
            this.Close();
            HomePage hp = new HomePage();
            hp.Show();

         
        }

        private void Clear()
        {
            text_Studet_ID.Text = null;
            text_Name.Text = null;
            Class_comboBox.Text = null;
            text_Age.Text = null;
            text_Address.Text = null;
            comboBox_gender.Text = null;
            textBox_Gurdian.Text = null;
            textBox_G_Id.Text = null;
            comboBox_relationship.Text = null;
            comboBox_quata.Text = null;
            textBox_G_Phone.Text = null;
            textBox_G_Email.Text = null;
            textBox_nationality.Text = null; 
              
            dateTimePicker1.Value = DateTime.Now;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Class_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox_G_Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Admit_Load(object sender, EventArgs e)
        {

        }

      
    }
}
