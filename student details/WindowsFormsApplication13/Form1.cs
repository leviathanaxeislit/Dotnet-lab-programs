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
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=KRATOSBOX\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select c_id from stud", con);
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
            SqlCommand cmd = new SqlCommand("insert into TBL_STUDENT values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "','" + textBox5.Text + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("New Student Entered");
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 d = new Form2();
            d.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            comboBox1.Text = "";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
