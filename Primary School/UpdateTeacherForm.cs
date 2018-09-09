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
    public partial class UpdateTeacherForm : Form
    {
        int ID;
        public UpdateTeacherForm(int ID)
        {
            this.ID = ID;
            InitializeComponent();
        }

        private void UpdateTeacherForm_Load(object sender, EventArgs e)
        {
            SqlConnection conn1 = Connection_Methods.CreateConnection();
            String query = "select * from tbl_teacher where  Teacher_Id='" + ID + "'";
            SqlCommand cmd = new SqlCommand(query, conn1);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            textbox_Techer_ID.Text = reader[0].ToString();
            textbox_Name.Text = reader[1].ToString();
            textbox_Age.Text = reader[2].ToString();
            textbox_Address.Text = reader[3].ToString();
            dateTimePicker2.Text = reader[4].ToString(); 
            textbox_Designation.Text = reader[5].ToString();
            textbox_salary.Text = reader[6].ToString();
            textBox_eduQuality.Text = reader[7].ToString();
            textbox_Phone.Text = reader[8].ToString();
            textbox_Email.Text = reader[9].ToString();
            
        }

        private void On_Add_Click(object sender, EventArgs e)
        {

            try
            {
                DateTime date = dateTimePicker2.Value.Date;
                SqlConnection conn1 = Connection_Methods.CreateConnection();
                String query = "update tbl_teacher set Full_Name='" + textbox_Name.Text + "',Age=" + textbox_Age.Text + ",Address='" + textbox_Address.Text + "',Date_Of_Birth= '" + date + "', Designation='" + textbox_Designation.Text + "',Salary = " + textbox_salary.Text + ", Educational_Qualification='" + textBox_eduQuality.Text + "',Phone='" + textbox_Phone.Text + "',Email='" + textbox_Email.Text + "' where Teacher_Id = '" + ID + "'";
                SqlCommand cmd = new SqlCommand(query, conn1);
                cmd.ExecuteNonQuery();


                MessageBox.Show("Confirm Update?", "Save Record", MessageBoxButtons.YesNo);
                //cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            Search_Teacher st = new Search_Teacher();
            st.Show();
        }
    }
}
