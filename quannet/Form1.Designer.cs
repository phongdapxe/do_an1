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
            toolStrip1 = new ToolStrip();
            btntrangchu = new ToolStripButton();
            btntaikhoan = new ToolStripButton();
            btnnaptien = new ToolStripButton();
            btntaotaikhoan = new ToolStripButton();
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
            dgvmaytram.Size = new Size(786, 407);
            dgvmaytram.TabIndex = 2;
            dgvmaytram.CellContentClick += dgvmaytram_CellContentClick;
            dgvmaytram.CellFormatting += dgvmaytram_CellFormatting;
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
            cmsMayTram.Items.AddRange(new ToolStripItem[] { mởMáyĐăngNhậpToolStripMenuItem, đăngXuấtTắtMáyToolStripMenuItem, nạpTiềnToolStripMenuItem });
            cmsMayTram.Name = "cmsMayTram";
            cmsMayTram.Size = new Size(188, 70);
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
            // toolStrip1
            // 
            toolStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btntrangchu, btntaikhoan, btnnaptien, btntaotaikhoan });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 28);
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
            // tabControl1
            // 
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.Controls.Add(tabpage1);
            tabControl1.Controls.Add(tabpage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.Location = new Point(0, 28);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 422);
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
            tabpage1.Size = new Size(792, 413);
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
            tabpage2.Size = new Size(792, 413);
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
            dgvtaikhoan.Size = new Size(786, 360);
            dgvtaikhoan.TabIndex = 0;
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
            panel1.Size = new Size(786, 47);
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
            ClientSize = new Size(800, 450);
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
    }
}
