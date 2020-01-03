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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'allresultDataSet2.semech' table. You can move, or remove it, as needed.
            this.semechTableAdapter.Fill(this.allresultDataSet2.semech);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form10 newForm = new Form10();
            newForm.Show(); this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();
            newForm.Show(); this.Hide();
        }
    }
}
