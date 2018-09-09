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
    public partial class FillTermResult : Form
    {
        public FillTermResult()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void On_Back_Click(object sender, EventArgs e)
        {
            this.Close();
            HomePage hp = new HomePage();
            hp.ShowDialog();
        }

        private void On_Ok_Click(object sender, EventArgs e)
        {
            try
            {
            SqlConnection conn1 = Connection_Methods.CreateConnection();
            string query = "INSERT INTO result (Student_Id, class, term, bangla, english, math , science ,social_science, religion, pt, music) VALUES (" + textBox_std_Id.Text + ", '" + comboBox_class.Text + "', '" + comboBox_term.Text + "', " + textBox_bangla.Text + ", " + textBox_english.Text + ", " + textBox_math.Text + ", " + textBoxscience.Text + ", " + textBox_social_sci.Text + "," + textBox8_religion.Text + "," + textBox10_pt.Text + "," + textBox9_music.Text + ")";
            SqlCommand cmd = new SqlCommand(query, conn1);
            SqlDataReader r = cmd.ExecuteReader();
            r.Close();
            MessageBox.Show("Data Saved !!.", "Confirmation", MessageBoxButtons.OK);
            clear();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show(ex.Message);
            }

        }
        private void clear()
        {
            textBox_std_Id.Text = null;
            comboBox_class.Text = null;
            comboBox_term.Text = null;
            textBox_bangla.Text = null;
            textBox_english = null;
            textBox_math.Text = null;
            textBoxscience.Text = null;
            textBox_social_sci.Text = null;
            textBox8_religion.Text = null;
            textBox10_pt.Text = null;
            textBox9_music = null;
 
        }

        private void FillTermResult_Load(object sender, EventArgs e)
        {

        }
    }
}
