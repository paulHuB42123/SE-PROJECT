using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE_PROJECET
{
    public partial class Admin_Panal : Form
    {
        public Admin_Panal()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MEMBERS a = new MEMBERS();
            a.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SIGN_IN_form c = new SIGN_IN_form();
            c.Show();
            this.Hide();
        }
    }
}
