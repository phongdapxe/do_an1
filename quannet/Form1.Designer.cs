namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dgvmaytram = new DataGridView();
            somay = new DataGridViewTextBoxColumn();
            tenmay = new DataGridViewTextBoxColumn();
            trangthai = new DataGridViewTextBoxColumn();
            tendangnhap = new DataGridViewTextBoxColumn();
            sodu = new DataGridViewTextBoxColumn();
            thoigian = new DataGridViewTextBoxColumn();
            dasudung = new DataGridViewTextBoxColumn();
            cmsMayTram = new ContextMenuStrip(components);
            mởMáyĐăngNhậpToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtTắtMáyToolStripMenuItem = new ToolStripMenuItem();
            nạpTiềnToolStripMenuItem = new ToolStripMenuItem();
            chinhsuamaytram = new ToolStripMenuItem();
            themmaytram = new ToolStripMenuItem();
            xoamaytram = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            btntrangchu = new ToolStripButton();
            btntaikhoan = new ToolStripButton();
            btnnaptien = new ToolStripButton();
            btntaotaikhoan = new ToolStripButton();
            btnlsnaptien = new ToolStripButton();
            btnlstime = new ToolStripButton();
            btndichvu = new ToolStripButton();
            btnbaocao = new ToolStripButton();
            tabControl1 = new TabControl();
            tabpage1 = new TabPage();
            tabpage2 = new TabPage();
            dgvtaikhoan = new DataGridView();
            cottendn = new DataGridViewTextBoxColumn();
            cotmk = new DataGridViewTextBoxColumn();
            cotsodu = new DataGridViewTextBoxColumn();
            tongnap = new DataGridViewTextBoxColumn();
            tiendadung = new DataGridViewTextBoxColumn();
            cmstaikhoan = new ContextMenuStrip(components);
            nạpTiềnToolStripMenuItem_tab2_ = new ToolStripMenuItem();
            xóaTàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            đổiMậtKhẩuToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            txttimkiem = new TextBox();
            btndanhsach = new Button();
            label1 = new Label();
            btnsearch = new Button();
            tabPage3 = new TabPage();
            panel2 = new Panel();
            label2 = new Label();
            txtlichsu = new TextBox();
            btntimkiemls = new Button();
            btndsls = new Button();
            dgvlichsunap = new DataGridView();
            coltendn = new DataGridViewTextBoxColumn();
            colsotien = new DataGridViewTextBoxColumn();
            coldatetime = new DataGridViewTextBoxColumn();
            colghichu = new DataGridViewTextBoxColumn();
            tabPage4 = new TabPage();
            panel3 = new Panel();
            txttimdsls = new TextBox();
            label3 = new Label();
            btntimls = new Button();
            btldanhsachls = new Button();
            dgvlstime = new DataGridView();
            taikhoan = new DataGridViewTextBoxColumn();
            somay1 = new DataGridViewTextBoxColumn();
            batdau = new DataGridViewTextBoxColumn();
            ketthuc = new DataGridViewTextBoxColumn();
            thoigianchoi = new DataGridViewTextBoxColumn();
            sotien = new DataGridViewTextBoxColumn();
            timertinhtien = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dgvmaytram).BeginInit();
            cmsMayTram.SuspendLayout();
            toolStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabpage1.SuspendLayout();
            tabpage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvtaikhoan).BeginInit();
            cmstaikhoan.SuspendLayout();
            panel1.SuspendLayout();
            tabPage3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvlichsunap).BeginInit();
            tabPage4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvlstime).BeginInit();
            SuspendLayout();
            // 
            // dgvmaytram
            // 
            dgvmaytram.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvmaytram.BackgroundColor = Color.Pink;
            dgvmaytram.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvmaytram.Columns.AddRange(new DataGridViewColumn[] { somay, tenmay, trangthai, tendangnhap, sodu, thoigian, dasudung });
            dgvmaytram.ContextMenuStrip = cmsMayTram;
            dgvmaytram.Dock = DockStyle.Fill;
            dgvmaytram.Location = new Point(3, 3);
            dgvmaytram.Name = "dgvmaytram";
            dgvmaytram.Size = new Size(820, 407);
            dgvmaytram.TabIndex = 2;
            dgvmaytram.CellFormatting += dgvmaytram_CellFormatting;
            dgvmaytram.RowPostPaint += dgvmaytram_RowPostPaint;
            // 
            // somay
            // 
            somay.DataPropertyName = "somay";
            somay.FillWeight = 57.4450035F;
            somay.HeaderText = "số máy trạm";
            somay.Name = "somay";
            // 
            // tenmay
            // 
            tenmay.DataPropertyName = "tenmay";
            tenmay.FillWeight = 57.4450035F;
            tenmay.HeaderText = "tên máy";
            tenmay.Name = "tenmay";
            // 
            // trangthai
            // 
            trangthai.DataPropertyName = "trangthai";
            trangthai.FillWeight = 57.4450035F;
            trangthai.HeaderText = "trạng thái";
            trangthai.Name = "trangthai";
            // 
            // tendangnhap
            // 
            tendangnhap.DataPropertyName = "tendangnhap";
            tendangnhap.FillWeight = 57.4450035F;
            tendangnhap.HeaderText = "người sử dụng";
            tendangnhap.Name = "tendangnhap";
            // 
            // sodu
            // 
            sodu.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            sodu.DataPropertyName = "sodu";
            sodu.FillWeight = 355.329956F;
            sodu.HeaderText = "số dư";
            sodu.Name = "sodu";
            sodu.Width = 80;
            // 
            // thoigian
            // 
            thoigian.DataPropertyName = "batdauluc";
            dataGridViewCellStyle1.Format = "HH:mm:ss";
            thoigian.DefaultCellStyle = dataGridViewCellStyle1;
            thoigian.FillWeight = 57.4450035F;
            thoigian.HeaderText = "bắt đầu lúc ";
            thoigian.Name = "thoigian";
            // 
            // dasudung
            // 
            dasudung.DataPropertyName = "thoigianchoi";
            dasudung.FillWeight = 57.4450035F;
            dasudung.HeaderText = "giờ đã sử dụng";
            dasudung.Name = "dasudung";
            // 
            // cmsMayTram
            // 
            cmsMayTram.Items.AddRange(new ToolStripItem[] { mởMáyĐăngNhậpToolStripMenuItem, đăngXuấtTắtMáyToolStripMenuItem, nạpTiềnToolStripMenuItem, chinhsuamaytram });
            cmsMayTram.Name = "cmsMayTram";
            cmsMayTram.Size = new Size(188, 92);
            // 
            // mởMáyĐăngNhậpToolStripMenuItem
            // 
            mởMáyĐăngNhậpToolStripMenuItem.Name = "mởMáyĐăngNhậpToolStripMenuItem";
            mởMáyĐăngNhậpToolStripMenuItem.Size = new Size(187, 22);
            mởMáyĐăngNhậpToolStripMenuItem.Text = "Mở máy (Đăng nhập)";
            mởMáyĐăngNhậpToolStripMenuItem.Click += mởMáyĐăngNhậpToolStripMenuItem_Click;
            // 
            // đăngXuấtTắtMáyToolStripMenuItem
            // 
            đăngXuấtTắtMáyToolStripMenuItem.Name = "đăngXuấtTắtMáyToolStripMenuItem";
            đăngXuấtTắtMáyToolStripMenuItem.Size = new Size(187, 22);
            đăngXuấtTắtMáyToolStripMenuItem.Text = "Đăng xuất (Tắt máy)";
            đăngXuấtTắtMáyToolStripMenuItem.Click += đăngXuấtTắtMáyToolStripMenuItem_Click;
            // 
            // nạpTiềnToolStripMenuItem
            // 
            nạpTiềnToolStripMenuItem.Name = "nạpTiềnToolStripMenuItem";
            nạpTiềnToolStripMenuItem.Size = new Size(187, 22);
            nạpTiềnToolStripMenuItem.Text = "Nạp Tiền";
            nạpTiềnToolStripMenuItem.Click += nạpTiềnToolStripMenuItem_Click;
            // 
            // chinhsuamaytram
            // 
            chinhsuamaytram.DropDownItems.AddRange(new ToolStripItem[] { themmaytram, xoamaytram });
            chinhsuamaytram.Name = "chinhsuamaytram";
            chinhsuamaytram.Size = new Size(187, 22);
            chinhsuamaytram.Text = "chỉnh sửa";
            // 
            // themmaytram
            // 
            themmaytram.Name = "themmaytram";
            themmaytram.Size = new Size(156, 22);
            themmaytram.Text = "thêm máy trạm";
            themmaytram.Click += thêmMáyTrạmToolStripMenuItem_Click;
            // 
            // xoamaytram
            // 
            xoamaytram.Name = "xoamaytram";
            xoamaytram.Size = new Size(156, 22);
            xoamaytram.Text = "xóa máy trạm";
            xoamaytram.Click += xóaMáyTrạmToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btntrangchu, btntaikhoan, btnnaptien, btntaotaikhoan, btnlsnaptien, btnlstime, btndichvu, btnbaocao });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(834, 28);
            toolStrip1.TabIndex = 19;
            toolStrip1.Text = "toolStrip1";
            // 
            // btntrangchu
            // 
            btntrangchu.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btntrangchu.Image = (Image)resources.GetObject("btntrangchu.Image");
            btntrangchu.ImageTransparentColor = Color.Magenta;
            btntrangchu.Name = "btntrangchu";
            btntrangchu.Size = new Size(89, 25);
            btntrangchu.Text = "Trang chủ";
            btntrangchu.Click += btntrangchu_Click_1;
            // 
            // btntaikhoan
            // 
            btntaikhoan.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btntaikhoan.Image = (Image)resources.GetObject("btntaikhoan.Image");
            btntaikhoan.ImageTransparentColor = Color.Magenta;
            btntaikhoan.Name = "btntaikhoan";
            btntaikhoan.Size = new Size(88, 25);
            btntaikhoan.Text = "Tài khoản";
            btntaikhoan.Click += btntaikhoan_Click_1;
            // 
            // btnnaptien
            // 
            btnnaptien.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnnaptien.Image = (Image)resources.GetObject("btnnaptien.Image");
            btnnaptien.ImageTransparentColor = Color.Magenta;
            btnnaptien.Name = "btnnaptien";
            btnnaptien.Size = new Size(80, 25);
            btnnaptien.Text = "Nạp tiền";
            btnnaptien.Click += btnnaptien_Click_1;
            // 
            // btntaotaikhoan
            // 
            btntaotaikhoan.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btntaotaikhoan.Image = (Image)resources.GetObject("btntaotaikhoan.Image");
            btntaotaikhoan.ImageTransparentColor = Color.Magenta;
            btntaotaikhoan.Name = "btntaotaikhoan";
            btntaotaikhoan.Size = new Size(118, 25);
            btntaotaikhoan.Text = "Tạo tài khoản";
            btntaotaikhoan.Click += btntaotaikhoan_Click;
            // 
            // btnlsnaptien
            // 
            btnlsnaptien.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnlsnaptien.Image = (Image)resources.GetObject("btnlsnaptien.Image");
            btnlsnaptien.ImageTransparentColor = Color.Magenta;
            btnlsnaptien.Name = "btnlsnaptien";
            btnlsnaptien.Size = new Size(155, 25);
            btnlsnaptien.Text = "Lịch sử thanh toán";
            btnlsnaptien.Click += tablsnaptien_Click;
            // 
            // btnlstime
            // 
            btnlstime.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnlstime.Image = (Image)resources.GetObject("btnlstime.Image");
            btnlstime.ImageTransparentColor = Color.Magenta;
            btnlstime.Name = "btnlstime";
            btnlstime.Size = new Size(130, 25);
            btnlstime.Text = "lịch sử giờ chơi";
            btnlstime.Click += btnlstime_Click;
            // 
            // btndichvu
            // 
            btndichvu.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btndichvu.Image = (Image)resources.GetObject("btndichvu.Image");
            btndichvu.ImageTransparentColor = Color.Magenta;
            btndichvu.Name = "btndichvu";
            btndichvu.Size = new Size(72, 25);
            btndichvu.Text = "Dịch vụ";
            btndichvu.Click += btndichvu_Click;
            // 
            // btnbaocao
            // 
            btnbaocao.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnbaocao.Image = (Image)resources.GetObject("btnbaocao.Image");
            btnbaocao.ImageTransparentColor = Color.Magenta;
            btnbaocao.Name = "btnbaocao";
            btnbaocao.Size = new Size(74, 25);
            btnbaocao.Text = "Báo cáo";
            btnbaocao.Click += btnbaocao_Click;
            // 
            // tabControl1
            // 
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.Controls.Add(tabpage1);
            tabControl1.Controls.Add(tabpage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.Location = new Point(0, 28);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(834, 422);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 20;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabpage1
            // 
            tabpage1.Controls.Add(dgvmaytram);
            tabpage1.Location = new Point(4, 5);
            tabpage1.Name = "tabpage1";
            tabpage1.Padding = new Padding(3);
            tabpage1.Size = new Size(826, 413);
            tabpage1.TabIndex = 0;
            tabpage1.Text = "Trang chủ";
            tabpage1.UseVisualStyleBackColor = true;
            // 
            // tabpage2
            // 
            tabpage2.Controls.Add(dgvtaikhoan);
            tabpage2.Controls.Add(panel1);
            tabpage2.Location = new Point(4, 5);
            tabpage2.Name = "tabpage2";
            tabpage2.Padding = new Padding(3);
            tabpage2.Size = new Size(826, 413);
            tabpage2.TabIndex = 1;
            tabpage2.Text = "Tài khoản";
            tabpage2.UseVisualStyleBackColor = true;
            // 
            // dgvtaikhoan
            // 
            dgvtaikhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvtaikhoan.BackgroundColor = Color.Pink;
            dgvtaikhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvtaikhoan.Columns.AddRange(new DataGridViewColumn[] { cottendn, cotmk, cotsodu, tongnap, tiendadung });
            dgvtaikhoan.ContextMenuStrip = cmstaikhoan;
            dgvtaikhoan.Dock = DockStyle.Fill;
            dgvtaikhoan.Location = new Point(3, 50);
            dgvtaikhoan.Name = "dgvtaikhoan";
            dgvtaikhoan.Size = new Size(820, 360);
            dgvtaikhoan.TabIndex = 0;
            dgvtaikhoan.RowPostPaint += dgvtaikhoan_RowPostPaint;
            // 
            // cottendn
            // 
            cottendn.DataPropertyName = "tendangnhap";
            cottendn.HeaderText = "Tên đăng nhập";
            cottendn.Name = "cottendn";
            // 
            // cotmk
            // 
            cotmk.DataPropertyName = "matkhau";
            cotmk.HeaderText = "Mật khẩu";
            cotmk.Name = "cotmk";
            // 
            // cotsodu
            // 
            cotsodu.DataPropertyName = "sodu";
            cotsodu.HeaderText = "Số dư";
            cotsodu.Name = "cotsodu";
            // 
            // tongnap
            // 
            tongnap.DataPropertyName = "tongtiennap";
            tongnap.HeaderText = "Tổng nạp";
            tongnap.Name = "tongnap";
            // 
            // tiendadung
            // 
            tiendadung.DataPropertyName = "tongtiendung";
            tiendadung.HeaderText = "Tiền đã dùng";
            tiendadung.Name = "tiendadung";
            // 
            // cmstaikhoan
            // 
            cmstaikhoan.Items.AddRange(new ToolStripItem[] { nạpTiềnToolStripMenuItem_tab2_, xóaTàiKhoảnToolStripMenuItem, đổiMậtKhẩuToolStripMenuItem });
            cmstaikhoan.Name = "cmstaikhoan";
            cmstaikhoan.Size = new Size(145, 70);
            // 
            // nạpTiềnToolStripMenuItem_tab2_
            // 
            nạpTiềnToolStripMenuItem_tab2_.Name = "nạpTiềnToolStripMenuItem_tab2_";
            nạpTiềnToolStripMenuItem_tab2_.Size = new Size(144, 22);
            nạpTiềnToolStripMenuItem_tab2_.Text = "nạp tiền";
            nạpTiềnToolStripMenuItem_tab2_.Click += nạpTiềnToolStripMenuItem_tab2__Click;
            // 
            // xóaTàiKhoảnToolStripMenuItem
            // 
            xóaTàiKhoảnToolStripMenuItem.Name = "xóaTàiKhoảnToolStripMenuItem";
            xóaTàiKhoảnToolStripMenuItem.Size = new Size(144, 22);
            xóaTàiKhoảnToolStripMenuItem.Text = "xóa tài khoản";
            xóaTàiKhoảnToolStripMenuItem.Click += xóaTàiKhoảnToolStripMenuItem_Click;
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            đổiMậtKhẩuToolStripMenuItem.Size = new Size(144, 22);
            đổiMậtKhẩuToolStripMenuItem.Text = "đổi mật khẩu";
            đổiMậtKhẩuToolStripMenuItem.Click += đổiMậtKhẩuToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Pink;
            panel1.Controls.Add(txttimkiem);
            panel1.Controls.Add(btndanhsach);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnsearch);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(820, 47);
            panel1.TabIndex = 5;
            // 
            // txttimkiem
            // 
            txttimkiem.Location = new Point(83, 21);
            txttimkiem.Name = "txttimkiem";
            txttimkiem.Size = new Size(100, 23);
            txttimkiem.TabIndex = 1;
            txttimkiem.TextChanged += txttimkiem_TextChanged;
            // 
            // btndanhsach
            // 
            btndanhsach.Location = new Point(2, 20);
            btndanhsach.Name = "btndanhsach";
            btndanhsach.Size = new Size(75, 23);
            btndanhsach.TabIndex = 4;
            btndanhsach.Text = "danh sách";
            btndanhsach.UseVisualStyleBackColor = true;
            btndanhsach.Click += btndanhsach_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 3);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 2;
            label1.Text = "tìm kiếm";
            // 
            // btnsearch
            // 
            btnsearch.Location = new Point(189, 21);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(51, 23);
            btnsearch.TabIndex = 3;
            btnsearch.Text = "tìm";
            btnsearch.UseVisualStyleBackColor = true;
            btnsearch.Click += btnsearch_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(panel2);
            tabPage3.Controls.Add(dgvlichsunap);
            tabPage3.Location = new Point(4, 5);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(826, 413);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Pink;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtlichsu);
            panel2.Controls.Add(btntimkiemls);
            panel2.Controls.Add(btndsls);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(820, 50);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(108, 5);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 5;
            label2.Text = "tìm kiếm";
            // 
            // txtlichsu
            // 
            txtlichsu.Location = new Point(81, 24);
            txtlichsu.Name = "txtlichsu";
            txtlichsu.Size = new Size(164, 23);
            txtlichsu.TabIndex = 4;
            // 
            // btntimkiemls
            // 
            btntimkiemls.Location = new Point(251, 24);
            btntimkiemls.Name = "btntimkiemls";
            btntimkiemls.Size = new Size(75, 23);
            btntimkiemls.TabIndex = 2;
            btntimkiemls.Text = "tìm kiếm";
            btntimkiemls.UseVisualStyleBackColor = true;
            btntimkiemls.Click += btntimkiemls_Click;
            // 
            // btndsls
            // 
            btndsls.Location = new Point(0, 23);
            btndsls.Name = "btndsls";
            btndsls.Size = new Size(75, 23);
            btndsls.TabIndex = 3;
            btndsls.Text = "danh sách";
            btndsls.UseVisualStyleBackColor = true;
            btndsls.Click += btndsls_Click;
            // 
            // dgvlichsunap
            // 
            dgvlichsunap.BackgroundColor = Color.Pink;
            dgvlichsunap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvlichsunap.Columns.AddRange(new DataGridViewColumn[] { coltendn, colsotien, coldatetime, colghichu });
            dgvlichsunap.Dock = DockStyle.Bottom;
            dgvlichsunap.Location = new Point(3, 55);
            dgvlichsunap.Name = "dgvlichsunap";
            dgvlichsunap.Size = new Size(820, 355);
            dgvlichsunap.TabIndex = 0;
            // 
            // coltendn
            // 
            coltendn.DataPropertyName = "tendangnhap";
            coltendn.HeaderText = "tên tài khoản";
            coltendn.Name = "coltendn";
            coltendn.Width = 193;
            // 
            // colsotien
            // 
            colsotien.DataPropertyName = "sotiennap";
            colsotien.HeaderText = "số tiền thanh toán";
            colsotien.Name = "colsotien";
            colsotien.Width = 193;
            // 
            // coldatetime
            // 
            coldatetime.DataPropertyName = "thoigiannap";
            coldatetime.HeaderText = "thời gian thanh toán";
            coldatetime.Name = "coldatetime";
            coldatetime.Width = 193;
            // 
            // colghichu
            // 
            colghichu.DataPropertyName = "ghichu";
            colghichu.HeaderText = "ghi chú";
            colghichu.Name = "colghichu";
            colghichu.Width = 198;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(panel3);
            tabPage4.Controls.Add(dgvlstime);
            tabPage4.Location = new Point(4, 5);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(826, 413);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "tabPage4";
            tabPage4.UseVisualStyleBackColor = true;
            tabPage4.Click += btnlstime_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Pink;
            panel3.Controls.Add(txttimdsls);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(btntimls);
            panel3.Controls.Add(btldanhsachls);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(820, 49);
            panel3.TabIndex = 5;
            // 
            // txttimdsls
            // 
            txttimdsls.Location = new Point(82, 22);
            txttimdsls.Name = "txttimdsls";
            txttimdsls.Size = new Size(123, 23);
            txttimdsls.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 4);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 4;
            label3.Text = "tìm kiếm";
            // 
            // btntimls
            // 
            btntimls.Location = new Point(211, 23);
            btntimls.Name = "btntimls";
            btntimls.Size = new Size(75, 23);
            btntimls.TabIndex = 1;
            btntimls.Text = "tìm";
            btntimls.UseVisualStyleBackColor = true;
            btntimls.Click += btntimls_Click;
            // 
            // btldanhsachls
            // 
            btldanhsachls.Location = new Point(1, 22);
            btldanhsachls.Name = "btldanhsachls";
            btldanhsachls.Size = new Size(75, 23);
            btldanhsachls.TabIndex = 2;
            btldanhsachls.Text = "danh sách";
            btldanhsachls.UseVisualStyleBackColor = true;
            btldanhsachls.Click += btldanhsachls_Click;
            // 
            // dgvlstime
            // 
            dgvlstime.BackgroundColor = Color.Pink;
            dgvlstime.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvlstime.Columns.AddRange(new DataGridViewColumn[] { taikhoan, somay1, batdau, ketthuc, thoigianchoi, sotien });
            dgvlstime.Dock = DockStyle.Bottom;
            dgvlstime.Location = new Point(3, 54);
            dgvlstime.Name = "dgvlstime";
            dgvlstime.Size = new Size(820, 356);
            dgvlstime.TabIndex = 0;
            // 
            // taikhoan
            // 
            taikhoan.DataPropertyName = "tendangnhap";
            taikhoan.HeaderText = "tài khoản";
            taikhoan.Name = "taikhoan";
            taikhoan.Width = 121;
            // 
            // somay1
            // 
            somay1.DataPropertyName = "somay";
            somay1.HeaderText = "số máy";
            somay1.Name = "somay1";
            somay1.Width = 68;
            // 
            // batdau
            // 
            batdau.DataPropertyName = "batdauluc";
            batdau.HeaderText = "bắt đầu";
            batdau.Name = "batdau";
            batdau.Width = 179;
            // 
            // ketthuc
            // 
            ketthuc.DataPropertyName = "ketthuc";
            ketthuc.HeaderText = "kết thúc";
            ketthuc.Name = "ketthuc";
            ketthuc.Width = 179;
            // 
            // thoigianchoi
            // 
            thoigianchoi.DataPropertyName = "thoigianchoi";
            thoigianchoi.HeaderText = "thời gian chơi";
            thoigianchoi.Name = "thoigianchoi";
            thoigianchoi.Width = 130;
            // 
            // sotien
            // 
            sotien.DataPropertyName = "sotienchu";
            sotien.HeaderText = "số tiền";
            sotien.Name = "sotien";
            // 
            // timertinhtien
            // 
            timertinhtien.Enabled = true;
            timertinhtien.Interval = 60000;
            timertinhtien.Tick += timertinhtien_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(834, 450);
            Controls.Add(tabControl1);
            Controls.Add(toolStrip1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvmaytram).EndInit();
            cmsMayTram.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabpage1.ResumeLayout(false);
            tabpage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvtaikhoan).EndInit();
            cmstaikhoan.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvlichsunap).EndInit();
            tabPage4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvlstime).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvmaytram;
        private ToolStrip toolStrip1;
        private ToolStripButton btntrangchu;
        private TabControl tabControl1;
        private TabPage tabpage1;
        private TabPage tabpage2;
        private ToolStripButton btntaikhoan;
        private ToolStripButton btnnaptien;
        private ToolStripButton btntaotaikhoan;
        private ContextMenuStrip cmsMayTram;
        private ToolStripMenuItem mởMáyĐăngNhậpToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtTắtMáyToolStripMenuItem;
        private ToolStripMenuItem nạpTiềnToolStripMenuItem;
        private DataGridView dgvtaikhoan;
        private Label label1;
        private TextBox txttimkiem;
        private Button btndanhsach;
        private Button btnsearch;
        private Panel panel1;
        private DataGridViewTextBoxColumn cottendn;
        private DataGridViewTextBoxColumn cotmk;
        private DataGridViewTextBoxColumn cotsodu;
        private DataGridViewTextBoxColumn tongnap;
        private DataGridViewTextBoxColumn tiendadung;
        private ContextMenuStrip cmstaikhoan;
        private ToolStripMenuItem nạpTiềnToolStripMenuItem_tab2_;
        private ToolStripMenuItem xóaTàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private DataGridViewTextBoxColumn somay;
        private DataGridViewTextBoxColumn tenmay;
        private DataGridViewTextBoxColumn trangthai;
        private DataGridViewTextBoxColumn tendangnhap;
        private DataGridViewTextBoxColumn sodu;
        private DataGridViewTextBoxColumn thoigian;
        private DataGridViewTextBoxColumn dasudung;
        private System.Windows.Forms.Timer timertinhtien;
        private ToolStripButton btnlsnaptien;
        private ToolStripButton btndichvu;
        private TabPage tabPage3;
        private DataGridView dgvlichsunap;
        private ToolStripButton btnbaocao;
        private Panel panel2;
        private Label label2;
        private TextBox txtlichsu;
        private Button btntimkiemls;
        private Button btndsls;
        private ToolStripButton btnlstime;
        private TabPage tabPage4;
        private Label label3;
        private TextBox txttimdsls;
        private Button btldanhsachls;
        private Button btntimls;
        private DataGridView dgvlstime;
        private Panel panel3;
        private DataGridViewTextBoxColumn coltendn;
        private DataGridViewTextBoxColumn colsotien;
        private DataGridViewTextBoxColumn coldatetime;
        private DataGridViewTextBoxColumn colghichu;
        private DataGridViewTextBoxColumn taikhoan;
        private DataGridViewTextBoxColumn somay1;
        private DataGridViewTextBoxColumn batdau;
        private DataGridViewTextBoxColumn ketthuc;
        private DataGridViewTextBoxColumn thoigianchoi;
        private DataGridViewTextBoxColumn sotien;
        private ToolStripMenuItem chinhsuamaytram;
        private ToolStripMenuItem themmaytram;
        private ToolStripMenuItem xoamaytram;
    }
}
