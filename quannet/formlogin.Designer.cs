namespace WinFormsApp1
{
    partial class formlogin
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
            txtuser = new TextBox();
            txtpass = new TextBox();
            btnlogin = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtuser
            // 
            txtuser.Location = new Point(176, 254);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(154, 23);
            txtuser.TabIndex = 0;
            // 
            // txtpass
            // 
            txtpass.Location = new Point(176, 317);
            txtpass.Name = "txtpass";
            txtpass.PasswordChar = '*';
            txtpass.Size = new Size(154, 23);
            txtpass.TabIndex = 1;
            // 
            // btnlogin
            // 
            btnlogin.Location = new Point(176, 363);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(75, 23);
            btnlogin.TabIndex = 2;
            btnlogin.Text = "Đăng Nhập";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += btnlogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(176, 236);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 3;
            label1.Text = "tên tài khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(176, 299);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 4;
            label2.Text = "mật khẩu";
            // 
            // label3
            // 
            label3.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(126, 167);
            label3.Name = "label3";
            label3.Size = new Size(275, 30);
            label3.TabIndex = 5;
            label3.Text = "Đăng nhập tài khoản";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Script", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(-5, 35);
            label4.Name = "label4";
            label4.Size = new Size(512, 44);
            label4.TabIndex = 6;
            label4.Text = "PHẦN MỀM QUẢN LÝ QUÁN NET";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe Script", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(190, 89);
            label5.Name = "label5";
            label5.Size = new Size(120, 53);
            label5.TabIndex = 7;
            label5.Text = "PNET";
            // 
            // formlogin
            // 
            AcceptButton = btnlogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(507, 438);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnlogin);
            Controls.Add(txtpass);
            Controls.Add(txtuser);
            Name = "formlogin";
            Text = "formlogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtuser;
        private TextBox txtpass;
        private Button btnlogin;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}