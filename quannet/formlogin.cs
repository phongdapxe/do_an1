using System;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class formlogin : Form
    {
        public formlogin()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string tenNhap = txtuser.Text.Trim();
            string matKhauNhap = txtpass.Text.Trim();

            if (string.IsNullOrEmpty(tenNhap) || string.IsNullOrEmpty(matKhauNhap))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tài khoản và mật khẩu!", "Thông báo");
                return;
            }

            using (AppDbContext db = new AppDbContext())
            {
                TaiKhoanQuanLy tk = db.taikhoanquanlys.FirstOrDefault(x =>
                    x.tendangnhap == tenNhap && x.matkhau == matKhauNhap);

                if (tk == null)
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Thông báo");
                    txtpass.Clear();
                    txtuser.Clear();
                    txtuser.Focus();
                    return;
                }

                // Lưu session
                SessionInfo.TenDangNhap = tk.tendangnhap;
                SessionInfo.VaiTro = tk.vaitro ?? "nhanvien";

                if (SessionInfo.IsAdmin())
                    MessageBox.Show("Chào mừng nhà quản lý đăng nhập!", "Thông báo");
                else
                    MessageBox.Show("Chào mừng nhân viên đăng nhập", "Thông báo");

                Form1 f1 = new Form1();
                this.Hide();
                f1.FormClosed += (s, args) => this.Close();
                f1.Show();
            }
        }
    }
}