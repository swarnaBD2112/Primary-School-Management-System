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
    public partial class NewTeacher : Form
    {
        public NewTeacher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void OnBackClick(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
       /* private void ShowOnDataGridView()
        {
          
            string cString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Binayak_Ray\Documents\PrimaryDB.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection con = new SqlConnection(cString);
            con.Open();

            string query = "Select * From tbl_teacher";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader r = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(r);
            dataGridView1.DataSource = dt;

            r.Close();
        }*/
        private void Clear()
        {
            textbox_Techer_ID.Text = null;
            textbox_Name.Text = null;
            textbox_Age.Text = null;
            textbox_Address = null;
            textbox_Designation = null;
            textbox_salary = null;
            textbox_Phone = null;
            textbox_Email = null;

            dateTimePicker2.Value = DateTime.Now;
        }

        private void OnOKClick(object sender, EventArgs e)
        {

            try
            {
                #region InsertRegion
                SqlConnection con = Connection_Methods.CreateConnection();

                DateTime date = dateTimePicker2.Value.Date;

                string query = "INSERT INTO tbl_teacher (Teacher_Id, Full_Name, Age, Address, Date_Of_Birth, Designation , Salary ,Educational_Qualification, Phone,Email) VALUES (" + textbox_Techer_ID.Text + ", '" + textbox_Name.Text + "', " + textbox_Age.Text + ",  '" + textbox_Address.Text + "', '" + date + "', '" + textbox_Designation.Text + "', " + textbox_salary.Text + " , '"+ textBox_teacher_quality.Text+"','" + textbox_Phone.Text + "' , '" + textbox_Email.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
               
                SqlDataReader r = cmd.ExecuteReader();
                
               // cmd.Parameters.AddWithValue("Tea")
               // cmd.Parameters.AddWithValue("@id", id.Text);
                r.Close();
               // MessageBox.Show("Teacher Info Saved.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Confirm saved?", "Save Record", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                //con.Close();
              //  ShowOnDataGridView();
                Clear();
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please fill the form.");
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            HomePage hp = new HomePage();
            hp.Show();
        }

        private void NewTeacher_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
