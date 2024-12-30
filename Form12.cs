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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GymProject
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            string connectionString = "Data Source=DESKTOP-MLUIENJ\\SQLEXPRESS; Initial Catalog=Gym2; Integrated Security=TRUE";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT * FROM customers"; // Veritabanından tüm kayıtları getir
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable; // DataGridView'e verileri bağla
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veriler yüklenirken hata oluştu: " + ex.Message);
                }
            }
        }
        private void Form12_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gymDataSet8.customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.gymDataSet8.customers);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-MLUIENJ\\SQLEXPRESS; Initial Catalog=Gym2; Integrated Security=TRUE";

            // Bağlantıyı oluştur
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    // Güncelleme sorgusu
                    string query = "UPDATE customers SET member_name = @member_name, member_surname = @member_surname, contact_number = @contact_number, date_of_birth = @date_of_birth, passwords = @passwords, member_gender=@member_gender WHERE member_ID = @member_ID";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Parametreleri ekle
                        cmd.Parameters.AddWithValue("@member_ID", int.Parse(textBox5.Text));
                        cmd.Parameters.AddWithValue("@member_name", textBox1.Text); // İsim
                        cmd.Parameters.AddWithValue("@member_surname", textBox2.Text); // Soyisim
                        cmd.Parameters.AddWithValue("@contact_number", textBox3.Text); // İletişim Numarası
                        cmd.Parameters.AddWithValue("@date_of_birth", dateTimePicker1.Value); // Doğum Tarihi
                        cmd.Parameters.AddWithValue("@passwords", textBox4.Text); // Şifre
                        cmd.Parameters.AddWithValue("@member_gender", checkBox1.Checked ? "Male" : "Female");

                        // Sorguyu çalıştır
                        cmd.ExecuteNonQuery();

                        // Mesaj kutusu ile bilgi ver
                        MessageBox.Show("Güncelleme başarılı!");
                    }
                }
                catch (Exception ex)
                {
                    // Hata durumunda mesaj kutusu ile göster
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
                con.Close();
            }


            // Form alanlarını temizle
            textBox5.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            LoadData();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-MLUIENJ\\SQLEXPRESS; Initial Catalog=Gym2; Integrated Security=TRUE";

            // Bağlantıyı oluştur
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    // Güncelleme sorgusu
                    string query = "Delete customers  WHERE member_ID = @member_ID";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Parametreleri ekle
                        cmd.Parameters.AddWithValue("@member_ID", int.Parse(textBox5.Text));
                  

                        // Sorguyu çalıştır
                        cmd.ExecuteNonQuery();

                        // Mesaj kutusu ile bilgi ver
                        MessageBox.Show("Silme başarılı!");
                    }
                }
                catch (Exception ex)
                {
                    // Hata durumunda mesaj kutusu ile göster
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
                con.Close();
            }


            // Form alanlarını temizle
            textBox5.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            LoadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-MLUIENJ\\SQLEXPRESS; Initial Catalog=Gym2; Integrated Security=TRUE";

            // Create the connection and use a 'using' block to ensure proper disposal
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open(); // Open the connection

                    string member_ID = null;
                    string query = "INSERT INTO [customers] (member_name, member_surname, contact_number, passwords, date_of_birth, member_gender, joining_date) " +
                                   "VALUES (@member_name, @member_surname, @contact_number, @passwords, @date_of_birth, @member_gender, @joining_date); " +
                                   "SELECT SCOPE_IDENTITY();";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters with user input
                        command.Parameters.AddWithValue("@member_name", textBox1.Text.Trim());
                        command.Parameters.AddWithValue("@member_surname", textBox2.Text.Trim());
                        command.Parameters.AddWithValue("@contact_number", textBox3.Text.Trim());
                        command.Parameters.AddWithValue("@passwords", textBox4.Text.Trim());
                        command.Parameters.AddWithValue("@date_of_birth", dateTimePicker1.Value);
                        command.Parameters.AddWithValue("@member_gender", checkBox1.Checked ? "Male" : "Female");
                        command.Parameters.AddWithValue("@joining_date", DateTime.Now);

                        // Execute the query and retrieve the newly generated member ID
                        member_ID = command.ExecuteScalar().ToString();
                    }

                    // Show success message with the new member ID
                    MessageBox.Show($"Kayıt başarılı! Yeni Member ID: {member_ID}", "Kayıt Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // Handle potential errors
                    MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                LoadData();
            }
        }
    }
    }
    

