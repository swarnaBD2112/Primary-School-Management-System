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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }
        private void OnBackClick(object sender, EventArgs e)
        {
           this.Close();
           Login l = new Login();
           l.Show();
        }

      /*  private void OnValueChangeClass(object sender, EventArgs e)
        {
            string cString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Binayak_Ray\Documents\PrimaryDB.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection con = new SqlConnection(cString);
            con.Open();

            string query = "Select * From tbl_student Where Class_name = '" + Class_ComboBox.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader r = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(r);

            dataGridView1.DataSource = dt;
        }*/

        private void Teach_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Hide();
           if(Teach_ComboBox.Text.Equals("Search Teacher"))
           {
               Search_Teacher st = new Search_Teacher();
               st.ShowDialog();
           }
           else if(Teach_ComboBox.Text.Equals("Add New"))
           {
               NewTeacher nt = new NewTeacher();
               nt.ShowDialog();
           }
        }

        private void St_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Hide();
            if(St_ComboBox.Text.Equals("Admit New"))
            {
                Admit a = new Admit();            
                a.ShowDialog();
            }
            else if(St_ComboBox.Text.Equals("Search Information"))
            {
                Search s = new Search();
                s.ShowDialog();               
            }
            
        }

        private void Subject_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Hide();
            if(Subject_comboBox.Text.Equals("Search Subject"))
            {
                Search_Subject ss = new Search_Subject();
                ss.ShowDialog();

            }
            else if(Subject_comboBox.Text.Equals("Add New"))
            {
                Add_Subject add = new Add_Subject();
                add.ShowDialog();
                

            }
        }
        //   Search Gurdian
      //  Add New
        private void Gurdian_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Hide();
           /* if (Gurdian_comboBox.Text.Equals("Add New"))
            {
                Add_Gurdian ag = new Add_Gurdian();
                ag.Show();
            }*/
            if (Gurdian_comboBox.Text.Equals("Search Gurdian"))
            {
                Search_Gurdian sg = new Search_Gurdian();
                sg.Show();
            }
        }

        private void Class_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void On_SaveData_Click(object sender, EventArgs e)
        {
            this.Hide();
            FillTermResult ftr = new FillTermResult();
            ftr.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int p = 0;
            if (comboBox1.Text.Equals("Single Student"))
            {
                this.Hide();
                p = 1;
                SearchResult sr = new SearchResult(p);
                sr.ShowDialog();

            }
            else if (comboBox1.Text.Equals("Class wise"))
            {
                this.Hide();
                SearchResult sr = new SearchResult(p);
                sr.ShowDialog();


            }
        }

        private void comboBox_class_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Hide();

            if (comboBox_class.Text.Equals("Search class"))
            {
                AddClass ac = new AddClass();
                ac.ShowDialog();

            }
            else if (comboBox_class.Text.Equals("Add New"))
            {
                AddClass ac = new AddClass();
                ac.ShowDialog();


            }
        }

        private void Know(object sender, EventArgs e)
        {


        }

        private void T_Info(object sender, EventArgs e)
        {

            this.hide();


        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

       
        }
   }

