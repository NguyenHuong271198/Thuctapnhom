using QL_ThuVien.DAO;
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

namespace QL_ThuVien
{
    public partial class Book : Form
    {
        public Book()
        {
            InitializeComponent();
            LoadBooklist();
        }

        private void Book_Load(object sender, EventArgs e)
        {

        }
        void LoadBooklist()
        {
            string query = "SELECT * From dbo.tbDauSach";
            DataProvider provider = new DataProvider();
            dtg_book.DataSource = provider.Executequery(query);
        }
    }
}
