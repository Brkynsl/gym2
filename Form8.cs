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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'saloons._saloons' table. You can move, or remove it, as needed.
            this.saloonsTableAdapter3.Fill(this.saloons._saloons);



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3=new  Form3();
            form3.Show();
            this.Hide();
        }
    }
}
