namespace WinFormsApp1
{
    partial class frmketquabaocao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvketqua = new DataGridView();
            colten = new DataGridViewTextBoxColumn();
            colngaygio = new DataGridViewTextBoxColumn();
            colsotien = new DataGridViewTextBoxColumn();
            colghichu = new DataGridViewTextBoxColumn();
            lbltongdoanhthu = new Label();
            panel1 = new Panel();
            btnxacnhanbc = new Button();
            panel2 = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvketqua).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvketqua
            // 
            dgvketqua.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvketqua.Columns.AddRange(new DataGridViewColumn[] { colten, colngaygio, colsotien, colghichu });
            dgvketqua.Dock = DockStyle.Fill;
            dgvketqua.Location = new Point(0, 51);
            dgvketqua.Name = "dgvketqua";
            dgvketqua.Size = new Size(678, 324);
            dgvketqua.TabIndex = 0;
            dgvketqua.RowPostPaint += dataGridView1_RowPostPaint;
            // 
            // colten
            // 
            colten.DataPropertyName = "tendangnhap";
            colten.FillWeight = 101.692429F;
            colten.HeaderText = "tên tài khoản";
            colten.Name = "colten";
            colten.Width = 161;
            // 
            // colngaygio
            // 
            colngaygio.DataPropertyName = "thoigiannap";
            colngaygio.FillWeight = 95.9646F;
            colngaygio.HeaderText = "ngày giờ thanh toán";
            colngaygio.Name = "colngaygio";
            colngaygio.Width = 153;
            // 
            // colsotien
            // 
            colsotien.DataPropertyName = "sotiennap";
            colsotien.FillWeight = 102.67083F;
            colsotien.HeaderText = "số tiền thanh toán";
            colsotien.Name = "colsotien";
            colsotien.Width = 130;
            // 
            // colghichu
            // 
            colghichu.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colghichu.DataPropertyName = "ghichu";
            colghichu.FillWeight = 99.6721344F;
            colghichu.HeaderText = "ghi chú";
            colghichu.Name = "colghichu";
            // 
            // lbltongdoanhthu
            // 
            lbltongdoanhthu.AutoSize = true;
            lbltongdoanhthu.Font = new Font("Segoe UI", 12F);
            lbltongdoanhthu.Location = new Point(447, 13);
            lbltongdoanhthu.Name = "lbltongdoanhthu";
            lbltongdoanhthu.Size = new Size(77, 21);
            lbltongdoanhthu.TabIndex = 2;
            lbltongdoanhthu.Text = "doanhthu";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnxacnhanbc);
            panel1.Controls.Add(lbltongdoanhthu);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 375);
            panel1.Name = "panel1";
            panel1.Size = new Size(678, 75);
            panel1.TabIndex = 3;
            // 
            // btnxacnhanbc
            // 
            btnxacnhanbc.Location = new Point(582, 38);
            btnxacnhanbc.Name = "btnxacnhanbc";
            btnxacnhanbc.Size = new Size(86, 28);
            btnxacnhanbc.TabIndex = 4;
            btnxacnhanbc.Text = "xác nhận";
            btnxacnhanbc.UseVisualStyleBackColor = true;
            btnxacnhanbc.Click += btnxacnhanbc_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(678, 51);
            panel2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(171, 9);
            label2.Name = "label2";
            label2.Size = new Size(320, 32);
            label2.TabIndex = 0;
            label2.Text = "danh sách lịch sử doanh thu";
            // 
            // frmketquabaocao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 450);
            Controls.Add(dgvketqua);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmketquabaocao";
            Text = "frmketquabaocao";
            ((System.ComponentModel.ISupportInitialize)dgvketqua).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvketqua;
        private Label label1;
        private Label lbltongdoanhthu;
        private Panel panel1;
        private Button btnxacnhanbc;
        private Panel panel2;
        private Label label2;
        private DataGridViewTextBoxColumn colten;
        private DataGridViewTextBoxColumn colngaygio;
        private DataGridViewTextBoxColumn colsotien;
        private DataGridViewTextBoxColumn colghichu;
    }
}