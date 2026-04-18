using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class formmomay : Form
    {
        public string TenKhach = "";
        public formmomay()
        {
            InitializeComponent();
        }

        private void formmomay_Load(object sender, EventArgs e)
        {

        }

        private void btnlgin_Click(object sender, EventArgs e)
        {
            using (AppDbContext db = new AppDbContext())
            {
                string user = txttk.Text;
                string pass = txtmk.Text;

                // Tìm tài khoản khách trong bảng taikhoan
                TaiKhoan tk = db.taikhoans.FirstOrDefault(t => t.tendangnhap == user && t.matkhau == pass);

                if (tk != null)
                {
                    // KIỂM TRA SỐ DƯ: Nếu ít hơn 5000 thì không cho mở
                    if (tk.sodu < 2000)
                    {
                        MessageBox.Show("Tài khoản không đủ tiền (tối thiểu 2.000đ). Vui lòng nạp thêm!", "Thông báo");
                        return;
                    }

                    // Nếu ok thì lưu tên và đóng form
                    this.TenKhach = tk.tendangnhap;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu");
                }
            }
        }
    }
}
