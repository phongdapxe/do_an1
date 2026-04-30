using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class xacnhanorder : Form
    {
        Dictionary<string, (int sl, int gia)> gioHang;

        public xacnhanorder(Dictionary<string, (int sl, int gia)> gioHang)
        {
            InitializeComponent();
            this.gioHang = gioHang;
        }

        private void btnodxacnhan_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtodtaikhoan.Text.Trim();

            if (string.IsNullOrEmpty(tenDangNhap))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (AppDbContext db = new AppDbContext())
            {
                TaiKhoan tk = db.taikhoans.FirstOrDefault(x => x.tendangnhap == tenDangNhap);

                if (tk == null)
                {
                    MessageBox.Show("Tài khoản không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(tk.somay))
                {
                    MessageBox.Show("Tài khoản không đang hoạt động ở máy nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ttMayTram may = db.ttMayTrams.FirstOrDefault(x => x.somay == tk.somay && x.trangthai == "Đang mở");

                if (may == null)
                {
                    MessageBox.Show("Tài khoản không đang hoạt động!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int tongTien = gioHang.Sum(x => x.Value.sl * x.Value.gia);

                // Lưu vào lịch sử nạp tiền với ghi chú thanh toán dịch vụ
                lichsunaptien ls = new lichsunaptien();
                ls.tendangnhap = tenDangNhap;
                ls.sotiennap = tongTien;
                ls.thoigiannap = DateTime.Now;
                ls.ghichu = "Thanh toán dịch vụ ăn uống";

                db.lichsunaptiens.Add(ls);
                db.SaveChanges();

                MessageBox.Show(
                    string.Format("Gọi món thành công!\nTài khoản: {0}\nMáy: {1}\nTổng tiền: {2:N0}đ",
                        tenDangNhap, may.tenmay, tongTien),
                    "Thành công",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                this.Close();
            }
        }
    }
}