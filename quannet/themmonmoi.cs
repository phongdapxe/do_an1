using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WinFormsApp1
{
    public partial class themmonmoi : Form
    {
        // Biến lưu đường dẫn ảnh từ máy tính (Desktop, Downloads...)
        string duongDanAnhChon = "";

        public themmonmoi()
        {
            InitializeComponent();
            // Đảm bảo ảnh hiện lên không bị méo
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        // Nút chọn ảnh
        private void btnchonanh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                duongDanAnhChon = open.FileName;
                // Load ảnh lên khung để ku xem trước
                using (FileStream fs = new FileStream(duongDanAnhChon, FileMode.Open, FileAccess.Read))
                {
                    pictureBox1.Image = Image.FromStream(fs);
                }
            }
        }

        // Nút Xác nhận thêm món
        private void btnxnthemmon_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra trống
            if (string.IsNullOrEmpty(txtthemtenmon.Text) || string.IsNullOrEmpty(txtthemsl.Text))
            {
                MessageBox.Show("Điền đủ Tên món đi ku!", "Nhắc nhở");
                return;
            }

            try
            {
                using (AppDbContext db = new AppDbContext())
                {

                    // 3. Kiểm tra trùng Tên món
                    string tenMoi = txtthemtenmon.Text.Trim();
                    if (db.menudichvus.Any(m => m.tenmon.ToLower() == tenMoi.ToLower()))
                    {
                        MessageBox.Show("Tên món này có rồi, không được đặt trùng!", "Lỗi trùng");
                        return;
                    }

                    // 4. Xử lý copy ảnh vào thư mục Debug\Images
                    string tenFileAnh = "";
                    if (!string.IsNullOrEmpty(duongDanAnhChon))
                    {
                        // Lấy đường dẫn: ...\bin\Debug\net10.0-windows\Images
                        string thuMucDich = Path.Combine(Application.StartupPath, "Images");

                        if (!Directory.Exists(thuMucDich))
                            Directory.CreateDirectory(thuMucDich);

                        tenFileAnh = Path.GetFileName(duongDanAnhChon);
                        string duongDanFull = Path.Combine(thuMucDich, tenFileAnh);

                        // Copy đè nếu đã có file trùng tên trong thư mục dự án
                        File.Copy(duongDanAnhChon, duongDanFull, true);
                    }

                    // 5. Lưu vào SQL
                    menudichvu mon = new menudichvu();
                    mon.tenmon = tenMoi;
                    mon.soluong = int.Parse(txtthemsl.Text);
                    mon.dongia = int.Parse(txtthemdongia.Text);
                    mon.hinhanh = tenFileAnh; // Chỉ lưu cái tên file "ronaldo.jpg" thôi

                    db.menudichvus.Add(mon);
                    db.SaveChanges();

                    MessageBox.Show("Thêm món mới thành công rực rỡ!");

                    // Trả kết quả về cho Form Dịch vụ
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}