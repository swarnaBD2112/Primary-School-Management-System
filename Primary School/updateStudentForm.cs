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
    public partial class updateStudentForm : Form
    {
        int ID;
        SqlDataReader dr;
        public updateStudentForm(int ID)
        {
            this.ID = ID;
            //dr = new SqlDataReader();
            InitializeComponent();
        }

        private void updateStudentForm_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn1 = Connection_Methods.CreateConnection();
                String query = "select * from tbl_student where  Student_Id='"+ ID +"'";
                SqlCommand cmd = new SqlCommand(query, conn1);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                textBox_ID.Text = reader[0].ToString();
               
                text_Name.Text = reader[1].ToString();
                Class_comboBox.Text = reader[2].ToString();
                text_Age.Text = reader[3].ToString();
                text_Address.Text = reader[4].ToString();
           
                dateTimePicker1.Text = reader[5].ToString();
                comboBox_gender.Text = reader[6].ToString();
                textBox_Gurdian.Text = reader[7].ToString();
                textBox_G_Id.Text = reader[8].ToString();
                comboBox_relationship.Text = reader[9].ToString();
                comboBox_quata.Text = reader[10].ToString();
                textBox_G_Phone.Text = reader[11].ToString();
                textBox_G_Email.Text = reader[12].ToString();
                textBox_nationality.Text = reader[13].ToString();


               // MessageBox.Show("Confirm delete?", "Save Record", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                //cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Search s = new Search();
            s.Show();
        }

        private void Add_Click_1(object sender, EventArgs e)
        {
            try
            {
                DateTime date = dateTimePicker1.Value.Date;
                SqlConnection conn1 = Connection_Methods.CreateConnection();
                String query = "update tbl_student set Name='" + text_Name.Text + "',Class_name='" + Class_comboBox.Text + "',Age='" + Convert.ToInt32(text_Age.Text) + "',Address='" + text_Address.Text + "', DOB =  '" + date + "',Gender='" + comboBox_gender.Text + "',Gurdian_name='" + textBox_Gurdian.Text + "',G_Id='" + Convert.ToInt32(textBox_G_Id.Text) + "',RelationShip='" + comboBox_relationship.Text + "',Quata='" + comboBox_quata.Text + "',Phone='" + textBox_G_Phone.Text + "',Email='" + textBox_G_Email.Text + "',Nationality='" + textBox_nationality.Text + "' where Student_Id = '" + ID + "'";
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
    }
}
