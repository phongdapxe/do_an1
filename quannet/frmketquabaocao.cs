using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class frmketquabaocao : Form
    {
        public frmketquabaocao(DateTime tuNgay, DateTime denNgay)
        {
            InitializeComponent();
            LoadBaoCao(tuNgay, denNgay);
        }
        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            string stt = (e.RowIndex + 1).ToString();
            using (SolidBrush brush = new SolidBrush(Color.Black))
            {
                e.Graphics.DrawString(stt, this.Font, brush, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + 4);
            }
        }

        void LoadBaoCao(DateTime tuNgay, DateTime denNgay)
        {
            using (AppDbContext db = new AppDbContext())
            {
                List<lichsunaptien> ketQua = db.lichsunaptiens
                    .Where(x => x.thoigiannap >= tuNgay && x.thoigiannap <= denNgay
                             && (x.ghichu == "Nạp tiền tại quầy" || x.ghichu == "Thanh toán dịch vụ ăn uống"))
                    .OrderByDescending(x => x.thoigiannap)
                    .ToList();

                dgvketqua.AutoGenerateColumns = false;
                dgvketqua.DataSource = null;
                dgvketqua.DataSource = ketQua;

                if (dgvketqua.Columns["cotNgayGio"] != null)
                    dgvketqua.Columns["cotNgayGio"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
                if (dgvketqua.Columns["cotSoTien"] != null)
                    dgvketqua.Columns["cotSoTien"].DefaultCellStyle.Format = "N0";

                int tongCong = ketQua.Sum(x => x.sotiennap);
                lbltongdoanhthu.Text = string.Format("Tổng doanh thu: {0:N0}đ", tongCong);
                lbltongdoanhthu.ForeColor = Color.Red;
                lbltongdoanhthu.Font = new Font(lbltongdoanhthu.Font, FontStyle.Bold);
            }
        }
        private void btnxacnhanbc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}