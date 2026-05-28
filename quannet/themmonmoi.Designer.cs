namespace WinFormsApp1
{
    partial class themmonmoi
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
            btnchonanh = new Button();
            pictureBox1 = new PictureBox();
            btnxnthemmon = new Button();
            txtthemtenmon = new TextBox();
            txtthemdongia = new TextBox();
            txtthemsl = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnchonanh
            // 
            btnchonanh.Location = new Point(43, 237);
            btnchonanh.Name = "btnchonanh";
            btnchonanh.Size = new Size(75, 23);
            btnchonanh.TabIndex = 0;
            btnchonanh.Text = "chọn ảnh";
            btnchonanh.UseVisualStyleBackColor = true;
            btnchonanh.Click += btnchonanh_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.MistyRose;
            pictureBox1.Location = new Point(18, 130);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(115, 93);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnxnthemmon
            // 
            btnxnthemmon.Location = new Point(185, 237);
            btnxnthemmon.Name = "btnxnthemmon";
            btnxnthemmon.Size = new Size(75, 23);
            btnxnthemmon.TabIndex = 2;
            btnxnthemmon.Text = "xác nhận";
            btnxnthemmon.UseVisualStyleBackColor = true;
            btnxnthemmon.Click += btnxnthemmon_Click;
            // 
            // txtthemtenmon
            // 
            txtthemtenmon.Location = new Point(18, 101);
            txtthemtenmon.Name = "txtthemtenmon";
            txtthemtenmon.Size = new Size(100, 23);
            txtthemtenmon.TabIndex = 3;
            // 
            // txtthemdongia
            // 
            txtthemdongia.Location = new Point(160, 200);
            txtthemdongia.Name = "txtthemdongia";
            txtthemdongia.Size = new Size(100, 23);
            txtthemdongia.TabIndex = 4;
            // 
            // txtthemsl
            // 
            txtthemsl.Location = new Point(160, 101);
            txtthemsl.Name = "txtthemsl";
            txtthemsl.Size = new Size(100, 23);
            txtthemsl.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 80);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 6;
            label1.Text = "nhập tên món:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(160, 182);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 7;
            label2.Text = "nhập đơn giá:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(160, 83);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 8;
            label3.Text = "nhập số lượng:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("STCaiyun", 17.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 134);
            label4.Location = new Point(36, 28);
            label4.Name = "label4";
            label4.Size = new Size(194, 24);
            label4.TabIndex = 9;
            label4.Text = "Thêm món mới";
            // 
            // themmonmoi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(276, 285);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtthemsl);
            Controls.Add(txtthemdongia);
            Controls.Add(txtthemtenmon);
            Controls.Add(btnxnthemmon);
            Controls.Add(pictureBox1);
            Controls.Add(btnchonanh);
            Name = "themmonmoi";
            Text = "themmonmoi";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnchonanh;
        private PictureBox pictureBox1;
        private Button btnxnthemmon;
        private TextBox txtthemtenmon;
        private TextBox txtthemdongia;
        private TextBox txtthemsl;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtidmon;
    }
}