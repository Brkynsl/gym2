using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymProject
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            CustomizeUI();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            label2.Text = "info@centergym.com.tr\n\n\n" +
                         "0 (312) 345 44 44\n\n\n" +
                          "Please Contact Us.";
            label2.Font = new Font("Arial", 15);
        }
        private void CustomizeUI()
        {
            // Customize form appearance
            this.Text = "Contact";
            this.BackColor = Color.LightBlue;
            button1.Font = new Font("Arial", 10, FontStyle.Bold);
            button1.BackColor = Color.DarkBlue;
            button1.ForeColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
    }
}
