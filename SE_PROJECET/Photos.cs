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
    public partial class Photos : Form
    {
        public Photos()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 c = new Form1();
            c.Show();
            this.Hide();
        }
    }
}
