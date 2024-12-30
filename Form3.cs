using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GymProject
{
    public partial class Form3 : Form
    {
        SqlConnection connection = Form1.connection;
        public Form3(string member_name = null, string contact_number = null)
        {
            InitializeComponent();
            this.member_name = member_name;
            this.contact_number = contact_number;

            CustomizeUI();

           
        }
        private string member_name;
        private string contact_number;
        private void CustomizeUI()
        {
            // Customize form appearance
            this.Text = "Member Panel";
            this.BackColor = Color.LightBlue;



            // Customize checkbox
          
            label1.Font = new Font("Arial", 21, FontStyle.Regular);

            // Customize link label
            linkLabel1.Font = new Font("Arial", 20, FontStyle.Underline);
            linkLabel1.LinkColor = Color.Blue;
            linkLabel2.Font = new Font("Arial", 20, FontStyle.Underline);
            linkLabel2.LinkColor = Color.Blue;
        }


        private void Form3_Shown(object sender, EventArgs e)
        {
            Form3_Load_1(sender, e);
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void Form3_Load_1(object sender, EventArgs e)
        {

            this.Load += new System.EventHandler(this.Form3_Load_1);
           
            linkLabel1.Font = new Font("Arial", 14, FontStyle.Regular);
            linkLabel2.Font = new Font("Arial", 14, FontStyle.Regular);




        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            MessageBox.Show(" Çıkış Yapıldı");
            Application.Exit();

        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            this.Hide();

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
            this.Hide();
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
            this.Hide();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form9 form9 = new Form9();
            form9.Show();
            this.Hide();
        }

    }
}
