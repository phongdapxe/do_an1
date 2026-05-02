using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class frmNapTien : Form
    {
        public frmNapTien()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtsotien.Text, out int tienNap))
                {
                    MessageBox.Show("Vui lòng nhập số tiền hợp lệ!");
                    return;
                }

                // Kiểm tra quyền nhân viên không được nạp tiền âm hoặc = 0
                if (!SessionInfo.IsAdmin() && tienNap <= 0)
                {
                    MessageBox.Show("Bạn không có quyền thực hiện chức năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (AppDbContext db = new AppDbContext())
                {
                    string ten = txttendn.Text.Trim();
                    TaiKhoan tk = db.taikhoans.Find(ten);
                    if (tk != null)
                    {
                        tk.sodu += tienNap;
                        tk.tongtiennap += tienNap;

                        lichsunaptien ls = new lichsunaptien();
                        ls.tendangnhap = ten;
                        ls.sotiennap = tienNap;
                        ls.thoigiannap = DateTime.Now;
                        ls.ghichu = "Nạp tiền tại quầy";
                        db.lichsunaptiens.Add(ls);

                        db.SaveChanges();
                        if (tienNap > 0)
                        {
                            MessageBox.Show(string.Format("Đã nạp thành công {0:N0}đ cho tài khoản {1}", tienNap, ten));

                        }
                        else
                        {
                            MessageBox.Show(string.Format("Đã trừ thành công {0:N0}đ cho tài khoản {1}", -tienNap, ten));
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy tài khoản này trong hệ thống!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nạp tiền: " + ex.Message);
            }
        }
    }
}