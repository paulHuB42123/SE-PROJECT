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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SIGN_IN_form a = new SIGN_IN_form();
            a.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Photos c = new Photos();
            c.Show();
            this.Hide();
        }
    }
}
