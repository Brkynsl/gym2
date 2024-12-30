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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            CustomizeUI();
        }
        private void CustomizeUI()
        {
            // Customize form appearance
            this.Text = "Member Registration";
            this.BackColor = Color.LightBlue;


            // Customize buttons
            dataGridView1.Font = new Font("Arial", 10, FontStyle.Bold);
            dataGridView1.BackColor = Color.DarkBlue;






        }
        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gymDataSet.equipment' table. You can move, or remove it, as needed.
            this.equipmentTableAdapter.Fill(this.gymDataSet.equipment);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3=new  Form3();
            form3.Show();
            this.Hide();

        }
    }
}
