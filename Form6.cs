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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            CustomizeUI();
        }
        private void CustomizeUI()
        {
            // Customize form appearance
            this.Text = "About Us";
            this.BackColor = Color.LightBlue;
            button1.Font = new Font("Arial", 10, FontStyle.Bold);
            button1.BackColor = Color.DarkBlue;
            button1.ForeColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
        }

            private void Form6_Load(object sender, EventArgs e)
        {
            label2.Text = "You will catch the rhythm of life in the aerobic and step halls\n" +
                          " increase your energy in the Spinning studio, and \n" +
                          "discover your talent in different sports with the basketball hall\n" +
                          "table tennis, kickboxing ring and climbing cells.";
            label2.Font = new Font("Arial", 17);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
    }
}
