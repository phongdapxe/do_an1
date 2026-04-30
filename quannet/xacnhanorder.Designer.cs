namespace WinFormsApp1
{
    partial class xacnhanorder
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
            txtodtaikhoan = new TextBox();
            label1 = new Label();
            btnodxacnhan = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtodtaikhoan
            // 
            txtodtaikhoan.Font = new Font("Segoe UI", 12F);
            txtodtaikhoan.Location = new Point(23, 103);
            txtodtaikhoan.Name = "txtodtaikhoan";
            txtodtaikhoan.Size = new Size(164, 29);
            txtodtaikhoan.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(23, 79);
            label1.Name = "label1";
            label1.Size = new Size(74, 21);
            label1.TabIndex = 2;
            label1.Text = "tài khoản";
            // 
            // btnodxacnhan
            // 
            btnodxacnhan.Location = new Point(94, 156);
            btnodxacnhan.Name = "btnodxacnhan";
            btnodxacnhan.Size = new Size(93, 31);
            btnodxacnhan.TabIndex = 4;
            btnodxacnhan.Text = "xác nhận";
            btnodxacnhan.UseVisualStyleBackColor = true;
            btnodxacnhan.Click += btnodxacnhan_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Calligraphy", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 39);
            label3.Name = "label3";
            label3.Size = new Size(205, 24);
            label3.TabIndex = 5;
            label3.Text = "xác nhận gọi món";
            // 
            // xacnhanorder
            // 
            AcceptButton = btnodxacnhan;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(226, 231);
            Controls.Add(label3);
            Controls.Add(btnodxacnhan);
            Controls.Add(label1);
            Controls.Add(txtodtaikhoan);
            Name = "xacnhanorder";
            Text = "xacnhanorder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtodtaikhoan;
        private Label label1;
        private Button btnodxacnhan;
        private Label label3;
    }
}