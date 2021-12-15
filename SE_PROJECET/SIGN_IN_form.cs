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
    public partial class SIGN_IN_form : Form
    {
        public SIGN_IN_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                string connectionString = "Data Source=PAULWOOD;Initial Catalog=SE;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);

                SqlCommand cmd = new SqlCommand("select *FROM admin WHERE id  = @id  and pass = @pass ", connection);

                connection.Open();
                cmd.Parameters.Add(new SqlParameter("id", textBox1.Text));
                cmd.Parameters.Add(new SqlParameter("pass", textBox2.Text));

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("LogIn successful !");
                    new Admin_Panal().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Log in failed,doesn't match email or Password", "Enter valide information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                connection.Close();
            }
            else 
            { 
                MessageBox.Show("Please insert your ID & Password");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 c = new Form1();
            c.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
