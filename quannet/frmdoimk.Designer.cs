namespace WinFormsApp1
{
    partial class frmdoimk
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
            txttentk = new TextBox();
            txtpasscu = new TextBox();
            txtpassmoi = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnxacnhandmk = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txttentk
            // 
            txttentk.Location = new Point(6, 57);
            txttentk.Name = "txttentk";
            txttentk.Size = new Size(100, 23);
            txttentk.TabIndex = 0;
            // 
            // txtpasscu
            // 
            txtpasscu.Location = new Point(6, 127);
            txtpasscu.Name = "txtpasscu";
            txtpasscu.PasswordChar = '*';
            txtpasscu.Size = new Size(100, 23);
            txtpasscu.TabIndex = 1;
            // 
            // txtpassmoi
            // 
            txtpassmoi.Location = new Point(127, 127);
            txtpassmoi.Name = "txtpassmoi";
            txtpassmoi.PasswordChar = '*';
            txtpassmoi.Size = new Size(100, 23);
            txtpassmoi.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 39);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 3;
            label1.Text = "tên tài khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 109);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 4;
            label2.Text = "mật khẩu cũ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(127, 109);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 5;
            label3.Text = "mật khẩu mới";
            // 
            // btnxacnhandmk
            // 
            btnxacnhandmk.Location = new Point(152, 171);
            btnxacnhandmk.Name = "btnxacnhandmk";
            btnxacnhandmk.Size = new Size(75, 23);
            btnxacnhandmk.TabIndex = 6;
            btnxacnhandmk.Text = "xác nhận";
            btnxacnhandmk.UseVisualStyleBackColor = true;
            btnxacnhandmk.Click += btnxacnhandmk_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Pink;
            groupBox1.Controls.Add(txttentk);
            groupBox1.Controls.Add(btnxacnhandmk);
            groupBox1.Controls.Add(txtpasscu);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtpassmoi);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(240, 234);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Đổi mật khẩu";
            // 
            // frmdoimk
            // 
            AcceptButton = btnxacnhandmk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(267, 261);
            Controls.Add(groupBox1);
            Name = "frmdoimk";
            Text = "frmdoimk";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtpasscu;
        private TextBox txtpassmoi;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnxacnhandmk;
        public TextBox txttentk;
        private GroupBox groupBox1;
    }
}