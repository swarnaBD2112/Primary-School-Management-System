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
    public partial class AddClass : Form
    {
        public AddClass()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            HomePage hp = new HomePage();
            hp.ShowDialog();
        }

        private void On_Add_Click(object sender, EventArgs e)
        {

            SqlConnection conn1 = Connection_Methods.CreateConnection();
            string query = "INSERT INTO tbl_class (Class_Name, Class_Teacher, Room_Number) VALUES ('" + textBox_cls_Name.Text + "', '" + textBox_cls_teacher.Text + "','" + textBoxroom_No.Text + "' )";
            SqlCommand cmd = new SqlCommand(query, conn1);
            SqlDataReader r = cmd.ExecuteReader();
            r.Close();
            MessageBox.Show("Data Saved !!.", "Confirmation", MessageBoxButtons.OK);
            clear();
        }
        private void clear()
        {
            textBox_cls_Name.Text = null;
            textBox_cls_teacher.Text = null;
            textBoxroom_No.Text = null; 

        }
    }
}
