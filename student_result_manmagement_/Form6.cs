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

namespace student_result_manmagement_
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();
            newForm.Show(); this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\STUDENT.COMPLAB6NODE20\DOCUMENTS\17CE18\STUDENT_RESULT_MANMAGEMENT_\STUDENT_RESULT_MANMAGEMENT_\ERROLDATA.MDF;Integrated Security=True;Connect Timeout=30"))
            {

                SqlDataAdapter adapt;
                con.Open();
                DataTable dt = new DataTable();
                adapt = new SqlDataAdapter("select * from Address", con);
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }


        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'erroldataDataSet2.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter1.Fill(this.erroldataDataSet2.Table);
            // TODO: This line of code loads data into the 'erroldataDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.erroldataDataSet.Table);

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 newForm = new Form4();
            newForm.Show(); this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please Enter Valid Registration number");
            }
            else
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\USERS\STUDENT.COMPLAB6NODE20\DOCUMENTS\17CE18\STUDENT_RESULT_MANMAGEMENT_\STUDENT_RESULT_MANMAGEMENT_\ERROLDATA.MDF;Integrated Security=True;User Instance=True"))
                {

                    string str = "SELECT * FROM indi WHERE std_id = '" + textBox1.Text + "'";
                    SqlCommand cmd = new SqlCommand(str, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = new BindingSource(dt, null);
                }
                textBox1.Text = "";
            }
        }
    }
}
