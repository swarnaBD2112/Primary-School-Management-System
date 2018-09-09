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
    public partial class Login : Form
    {
        HomePage h = new HomePage();
        public Login()
        {
            InitializeComponent();
        }

        private void OnLoginClick(object sender, EventArgs e)
        {
            string cString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\3-1\4 db\4. lab\Code\PrimaryDB.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection con = new SqlConnection(cString);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT count(*) FROM tbl_user where Name = '" + textBox_Name.Text + "' and Password = '" + textBox_Password.Text + "'",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {               
                this.Hide();
                HomePage hp = new HomePage();
                hp.ShowDialog();
            }
            else
            {
                MessageBox.Show("Check your User Name or Password!!");
            }

        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

       
    }
}
