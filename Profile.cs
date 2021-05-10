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
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection("Data Source=DESKTOP-3DT8I6R;Initial Catalog=FinalProject;Integrated Security=True");

            SqlDataAdapter sqlDa1 = new SqlDataAdapter("SELECT * FROM Student_Marks", con1);
            DataTable dtbl1 = new DataTable();
            sqlDa1.Fill(dtbl1);
            dataGridView1.DataSource = dtbl1;

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-3DT8I6R;Initial Catalog=FinalProject;Integrated Security=True");
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Registration", con);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dataGridView2.DataSource = dtbl;


        }
    }
}
