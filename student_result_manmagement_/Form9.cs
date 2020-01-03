using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_result_manmagement_
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please Enter Valid Registration number");
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ERROL COSTABIR\Documents\softwrae engineering\the ultimate\student_result_manmagement_\student_result_manmagement_\Database2.mdf;Integrated Security=True");


                //   string str = "Select Count(*) From student Where Id = '" + textBox1.Text + "'";
                string str = "Select * from student Where Id = '" + textBox1.Text + "'";
                  Console.Write(str);
                   SqlCommand cmd = new SqlCommand(str, con);
                       SqlDataAdapter da = new SqlDataAdapter(cmd);
                       DataTable dt = new DataTable();
                       da.Fill(dt);

                   dataGridView1.DataSource = dt;// new BindingSource(dt, null);

                   textBox1.Text = "";
                   



           


            }



            
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
            {
                try
                {
                    this.studentTableAdapter.FillBy(this.database2DataSet.student);
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }

            }

            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\student.COMPLAB6NODE20\Desktop\student_result_manmagement_\student_result_manmagement_\Database2.mdf;Integrated Security=True;Connect Timeout=30"))
            {

                SqlDataAdapter adapt;
                con.Open();
                DataTable dt = new DataTable();
                adapt = new SqlDataAdapter("select count(*) from [student]", con);
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();
            newForm.Show(); this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 newForm = new Form4();
            newForm.Show(); this.Hide();
        }
    }
    }

