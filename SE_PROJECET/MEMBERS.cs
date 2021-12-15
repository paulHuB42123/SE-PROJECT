using MongoDB.Driver.Core.Configuration;
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


namespace SE_PROJECET
{
    public partial class MEMBERS : Form
    {
        void BindData()
        {
            SqlConnection con = new SqlConnection("Data Source=PAULWOOD;Initial Catalog=SE;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM members", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public MEMBERS()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Admin_Panal c = new Admin_Panal();
            c.Show();
            this.Hide();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        string connectionString = "Data Source=PAULWOOD;Initial Catalog=SE;Integrated Security=True";
        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = con.CreateCommand();

            cmd.CommandText = "insert into members(id, address, name, phone, gender, age, t_ex, email ) values('" + textID.Text + "', '" + textBox2.Text + "', '" + textNAME.Text + "', '" + textNUM.Text + "', '" + comboBox2.Text + "', '" + textAGE.Text + "', '" + comboBox1.Text + "', '" + textBox1.Text + "')";
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("SUCCESSFULLY ADDED!");
              
            }
            else { MessageBox.Show("Error!"); }
            con.Close();
            BindData();
        }

        private void buttonSEARCH_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            string query = "select *FROM members";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BindData();
        }

        private void buttonUPDATE_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand("update members set address=@address, name=@name, phone=@phone, gender=@gender, age=@age, t_ex=@t_ex , email=@email where id = @id", connection);


            connection.Open();
            cmd.Parameters.AddWithValue("@id", textID.Text);
            cmd.Parameters.AddWithValue("@address", textBox2.Text);
            cmd.Parameters.AddWithValue("@name", textNAME.Text);
            cmd.Parameters.AddWithValue("@phone", textNUM.Text);
            cmd.Parameters.AddWithValue("@gender", comboBox2.Text);
            cmd.Parameters.AddWithValue("@age", textAGE.Text);
            cmd.Parameters.AddWithValue("@t_ex", comboBox1.Text);
            cmd.Parameters.AddWithValue("@email", textBox1.Text);

            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Update successful !");

            }

            else
            {
                MessageBox.Show("Update failed!", "Enter valide information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
            BindData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand("delete members where id=@id", connection);


            connection.Open();
            cmd.Parameters.AddWithValue("@id", textID.Text);


            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {

                MessageBox.Show("DELETED !");
                textID.Clear();

            }

            else
            {
                MessageBox.Show("Delete failed!", "Enter valide information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
            BindData();
        }
    }
}
