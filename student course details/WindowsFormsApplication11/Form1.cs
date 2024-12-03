using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication11
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=KRATOSBOX\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into stud values(" +textBox1.Text + ",'" + textBox2.Text + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("New Course Entered");
            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter da=new SqlDataAdapter("select * from stud",con);
            DataTable dt= new DataTable();
            da.Fill(dt);
            DataGrindView1.DataSource=dt;
            con.Close( );

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
