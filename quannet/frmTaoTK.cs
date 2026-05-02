using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class frmTaoTK : Form
    {
        public frmTaoTK()
        {
            InitializeComponent();
        }

        private void btnxacnhantaotk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txttentaotk.Text) || string.IsNullOrEmpty(txtmktaotk.Text))
            {
                MessageBox.Show("Nhập đủ tên và mật khẩu đi ku!");
                return;
            }

            using (AppDbContext db_tao = new AppDbContext())
            {
                // 2. Kiểm tra xem tên này đã có ai dùng chưa
                string user = txttentaotk.Text.Trim();
                if (db_tao.taikhoans.Any(t => t.tendangnhap == user))
                {
                    MessageBox.Show("Tên này có người dùng rồi, chọn tên khác đi!");
                    return;
                }

                try
                {
                    // 3. Tạo tài khoản mới
                    TaiKhoan tk_moi = new TaiKhoan();
                    tk_moi.tendangnhap = user;
                    tk_moi.matkhau = txtmktaotk.Text.Trim();

                    // Xử lý tiền nạp đầu
                    int tien = 0;
                    if (!int.TryParse(txtsotientaotk.Text, out tien) || tien < 0)
                    {
                        MessageBox.Show("Số tiền nạp tối thiểu phải > 0!");
                        return;
                    }
                    tk_moi.sodu = tien;
                    tk_moi.tongtiennap = tien; // Nạp đầu tính luôn vào tổng nạp
                    tk_moi.tongtiendung = 0;
                    tk_moi.somay = "";

                    db_tao.taikhoans.Add(tk_moi);
                    db_tao.SaveChanges();

                    MessageBox.Show("Tạo tài khoản thành công!");
                    this.DialogResult = DialogResult.OK; // Báo về Form chính là xong việc
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
    }
}
