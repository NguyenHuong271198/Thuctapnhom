using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_ThuVien
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccount_Profile f = new fAccount_Profile();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Book f = new Book();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reader f = new Reader();
            f.ShowDialog();
        }
    }
}
