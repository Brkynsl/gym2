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
    public partial class Form2 : Form
    {
        SqlConnection connection = Form1.connection;

        public Form2()
        {
            InitializeComponent();
            CustomizeUI();
            textBox1.KeyPress += textBox1_KeyPress;
            textBox4.KeyPress += textBox4_KeyPress;
            textBox2.KeyPress += textBox2_KeyPress;
          
        }

        private void CustomizeUI()
        {
            // Customize form appearance
            this.Text = "Member Registration";
            this.BackColor = Color.LightBlue;

            // Customize text boxes
            textBox1.Font = new Font("Arial", 10, FontStyle.Regular);
            textBox2.Font = new Font("Arial", 10, FontStyle.Regular);
            textBox3.Font = new Font("Arial", 10, FontStyle.Regular);

            // Customize buttons
            button1.Font = new Font("Arial", 10, FontStyle.Bold);
            button1.BackColor = Color.DarkBlue;
            button1.ForeColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;

            // Customize date picker
            dateTimePicker1.Font = new Font("Arial", 10, FontStyle.Regular);

            // Customize checkbox
            checkBox1.Font = new Font("Arial", 10, FontStyle.Regular);
            checkBox3.Font = new Font("Arial", 10, FontStyle.Regular);

            // Customize link label
            linkLabel1.Font = new Font("Arial", 10, FontStyle.Underline);
            linkLabel1.LinkColor = Color.Blue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string eksikBilgiler = "";

            // Her bir alanı kontrol et ve eksikse ilgili mesajı ekle
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                eksikBilgiler += "- İsim\n";
            }
            if (string.IsNullOrWhiteSpace(textBox4.Text))
            {
                eksikBilgiler += "- Soyisim\n";
            }
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                eksikBilgiler += "- İletişim Numarası\n";
            }
            else if (textBox2.Text.Length != 11 || !long.TryParse(textBox2.Text, out _))
            {
                // Eğer telefon numarası girilmişse ama yanlışsa ayrı bir mesaj göster ve işlemi durdur
                MessageBox.Show("Telefon numarası tam olarak 11 rakamdan  oluşmalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                eksikBilgiler += "- Şifre\n";
            }
            if (!checkBox1.Checked && !checkBox2.Checked)
            {
                eksikBilgiler += "- Cinsiyet Seçimi\n";
            }
            if (dateTimePicker1.Value.Date >= DateTime.Now.Date)
            {
                eksikBilgiler += "- Geçerli bir Doğum Tarihi (bugünden küçük olmalıdır).\n";
            }

            // Eğer eksik bilgiler varsa MessageBox göster ve işlemi durdur
            if (!string.IsNullOrEmpty(eksikBilgiler))
            {
                MessageBox.Show("Lütfen aşağıdaki bilgileri doldurun:\n" + eksikBilgiler, "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }




            
            string member_ID = null;
            connection.Open();
            using (SqlCommand command = new SqlCommand(
                "INSERT INTO [customers] (member_name,member_surname, contact_number, passwords, date_of_birth, member_gender, joining_date) " +
                "VALUES (@member_name,@member_surname, @contact_number, @passwords, @date_of_birth, @member_gender, @joining_date);"+
                "SELECT SCOPE_IDENTITY();", connection)) 
            {
                command.Parameters.AddWithValue("@member_name", textBox1.Text.Trim());
                command.Parameters.AddWithValue("@member_surname", textBox4.Text.Trim());
                command.Parameters.AddWithValue("@contact_number", textBox2.Text.Trim());
                command.Parameters.AddWithValue("@passwords", textBox3.Text.Trim());
                command.Parameters.AddWithValue("@date_of_birth", dateTimePicker1.Value);
                command.Parameters.AddWithValue("@member_gender", checkBox1.Checked ? "Male" : "Female");
                command.Parameters.AddWithValue("@joining_date", DateTime.Now);
                
                

                member_ID = command.ExecuteScalar().ToString();
            }

            //MessageBox.Show($"Kayıt Başarılı!");
            MessageBox.Show($"Kayıt başarılı! Yeni Member ID: {member_ID}", "Kayıt Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
            
            connection.Close();

            

        }

        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {

                textBox3.PasswordChar = '\0';
            }

            else
            {
                textBox3.PasswordChar = '*';
            }
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sadece harfler ve kontrol tuşlarını (Backspace gibi) kabul et
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Karakteri reddet
                MessageBox.Show("Lütfen yalnızca harf giriniz.", "Geçersiz Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sadece harfler ve kontrol tuşlarını (Backspace gibi) kabul et
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Karakteri reddet
                MessageBox.Show("Lütfen yalnızca harf giriniz.", "Geçersiz Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sadece rakamlar ve kontrol tuşlarını (Backspace gibi) kabul et
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Karakteri reddet
                MessageBox.Show("Lütfen yalnızca sayı giriniz.", "Geçersiz Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    


    }
}