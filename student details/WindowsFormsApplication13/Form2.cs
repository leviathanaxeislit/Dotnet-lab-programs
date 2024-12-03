using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication13
{
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=KRATOSBOX\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select distinct(YR_OF_AD) from TBL_STUDENT", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0].ToString());
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_STUDENT where yr_of_ad=" + comboBox1.Text, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
