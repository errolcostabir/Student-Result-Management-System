using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_result_manmagement_
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String sColour = "";
            if (checkBox1.Checked)
            {
                Form11 newForm = new Form11();
                newForm.Show(); this.Hide();

            }
            
            if (checkBox2.Checked)
            {
                Form7 newForm = new Form7();
                newForm.Show(); this.Hide();

            }

            if (checkBox3.Checked)
            {
                Form12 newForm = new Form12();
                newForm.Show(); this.Hide();

            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 newForm = new Form4();
            newForm.Show(); this.Hide();
        }
    }
}
