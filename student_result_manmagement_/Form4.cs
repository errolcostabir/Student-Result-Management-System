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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String sColour = "";
            if (radioButton1.Checked)
            {
                Form5 newForm = new Form5();
                newForm.Show(); this.Hide();
                
            }
            if (radioButton2.Checked)
            {
                Form9 newForm = new Form9();
                newForm.Show(); this.Hide();
               
            }
            if (radioButton3.Checked)
            {
                Form10 newForm = new Form10();
                newForm.Show(); this.Hide();
                
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();
            newForm.Show(); this.Hide();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
        
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
