using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class frmdoimk : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string TenTaiKhoan { get; set; }
        public frmdoimk()
        {
            InitializeComponent();
        }

        private void btnxacnhandmk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtpasscu.Text) || string.IsNullOrEmpty(txtpassmoi.Text))
            {
                MessageBox.Show("Nhập đủ cả pass cũ và mới đi ku!");
                return;
            }

            using (AppDbContext db_mk = new AppDbContext())
            {
                // 2. Tìm tài khoản
                TaiKhoan tk = db_mk.taikhoans.Find(TenTaiKhoan);

                if (tk != null)
                {
                    // 3. Kiểm tra pass cũ có khớp không
                    if (tk.matkhau != txtpasscu.Text.Trim())
                    {
                        MessageBox.Show("Mật khẩu cũ sai rồi ku ơi!");
                        return;
                    }

                    // 4. Cập nhật pass mới
                    tk.matkhau = txtpassmoi.Text.Trim();
                    db_mk.SaveChanges();

                    MessageBox.Show("Đổi mật khẩu thành công!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
    }
}
