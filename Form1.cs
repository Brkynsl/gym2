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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GymProject
{
    public partial class Form1 : Form
    {
        public static SqlConnection connection = new SqlConnection("Data Source=DESKTOP-MLUIENJ\\SQLEXPRESS; Initial Catalog=Gym2; Integrated Security=TRUE");
        bool isthere;
        public Form1()
        {
            InitializeComponent();
            CustomizeUI();
        }
        private void CustomizeUI()
        {
            // Customize form appearance
            this.Text = "Member Login";
            this.BackColor = Color.LightBlue;

            // Customize text boxes
            textBox1.Font = new Font("Arial", 10, FontStyle.Regular);
            textBox2.Font = new Font("Arial", 10, FontStyle.Regular);
            

            // Customize buttons
            button1.Font = new Font("Arial", 10, FontStyle.Bold);
            button1.BackColor = Color.DarkBlue;
            button1.ForeColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;

            button2.Font = new Font("Arial", 10, FontStyle.Bold);
            button2.BackColor = Color.DarkBlue;
            button2.ForeColor = Color.White;
            button2.FlatStyle = FlatStyle.Flat;
            // Customize date picker


            // Customize checkbox
            checkBox1.Font = new Font("Arial", 10, FontStyle.Regular);
            

         
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            
            form2.Show();
            this.Hide();
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {

                textBox1.PasswordChar = '\0';
            }

            else
            {
                textBox1.PasswordChar = '*';
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            string member_name = "";

            string contact_number = "";
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-MLUIENJ\\SQLEXPRESS; Initial Catalog=Gym2; Integrated Security=TRUE"))
            {
                connection.Open();
                string query = "SELECT contact_number, member_name FROM customers WHERE contact_number = @contact_number";  // SQL sorgusu düzeltildi
                using (SqlCommand command1 = new SqlCommand(query, connection))
                {
                    command1.Parameters.AddWithValue("@contact_number", contact_number);  // Sadece tc parametresini ekliyoruz, çünkü ad değeri sorgunun sonucu olarak alınacak
                    SqlDataReader reader1 = command1.ExecuteReader();
                    if (reader1.Read())
                    {
                        contact_number = reader1["contact_number"].ToString();
                        member_name = reader1["member_name"].ToString();
                    }
                }
            }
            connection.Close();
            string member_ID = textBox2.Text;
            string passwords = textBox1.Text;

            connection.Open();
            SqlCommand command = new SqlCommand("Select * from [customers]", connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                if (member_ID == reader["member_ID"].ToString().TrimEnd() && passwords == reader["passwords"].ToString().TrimEnd())
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
                MessageBox.Show("Giriş Başarılı Hesabınız Açılıyor...");



                Form3 form3 = new Form3(contact_number,member_name);
                form3.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("ID veya Şifre Hatalı! ");

            }

            connection.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
            
            
            this.ActiveControl = textBox2;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form11 form11= new Form11();
            form11.Show();
            this.Hide();
        }
    }

}

