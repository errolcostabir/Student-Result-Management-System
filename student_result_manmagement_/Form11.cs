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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'allresultDataSet4.comp' table. You can move, or remove it, as needed.
            this.compTableAdapter1.Fill(this.allresultDataSet4.comp);
            // TODO: This line of code loads data into the 'allresultDataSet3.comp' table. You can move, or remove it, as needed.
            this.compTableAdapter.Fill(this.allresultDataSet3.comp);
            // TODO: This line of code loads data into the 'allresultDataSet1.secomp' table. You can move, or remove it, as needed.
//this.compTableAdapter.Fill(this.allresultDataSet1.comp);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();
            newForm.Show(); this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form10 newForm = new Form10();
            newForm.Show(); this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
