using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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
                // 1. Kiểm tra xem tiền nhập vào có phải là số không
                if (!int.TryParse(txtsotien.Text, out int tienNap))
                {
                    MessageBox.Show("Vui lòng nhập số tiền hợp lệ ku ơi!");
                    return;
                }

                using (AppDbContext db = new AppDbContext())
                {
                    string ten = txttendn.Text.Trim();

                    // 2. Tìm tài khoản trong DB theo kiểu cũ của ku
                    TaiKhoan tk = db.taikhoans.Find(ten);

                    if (tk != null)
                    {
                        // 3. Thực hiện cộng tiền
                        tk.sodu += tienNap;
                        tk.tongtiennap += tienNap;
                        db.SaveChanges();

                        MessageBox.Show($"Đã nạp thành công {tienNap:N0}đ cho tài khoản {ten}");

                        // 4. Báo cho Form1 biết là nạp thành công để load lại bảng
                        this.DialogResult = DialogResult.OK;
                        this.Close();
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
