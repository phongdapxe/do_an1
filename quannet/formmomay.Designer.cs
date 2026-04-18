namespace WinFormsApp1
{
    partial class formmomay
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
            txttk = new TextBox();
            txtmk = new TextBox();
            btnlgin = new Button();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txttk
            // 
            txttk.Location = new Point(18, 52);
            txttk.Name = "txttk";
            txttk.Size = new Size(159, 23);
            txttk.TabIndex = 0;
            // 
            // txtmk
            // 
            txtmk.Location = new Point(18, 111);
            txtmk.Name = "txtmk";
            txtmk.PasswordChar = '*';
            txtmk.Size = new Size(159, 23);
            txtmk.TabIndex = 1;
            // 
            // btnlgin
            // 
            btnlgin.Location = new Point(102, 166);
            btnlgin.Name = "btnlgin";
            btnlgin.Size = new Size(75, 23);
            btnlgin.TabIndex = 2;
            btnlgin.Text = "xác nhận";
            btnlgin.UseVisualStyleBackColor = true;
            btnlgin.Click += btnlgin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 34);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 3;
            label1.Text = "tài khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 93);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 4;
            label2.Text = "mật khẩu";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Pink;
            groupBox1.Controls.Add(txttk);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtmk);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnlgin);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(202, 212);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Đăng nhập";
            // 
            // formmomay
            // 
            AcceptButton = btnlgin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(228, 236);
            Controls.Add(groupBox1);
            Name = "formmomay";
            Text = "formmomay";
            Load += formmomay_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txttk;
        private TextBox txtmk;
        private Button btnlgin;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
    }
}