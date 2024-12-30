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

namespace GymProject
{
    public partial class Form11 : Form
    {
        public static SqlConnection connection = new SqlConnection("Data Source=DESKTOP-MLUIENJ\\SQLEXPRESS; Initial Catalog=Gym2; Integrated Security=TRUE");
        bool isthere;
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            string admin_ID = textBox1.Text;
            string admin_password = textBox2.Text;
            connection.Open();
            SqlCommand command = new SqlCommand("Select * from [admins]", connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                if (admin_ID == reader["admin_ID"].ToString().TrimEnd() && admin_password == reader["admin_password"].ToString().TrimEnd())
                {
                    isthere = true;
                    break;
                }
                else
                {
                    isthere = false;
                }
            }
            if (isthere)
            {
                MessageBox.Show("Giriş Başarılı ...");


                Form12 form12 = new Form12();
                form12.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("ID veya Şifre Hatalı! ");

            }

            connection.Close();


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}