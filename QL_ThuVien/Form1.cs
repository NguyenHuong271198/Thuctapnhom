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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_username.Focus();
            txt_password.Focus();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Login()
        {
            if (txt_username.Text.Length == 0 && txt_password.Text.Length == 0)
                MessageBox.Show(" Ban chua dang nhap mat khau");
            else
                if (this.txt_username.Text.Length == 0)
                MessageBox.Show("Ban chua dang nhap username");
                else
                    if (this.txt_password.Text.Length == 0)
                    MessageBox.Show("Ban chua dang nhap paswowrd");
                    else
                      if (this.txt_username.Text == ("huong2k7") && this.txt_password.Text == ("271198"))
                      MessageBox.Show(" dang nhap thanh cong !");
                      else
                       MessageBox.Show("Mat khau cua ban khong dung !");

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Form fm = new Form2();
            if( this.txt_username.Text==("huong2k7") && this.txt_password.Text ==("271198"))
            {
                fm.Show();
            }

        }
    }
}
