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
    public partial class Form4 : Form
    {
        private object tableTableAdapter1;

        public Form4()
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
        string contact_number = "";
        string member_name = "";
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gymDataSet.trainers' table. You can move, or remove it, as needed.
            this.trainersTableAdapter.Fill(this.gymDataSet.trainers);
            string query = "SELECT * FROM [trainers] WHERE [trainer_ID] IS NOT NULL AND [trainer_ID] <> ''";
            SqlDataAdapter adapter = new SqlDataAdapter(query, "Data Source=DESKTOP-MLUIENJ\\SQLEXPRESS; Initial Catalog=Gym2; Integrated Security=TRUE");
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            // Bind the filtered data to the DataGridView
            dataGridView1.DataSource = dataTable;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(member_name,contact_number);
            form3.Show();
            this.Hide();
        }
    }
}
