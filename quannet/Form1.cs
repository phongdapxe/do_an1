using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        AppDbContext db = new AppDbContext();

        public Form1()
        {
            InitializeComponent();

        }

        void ApplyQuyen()
        {
            if (!SessionInfo.IsAdmin())
            {
                // Tab tài khoản: chặn xóa và đổi mật khẩu
                xóaTàiKhoảnToolStripMenuItem.Click -= xóaTàiKhoảnToolStripMenuItem_Click;
                xóaTàiKhoảnToolStripMenuItem.Click += (s, e) =>
                    MessageBox.Show("Bạn không có quyền thực hiện chức năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                đổiMậtKhẩuToolStripMenuItem.Click -= đổiMậtKhẩuToolStripMenuItem_Click;
                đổiMậtKhẩuToolStripMenuItem.Click += (s, e) =>
                    MessageBox.Show("Bạn không có quyền thực hiện chức năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Chặn tạo tài khoản
                btntaotaikhoan.Click -= btntaotaikhoan_Click;
                btntaotaikhoan.Click += (s, e) =>
                    MessageBox.Show("Bạn không có quyền thực hiện chức năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loaddata();
            loadtaikhoan();
            ApplyQuyen();

            txttimkiem.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnsearch_Click(s, e);
                    //tắt âm thanh như kiểu báo lỗi 
                    e.SuppressKeyPress = true;
                }
            };

            txtlichsu.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btntimkiemls_Click(s, e);
                    e.SuppressKeyPress = true;
                }
            };


            txttimdsls.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btntimls_Click(s, e);
                    e.SuppressKeyPress = true;
                }
            };
        }

        // Hàm này chỉ để load dữ liệu lên các bảng
        void loaddata()
        {
            try
            {
                // 1. DÒNG QUAN TRỌNG NHẤT: Khóa không cho bảng tự chế cột mới
                dgvmaytram.AutoGenerateColumns = false;

                // Tạo db mới để lấy dữ liệu tươi từ SQL (giống bên Tab 2)
                using (AppDbContext db_fresh = new AppDbContext())
                {
                    List<ttMayTram> danhSachMay = db_fresh.ttMayTrams.ToList();
                    List<TaiKhoan> danhSachTK = db_fresh.taikhoans.ToList();

                    foreach (ttMayTram may in danhSachMay)
                    {
                        may.tendangnhap = "";
                        may.sodu = 0;
                        may.batdauluc = null;
                        may.thoigianchoi = "00:00";

                        foreach (TaiKhoan tk in danhSachTK)
                        {
                            if (tk.somay != null && may.somay.Trim() == tk.somay.Trim())
                            {
                                may.tendangnhap = tk.tendangnhap ?? "";
                                may.sodu = tk.sodu;
                                may.batdauluc = tk.batdauluc;
                                if (tk.batdauluc != null)
                                {
                                    TimeSpan span = DateTime.Now - tk.batdauluc.Value;
                                    // Hiện định dạng HH:mm (ví dụ 00:15 là chơi được 15 phút)
                                    may.thoigianchoi = string.Format("{0:00}:{1:00}", (int)span.TotalHours, span.Minutes);
                                }
                                break;
                            }
                        }
                    }

                    // 2. Gán dữ liệu (Lúc này các cột sửa tay trong Design sẽ được giữ nguyên)
                    dgvmaytram.DataSource = null;
                    dgvmaytram.DataSource = danhSachMay;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        void loadtaikhoan()
        {
            try
            {
                // Tạo một kết nối mới tinh để "ép" nó lấy dữ liệu mới nhất từ SQL
                using (AppDbContext db_moi = new AppDbContext())
                {
                    dgvtaikhoan.AutoGenerateColumns = false;

                    // Lấy dữ liệu mới nhất
                    List<TaiKhoan> danhSach = db_moi.taikhoans.ToList();

                    // Reset bảng về null trước khi gán lại (chiêu này cực kỳ quan trọng)
                    dgvtaikhoan.DataSource = null;
                    dgvtaikhoan.DataSource = danhSach;

                    // Định dạng tiền (Giữ nguyên các dòng cũ của )
                    if (dgvtaikhoan.Columns["cotsodu"] != null)
                        dgvtaikhoan.Columns["cotsodu"].DefaultCellStyle.Format = "N0";
                    if (dgvtaikhoan.Columns["tongnap"] != null)
                        dgvtaikhoan.Columns["tongnap"].DefaultCellStyle.Format = "N0";
                    if (dgvtaikhoan.Columns["tiendadung"] != null)
                        dgvtaikhoan.Columns["tiendadung"].DefaultCellStyle.Format = "N0";

                    dgvtaikhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            loaddata();
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void btnNapTien_Click(object sender, EventArgs e)
        {
            frmNapTien popup = new frmNapTien();
            if (popup.ShowDialog() == DialogResult.OK)
            {
                loaddata();
            }
        }

        // Nút Tạo tài khoản: Tương tự nạp tiền, mở form mới
        private void btnTaoTK_Click(object sender, EventArgs e)
        {
            frmTaoTK popup = new frmTaoTK();
            if (popup.ShowDialog() == DialogResult.OK)
            {
                loaddata();
            }
        }

        private void dgvmaytram_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvmaytram.Columns[e.ColumnIndex].Name == "trangthai" && e.Value != null)
            {
                string tt = e.Value.ToString();
                if (tt == "Đang mở")
                {
                    e.CellStyle.ForeColor = Color.Green;
                    e.CellStyle.Font = new Font(dgvmaytram.Font, FontStyle.Bold);
                }
                else if (tt == "Tắt")
                {
                    e.CellStyle.ForeColor = Color.Red;
                }
            }
        }

        private void mởMáyĐăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvmaytram.CurrentRow == null) return;

            string trangThai = dgvmaytram.CurrentRow.Cells["trangthai"].Value.ToString();
            if (trangThai == "Đang mở")
            {
                MessageBox.Show("Máy này đang có người ngồi rồi!");
                return;
            }

            // Gọi cái Form mở máy mới tạo
            formmomay fMo = new formmomay();
            if (fMo.ShowDialog() == DialogResult.OK)
            {
                string soMay = dgvmaytram.CurrentRow.Cells["somay"].Value.ToString();

                // Tìm đối tượng trong DB để cập nhật
                TaiKhoan tk = db.taikhoans.Find(fMo.TenKhach);
                ttMayTram may = db.ttMayTrams.Find(soMay);

                if (tk != null && may != null)
                {
                    tk.somay = soMay;
                    tk.batdauluc = DateTime.Now;
                    may.trangthai = "Đang mở";

                    db.SaveChanges();
                    db = new AppDbContext();
                    loaddata();
                    MessageBox.Show("Mở máy thành công!");
                }
            }
        }

        private void nạpTiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNapTien fNap = new frmNapTien();

            if (dgvmaytram.CurrentRow != null && dgvmaytram.CurrentRow.Cells["tendangnhap"].Value != null)
            {
                fNap.txttendn.Text = dgvmaytram.CurrentRow.Cells["tendangnhap"].Value.ToString();
            }

            if (fNap.ShowDialog() == DialogResult.OK)
            {
                db = new AppDbContext();
                loaddata();
            }
        }

        private void đăngXuấtTắtMáyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvmaytram.CurrentRow == null || dgvmaytram.CurrentRow.Cells["somay"].Value == null) return;
            string soMay = dgvmaytram.CurrentRow.Cells["somay"].Value.ToString();
            string trangThai = dgvmaytram.CurrentRow.Cells["trangthai"].Value.ToString();

            if (trangThai == "Tắt")
            {
                MessageBox.Show("Máy này đang tắt sẵn rồi!");
                return;
            }

            if (MessageBox.Show($"Xác nhận cho khách máy {soMay} nghỉ?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (AppDbContext db_out = new AppDbContext())
                {
                    var tk = db_out.taikhoans.FirstOrDefault(t => t.somay.Trim() == soMay.Trim());
                    var may = db_out.ttMayTrams.Find(soMay);

                    if (may != null)
                    {
                        may.trangthai = "Tắt";

                        if (tk != null)
                        {
                            // Tính thời gian và tiền đã chơi
                            DateTime batDau = tk.batdauluc ?? DateTime.Now;
                            DateTime ketThuc = DateTime.Now;
                            TimeSpan span = ketThuc - batDau;
                            string thoiGianChoi = string.Format("{0:00}:{1:00}", (int)span.TotalHours, span.Minutes);
                            int sotienchu = (int)(span.TotalMinutes * (10000.0 / 60.0));

                            // Lưu lịch sử giờ chơi
                            lichsugiochoi ls = new lichsugiochoi();
                            ls.tendangnhap = tk.tendangnhap;
                            ls.somay = soMay.Trim();
                            ls.batdauluc = batDau;
                            ls.ketthuc = ketThuc;
                            ls.thoigianchoi = thoiGianChoi;
                            ls.sotienchu = sotienchu;
                            db_out.lichsugiochois.Add(ls);

                            // Reset taikhoan như cũ
                            tk.somay = null;
                            tk.batdauluc = null;
                        }

                        db_out.SaveChanges();
                        loaddata();
                        loadtaikhoan();
                        MessageBox.Show($"Máy {soMay} đã đăng xuất. Tiền đã được hệ thống tự động cập nhật xong!");
                    }
                }
            }
        }

        private void btndanhsach_Click(object sender, EventArgs e)
        {
            txttimkiem.Text = "";
            loadtaikhoan();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            using (AppDbContext db = new AppDbContext())
            {
                string tenCanTim = txttimkiem.Text.Trim().ToLower();

                if (string.IsNullOrEmpty(tenCanTim))
                {
                    MessageBox.Show("Nhập tên khách cần tìm đã ơi!");
                    return;
                }

                var ketQua = db.taikhoans
                               .Where(t => t.tendangnhap.ToLower().Contains(tenCanTim))
                               .ToList();

                dgvtaikhoan.DataSource = ketQua;

                if (ketQua.Count == 0)
                {
                    MessageBox.Show("chả có thằng nào tên thế cả!");
                }
            }
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void nạpTiềnToolStripMenuItem_tab2__Click(object sender, EventArgs e)
        {
            if (dgvtaikhoan.CurrentRow == null) return;
            string tenkhach = dgvtaikhoan.CurrentRow.Cells["cottendn"].Value.ToString();

            frmNapTien fNap = new frmNapTien();
            fNap.txttendn.Text = tenkhach;
            fNap.txttendn.Enabled = true;

            if (fNap.ShowDialog() == DialogResult.OK)
            {
                db = new AppDbContext();
                loadtaikhoan();
                loaddata();
            }
        }

        private void xóaTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvtaikhoan.CurrentRow == null) return;

            string user = dgvtaikhoan.CurrentRow.Cells["cottendn"].Value.ToString();

            DialogResult dr = MessageBox.Show("Xóa thằng " + user + " là mất hết tiền của nó đó, chắc chưa?", "Xác nhận", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                using (AppDbContext db_xoa = new AppDbContext())
                {
                    TaiKhoan tk = db_xoa.taikhoans.Find(user);
                    if (tk != null)
                    {
                        db_xoa.taikhoans.Remove(tk);
                        db_xoa.SaveChanges();
                        loadtaikhoan();
                        MessageBox.Show("Đã tiễn thằng " + user + " lên đường!");
                    }
                }
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                loaddata();
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                loadtaikhoan();
            }

            else if (tabControl1.SelectedIndex == 2)
            {
                loadlichsu();
            }
            else if (tabControl1.SelectedIndex == 3) // hoặc số index tabpage giờ chơi
            {
                loadlstime();
            }
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvtaikhoan.CurrentRow == null || dgvtaikhoan.CurrentRow.Cells[0].Value == null) return;

            string user = dgvtaikhoan.CurrentRow.Cells[0].Value.ToString();

            frmdoimk fDoi = new frmdoimk();
            fDoi.TenTaiKhoan = user;

            fDoi.txttentk.Text = user;
            fDoi.txttentk.Enabled = true;

            if (fDoi.ShowDialog() == DialogResult.OK)
            {
                loadtaikhoan();
            }
        }

        private void btntaotaikhoan_Click(object sender, EventArgs e)
        {
            frmTaoTK f = new frmTaoTK();

            if (f.ShowDialog() == DialogResult.OK)
            {
                tabControl1.SelectedIndex = 1;

                loadtaikhoan();
            }
        }

        private void btntrangchu_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            loaddata();
        }

        private void btntaikhoan_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            loadtaikhoan();
        }

        private void btnnaptien_Click_1(object sender, EventArgs e)
        {
            frmNapTien fNap = new frmNapTien();

            if (tabControl1.SelectedIndex == 1 && dgvtaikhoan.CurrentRow != null)
            {
                if (dgvtaikhoan.CurrentRow.Cells[0].Value != null)
                {
                    fNap.txttendn.Text = dgvtaikhoan.CurrentRow.Cells[0].Value.ToString();
                }
            }

            if (fNap.ShowDialog() == DialogResult.OK)
            {
                loaddata();
                loadtaikhoan();
            }
        }

        private void timertinhtien_Tick(object sender, EventArgs e)
        {
            using (AppDbContext db_auto = new AppDbContext())
            {
                List<TaiKhoan> dsDangChoi = db_auto.taikhoans.Where(t => t.somay != null && t.somay != "").ToList();

                foreach (TaiKhoan tk in dsDangChoi)
                {
                    int tienMotPhut = (int)(10000.0 / 60.0);

                    tk.sodu -= tienMotPhut;
                    tk.tongtiendung += tienMotPhut;

                    if (tk.sodu <= 500)
                    {
                        var may = db_auto.ttMayTrams.Find(tk.somay.Trim());
                        if (may != null)
                        {
                            may.trangthai = "Tắt";
                            tk.somay = null;
                            tk.batdauluc = null;
                        }
                    }
                }

                db_auto.SaveChanges();

                loaddata();
            }
        }

        private void tablsnaptien_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
            loadlichsu();

        }

        public void loadlichsu()
        {
            try
            {
                using (AppDbContext db_ls = new AppDbContext())
                {
                    dgvlichsunap.AutoGenerateColumns = false;

                    var danhSach = db_ls.lichsunaptiens
                                        .OrderByDescending(x => x.thoigiannap)
                                        .ToList();

                    dgvlichsunap.DataSource = null;
                    dgvlichsunap.DataSource = danhSach;

                    // Định dạng cột tiền cho đẹp (giống cách ku làm ở loadtaikhoan)
                    if (dgvlichsunap.Columns["sotiennap"] != null)
                        dgvlichsunap.Columns["sotiennap"].DefaultCellStyle.Format = "N0";

                    if (dgvlichsunap.Columns["time"] != null)
                        dgvlichsunap.Columns["time"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load lịch sử: " + ex.Message);
            }
        }

        private void btntimkiemls_Click(object sender, EventArgs e)
        {
            using (AppDbContext db = new AppDbContext())
            {
                string tenCanTim = txtlichsu.Text.Trim().ToLower();

                if (string.IsNullOrEmpty(tenCanTim))
                {
                    loadlichsu(); // Nếu trống thì hiện lại hết cho sạch
                    return;
                }

                // Code ngắn gọn kiểu ku muốn đây:
                List<lichsunaptien> ketQua = db.lichsunaptiens
                    .Where(ls => ls.tendangnhap.ToLower().Contains(tenCanTim))
                    .OrderByDescending(ls => ls.thoigiannap)
                    .ToList();

                dgvlichsunap.DataSource = ketQua;

                if (ketQua.Count == 0) MessageBox.Show("Chả thấy lịch sử thằng này!");
            }
        }

        private void dgvlichsunap_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }

        private void dgvmaytram_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }

        private void dgvtaikhoan_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }

        private void btndsls_Click(object sender, EventArgs e)
        {
            txtlichsu.Text = "";
            loadlichsu();
        }

        private void btndichvu_Click(object sender, EventArgs e)
        {
            dichvu fdv = new dichvu();

            if (fdv.ShowDialog() == DialogResult.OK)
            {
                tabControl1.SelectedIndex = 1;

            }

        }

        private void btnlstime_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
            loadlstime();

        }

        public void loadlstime()
        {
            try
            {
                using (AppDbContext db_ls = new AppDbContext())
                {
                    dgvlstime.AutoGenerateColumns = false;

                    List<lichsugiochoi> danhSach = db_ls.lichsugiochois
                        .OrderByDescending(x => x.ketthuc)
                        .ToList();

                    dgvlstime.DataSource = null;
                    dgvlstime.DataSource = danhSach;

                    if (dgvlstime.Columns["cotSoTien"] != null)
                        dgvlstime.Columns["cotSoTien"].DefaultCellStyle.Format = "N0";
                    if (dgvlstime.Columns["cotBatDau"] != null)
                        dgvlstime.Columns["cotBatDau"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                    if (dgvlstime.Columns["cotKetThuc"] != null)
                        dgvlstime.Columns["cotKetThuc"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btntimls_Click(object sender, EventArgs e)
        {
            using (AppDbContext db = new AppDbContext())
            {
                string lscantim = txttimdsls.Text.Trim().ToLower();
                if (string.IsNullOrEmpty(lscantim))
                {
                    loadlstime();
                    return;
                }
                List<lichsugiochoi> ketQua = db.lichsugiochois
                    .Where(lsgc => lsgc.tendangnhap.ToLower().Contains(lscantim))
                    .OrderByDescending(lsgc => lsgc.ketthuc)
                    .ToList();
                dgvlstime.DataSource = ketQua;
                if (ketQua.Count == 0) MessageBox.Show("Chả thấy lịch sử thằng này!");
            }
            txttimdsls.Clear();
        }

        private void btldanhsachls_Click(object sender, EventArgs e)
        {
            loadlstime();
        }

        private void btnbaocao_Click(object sender, EventArgs e)
        {
            frmbaocao fbc = new frmbaocao();

            if (fbc.ShowDialog() == DialogResult.OK)
            {
                tabControl1.SelectedIndex = 1;

            }
        }
    }
}