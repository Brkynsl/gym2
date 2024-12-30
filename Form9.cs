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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gymDataSet2.workout' table. You can move, or remove it, as needed.
            this.workoutTableAdapter1.Fill(this.gymDataSet2.workout);
            // TODO: This line of code loads data into the 'gymDataSet1.workout' table. You can move, or remove it, as needed.
            //this.workoutTableAdapter.Fill(this.gymDataSet1.workout);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
    }
}
