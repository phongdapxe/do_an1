using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic;

namespace WinFormsApp1
{
    public partial class dichvu : Form
    {
        Dictionary<string, (int sl, int gia)> gioHang = new();
        Dictionary<string, string> gioHangAnh = new();

        public dichvu()
        {
            InitializeComponent();
        }

        private void dichvu_Load(object sender, EventArgs e)
        {
            loadMenu();
        }

        void loadMenu()
        {
            flpmenu.Controls.Clear();

            // --- TẠO MENU CHUỘT PHẢI ---
            ContextMenuStrip menuChuotPhai = new ContextMenuStrip();
            ToolStripMenuItem itemSua = new ToolStripMenuItem("Sửa món này");
            ToolStripMenuItem itemXoa = new ToolStripMenuItem("Xóa món này");

            menuChuotPhai.Items.AddRange(new ToolStripItem[] { itemSua, itemXoa });

            using (AppDbContext db = new AppDbContext())
            {
                string folderPath = Path.Combine(Application.StartupPath, "Images");
                List<menudichvu> dsMon = db.menudichvus.ToList();

                foreach (var m in dsMon)
                {
                    // 1. Tạo Panel bao ngoài
                    Panel p = new Panel
                    {
                        Size = new Size(170, 230),
                        BorderStyle = BorderStyle.FixedSingle,
                        Margin = new Padding(10),
                        Tag = m.tenmon 
                    };

                    p.ContextMenuStrip = menuChuotPhai;

                    PictureBox pic = new PictureBox { Size = new Size(160, 110), Location = new Point(5, 5), SizeMode = PictureBoxSizeMode.StretchImage };

                    if (!string.IsNullOrEmpty(m.hinhanh))
                    {
                        string fullPath = Path.Combine(folderPath, m.hinhanh);
                        if (File.Exists(fullPath))
                        {
                            try
                            {
                                using (FileStream fs = new FileStream(fullPath, FileMode.Open, FileAccess.Read))
                                {
                                    MemoryStream ms = new MemoryStream();
                                    fs.CopyTo(ms);
                                    ms.Position = 0;
                                    pic.Image = Image.FromStream(ms);
                                }
                            }
                            catch { pic.BackColor = Color.LightGray; }
                        }
                        else pic.BackColor = Color.LightGray;
                    }

                    Label lblName = new Label { Text = m.tenmon, Location = new Point(5, 120), AutoSize = true, Font = new Font(this.Font, FontStyle.Bold) };

                    Label lblPrice = new Label { Text = m.dongia.ToString("N0") + "đ", Location = new Point(5, 140), ForeColor = Color.Red };

                    Button btnGiam = new Button { Text = "-", Size = new Size(35, 35), Location = new Point(5, 170) };
                    Label lblQty = new Label { Text = "0", Size = new Size(45, 25), Location = new Point(40, 175), TextAlign = ContentAlignment.MiddleCenter, BorderStyle = BorderStyle.Fixed3D };
                    Button btnTang = new Button { Text = "+", Size = new Size(35, 35), Location = new Point(85, 170) };

                    btnTang.Click += (s, e) =>
                    {
                        int q = int.Parse(lblQty.Text) + 1;
                        lblQty.Text = q.ToString();
                        CapNhatGioHang(m.tenmon, q, m.dongia, m.hinhanh);
                    };

                    btnGiam.Click += (s, e) =>
                    {
                        int q = int.Parse(lblQty.Text);
                        if (q > 0)
                        {
                            q--;
                            lblQty.Text = q.ToString();
                            CapNhatGioHang(m.tenmon, q, m.dongia, m.hinhanh);
                        }
                    };

                    p.Controls.Add(pic);
                    p.Controls.Add(lblName);
                    p.Controls.Add(lblPrice);
                    p.Controls.Add(btnGiam);
                    p.Controls.Add(lblQty);
                    p.Controls.Add(btnTang);

                    flpmenu.Controls.Add(p);
                }
            }


            itemSua.Click += (s, e) =>
            {
                Control c = menuChuotPhai.SourceControl;
                if (c != null && c.Tag != null)
                {
                    string tenMon = c.Tag.ToString();

                    string inputGia = Interaction.InputBox($"Nhập giá mới cho món '{tenMon}':", "Sửa Giá", "0");

                    if (string.IsNullOrEmpty(inputGia)) return;

                    string inputSL = Interaction.InputBox($"Nhập số lượng tồn kho mới cho '{tenMon}':", "Sửa Số Lượng", "0");

                    if (string.IsNullOrEmpty(inputSL)) return;

                    // Cập nhật vào SQL
                    try
                    {
                        int giaMoi = int.Parse(inputGia);
                        int slMoi = int.Parse(inputSL);

                        using (AppDbContext db = new AppDbContext())
                        {
                            menudichvu mon = db.menudichvus.FirstOrDefault(m => m.tenmon == tenMon);
                            if (mon != null)
                            {
                                mon.dongia = giaMoi;
                                mon.soluong = slMoi;
                                db.SaveChanges();

                                MessageBox.Show("Cập nhật thành công rồi ku!");
                                loadMenu(); 
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Ku nhập số sai định dạng rồi, kiểm tra lại đi!");
                    }
                }
            };

            itemXoa.Click += (s, e) =>
            {
                Control c = menuChuotPhai.SourceControl;
                if (c != null && c.Tag != null)
                {
                    string tenMon = c.Tag.ToString();

                    DialogResult result = MessageBox.Show($"Ku có chắc muốn xóa món '{tenMon}' không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            using (AppDbContext db = new AppDbContext())
                            {
                                menudichvu mon = db.menudichvus.FirstOrDefault(m => m.tenmon == tenMon);
                                if (mon != null)
                                {
                                    if (!string.IsNullOrEmpty(mon.hinhanh))
                                    {
                                        string pathAnh = Path.Combine(Application.StartupPath, "Images", mon.hinhanh);
                                        if (File.Exists(pathAnh))
                                        {

                                        }
                                    }

                                    db.menudichvus.Remove(mon);
                                    db.SaveChanges();

                                    MessageBox.Show($"Đã tiễn món '{tenMon}' lên đường thành công!");
                                    loadMenu();
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                        }
                    }
                }
            };
        }

        void CapNhatGioHang(string ten, int sl, int gia, string hinhanh)
        {
            if (sl == 0)
            {
                gioHang.Remove(ten);
                gioHangAnh.Remove(ten);
            }
            else
            {
                gioHang[ten] = (sl, gia);
                gioHangAnh[ten] = hinhanh;
            }
            VeGioHang();
            TinhTongTien();
        }

        void VeGioHang()
        {
            List<Panel> toRemove = pnlOrder.Controls.OfType<Panel>().ToList();
            foreach (Panel c in toRemove)
                pnlOrder.Controls.Remove(c);

            int tongMon = gioHang.Count;
            int y = pnlOrder.Height - (tongMon * 68) - 0;
            if (y < 5) y = 5;

            string folderPath = Path.Combine(Application.StartupPath, "Images");

            foreach (KeyValuePair<string, (int sl, int gia)> item in gioHang.Reverse())
            {
                string ten = item.Key;
                int sl = item.Value.sl;
                int gia = item.Value.gia;

                Panel row = new Panel
                {
                    Size = new Size(215, 65),
                    Location = new Point(3, y),
                    BackColor = Color.White
                };

                PictureBox pic = new PictureBox
                {
                    Size = new Size(55, 55),
                    Location = new Point(2, 4),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    BackColor = Color.LightGray
                };

                if (gioHangAnh.ContainsKey(ten))
                {
                    string fullPath = Path.Combine(folderPath, gioHangAnh[ten]);
                    if (File.Exists(fullPath))
                        try
                        {
                            using (FileStream fs = new FileStream(fullPath, FileMode.Open, FileAccess.Read))
                            {
                                MemoryStream ms = new MemoryStream();
                                fs.CopyTo(ms);
                                ms.Position = 0;
                                pic.Image = Image.FromStream(ms);
                            }
                        }
                        catch { }
                }

                Label lblTen = new Label
                {
                    Text = ten,
                    Location = new Point(62, 3),
                    Size = new Size(150, 18),
                    Font = new Font("Segoe UI", 8, FontStyle.Bold),
                    AutoEllipsis = true,
                    AutoSize = false
                };

                Label lblChiTiet = new Label
                {
                    Text = string.Format("{0} x {1:N0}đ", sl, gia),
                    Location = new Point(62, 23),
                    Size = new Size(148, 16),
                    ForeColor = Color.Gray,
                    Font = new Font("Segoe UI", 7.5f),
                    AutoSize = false
                };

                Label lblTong = new Label
                {
                    Text = (sl * gia).ToString("N0") + "đ",
                    Location = new Point(62, 42),
                    Size = new Size(148, 16),
                    TextAlign = ContentAlignment.MiddleRight,
                    ForeColor = Color.Red,
                    Font = new Font("Segoe UI", 8, FontStyle.Bold),
                    AutoSize = false
                };

                Panel line = new Panel
                {
                    Size = new Size(215, 1),
                    Location = new Point(0, 64),
                    BackColor = Color.LightGray
                };

                row.Controls.Add(pic);
                row.Controls.Add(lblTen);
                row.Controls.Add(lblChiTiet);
                row.Controls.Add(lblTong);
                row.Controls.Add(line);
                pnlOrder.Controls.Add(row);
                y += 68;
            }
        }

        void TinhTongTien()
        {
            int tong = gioHang.Sum(x => x.Value.sl * x.Value.gia);
            lblTongTien.Text = tong.ToString("N0") + "đ";
        }

        private void dichvu_Load_1(object sender, EventArgs e)
        {
            loadMenu();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void lblTongTien_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (gioHang.Count == 0)
            {
                MessageBox.Show("Chưa chọn món nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (AppDbContext db = new AppDbContext())
            {
                List<menudichvu> dsMon = db.menudichvus.ToList();
                string thongBaoLoi = "";

                foreach (KeyValuePair<string, (int sl, int gia)> item in gioHang)
                {
                    menudichvu mon = dsMon.FirstOrDefault(x => x.tenmon == item.Key);
                    if (mon != null && item.Value.sl > mon.soluong)
                    {
                        thongBaoLoi += string.Format("- {0}: chỉ còn {1} cái, bạn gọi {2}\n",
                            item.Key, mon.soluong, item.Value.sl);
                    }
                }

                if (!string.IsNullOrEmpty(thongBaoLoi))
                {
                    MessageBox.Show("Số lượng không đủ, vui lòng chọn lại:\n\n" + thongBaoLoi,
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            xacnhanorder formXacNhan = new xacnhanorder(gioHang);
            formXacNhan.ShowDialog();
        }

        private void btnthemmon_Click(object sender, EventArgs e)
        {
            using (themmonmoi fThem = new themmonmoi())
            {
                if (fThem.ShowDialog() == DialogResult.OK)
                {
                    loadMenu();
                }
            }
        }
    }
}