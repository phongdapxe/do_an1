using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;


namespace WinFormsApp1
{

    public partial class frmbaocao : Form
    {
        public frmbaocao()
        {
            InitializeComponent();
            datetime1.Format = DateTimePickerFormat.Custom;
            datetime1.CustomFormat = "'Ngày' dd 'tháng' MM 'năm' yyyy";

            datetime2.Format = DateTimePickerFormat.Custom;
            datetime2.CustomFormat = "'Ngày' dd 'tháng' MM 'năm' yyyy";

            datetime3.Format = DateTimePickerFormat.Custom;
            datetime3.CustomFormat = " HH : mm : ss ";
            datetime3.ShowUpDown = true;

            datetime4.Format = DateTimePickerFormat.Custom;
            datetime4.CustomFormat = " HH : mm : ss ";
            datetime4.ShowUpDown = true;
        }

        // Trong frmbaocao.cs
        private void btnxacnhanbaocao_Click(object sender, EventArgs e)
        {
            DateTime tuNgay = datetime1.Value.Date + datetime3.Value.TimeOfDay;
            DateTime denNgay = datetime2.Value.Date + datetime4.Value.TimeOfDay;

            if (tuNgay > denNgay)
            {
                MessageBox.Show("Thời gian bắt đầu phải nhỏ hơn thời gian kết thúc!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            frmketquabaocao fKq = new frmketquabaocao(tuNgay, denNgay);
            fKq.ShowDialog();
        }

        private void btnxuatbaocao_Click(object sender, EventArgs e)
        {
            DateTime tuNgay = datetime1.Value.Date + datetime3.Value.TimeOfDay;
            DateTime denNgay = datetime2.Value.Date + datetime4.Value.TimeOfDay;

            if (tuNgay > denNgay)
            {
                MessageBox.Show("Thời gian không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (AppDbContext db = new AppDbContext())
            {
                List<lichsunaptien> ketQua = db.lichsunaptiens
                    .Where(x => x.thoigiannap >= tuNgay && x.thoigiannap <= denNgay
                             && (x.ghichu == "Nạp tiền tại quầy" || x.ghichu == "Thanh toán dịch vụ ăn uống"))
                    .OrderByDescending(x => x.thoigiannap)
                    .ToList();

                if (ketQua.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu!", "Thông báo");
                    return;
                }

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel Files|*.xlsx";
                sfd.FileName = string.Format("BaoCao_{0:ddMMyyyy}.xlsx", DateTime.Now);
                if (sfd.ShowDialog() != DialogResult.OK) return;

                ClosedXML.Excel.XLWorkbook wb = new ClosedXML.Excel.XLWorkbook();
                ClosedXML.Excel.IXLWorksheet ws = wb.Worksheets.Add("Doanh thu");

                // Header
                ws.Cell(1, 1).Value = "Tên tài khoản";
                ws.Cell(1, 2).Value = "Ngày giờ";
                ws.Cell(1, 3).Value = "Số tiền";
                ws.Cell(1, 4).Value = "Ghi chú";
                ws.Range(1, 1, 1, 4).Style.Font.Bold = true;

                // Dữ liệu
                for (int i = 0; i < ketQua.Count; i++)
                {
                    ws.Cell(i + 2, 1).Value = ketQua[i].tendangnhap;
                    ws.Cell(i + 2, 2).Value = ketQua[i].thoigiannap.ToString("dd/MM/yyyy HH:mm");
                    ws.Cell(i + 2, 3).Value = ketQua[i].sotiennap;
                    ws.Cell(i + 2, 4).Value = ketQua[i].ghichu;
                }

                // Tổng cộng
                int dongTong = ketQua.Count + 2;
                ws.Cell(dongTong, 1).Value = "TỔNG CỘNG";
                ws.Cell(dongTong, 3).Value = ketQua.Sum(x => x.sotiennap);
                ws.Range(dongTong, 1, dongTong, 4).Style.Font.Bold = true;

                ws.Columns().AdjustToContents();
                wb.SaveAs(sfd.FileName);

                MessageBox.Show("Xuất thành công!\n" + sfd.FileName, "Thành công");
            }
        }

    }

}

