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

namespace Final_Project
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-3DT8I6R;Initial Catalog=FinalProject;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("insert into Registration Values (@First_Name, @Family_Name , @Program  , @DOB , @Emirate_Area , @Phone_Number , @Gender )", con);
            cmd.Parameters.AddWithValue("@First_Name", textBox1.Text);
            cmd.Parameters.AddWithValue("@Family_Name", textBox4.Text);
            cmd.Parameters.AddWithValue("@Program", textBox2.Text);
            cmd.Parameters.AddWithValue("@DOB", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@Emirate_Area", comboBox1.Text);
            cmd.Parameters.AddWithValue("@Phone_Number", int.Parse(textBox5.Text));
            cmd.Parameters.AddWithValue("@Gender", comboBox2.Text);

            con.Open();
            int v = cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Saved");

        }
    }
}
