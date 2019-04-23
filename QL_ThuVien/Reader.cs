using QL_ThuVien.DAO;
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
    public partial class Reader : Form
    {
        public Reader()
        {
            InitializeComponent();
            LoadReaderlist();
        }

        private void Reader_Load(object sender, EventArgs e)
        {

        }
        void LoadReaderlist()
        {
            string query = "SELECT * FROM dbo.tbDocGia";
            DataProvider provider = new DataProvider();
            dtg_Reader.DataSource = provider.Executequery(query);
        }
    }
}
