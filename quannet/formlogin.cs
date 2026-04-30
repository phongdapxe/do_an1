using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class formlogin : Form
    {
        public formlogin()
        {
            InitializeComponent();
        }
        string tkadmin = "admin";
        string mkadmin = "1";
        private void btnlogin_Click(object sender, EventArgs e)
        {
            string tkadminnhap = txtuser.Text;
            string mkadminnhap = txtpass.Text;

            if (tkadminnhap == tkadmin && mkadminnhap == mkadmin)
            {
                MessageBox.Show("Đăng nhập thành công!");
                MessageBox.Show("Chào mừng nhà quản lý đăng nhập");

                Form1 f1 = new Form1();
                this.Hide();

                f1.FormClosed += (s, args) => this.Close();

                f1.Show();

            }
            else
            {
                MessageBox.Show("Sai tai khoan hoac mat khau");

                txtpass.Clear();
                txtuser.Clear();
                txtuser.Focus();
            }
        }
    }
}
