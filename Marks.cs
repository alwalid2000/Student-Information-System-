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
    public partial class Marks : Form
    {
        public Marks()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-3DT8I6R;Initial Catalog=FinalProject;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("insert into Student_Marks Values (@Student_Name, @Student_ID  , @Course_Name , @Course_ID , @Semester , @Academic_Year , @Mark , @Grade)", con);
            cmd.Parameters.AddWithValue("@Student_Name", textBox1.Text);
            cmd.Parameters.AddWithValue("@Student_ID", textBox2.Text);
            cmd.Parameters.AddWithValue("@Course_Name", textBox3.Text);
            cmd.Parameters.AddWithValue("@Course_ID", textBox4.Text);
            cmd.Parameters.AddWithValue("@Semester", comboBox1.Text);
            cmd.Parameters.AddWithValue("@Academic_Year", textBox5.Text);
            cmd.Parameters.AddWithValue("@Mark", textBox7.Text);
            cmd.Parameters.AddWithValue("@Grade", textBox6.Text);


            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Saved");

        }
    }
}
