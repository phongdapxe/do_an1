namespace WinFormsApp1
{
    partial class frmTaoTK
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
            txttentaotk = new TextBox();
            txtmktaotk = new TextBox();
            txtsotientaotk = new TextBox();
            btnxacnhantaotk = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txttentaotk
            // 
            txttentaotk.Location = new Point(17, 60);
            txttentaotk.Name = "txttentaotk";
            txttentaotk.Size = new Size(100, 23);
            txttentaotk.TabIndex = 0;
            // 
            // txtmktaotk
            // 
            txtmktaotk.Location = new Point(17, 134);
            txtmktaotk.Name = "txtmktaotk";
            txtmktaotk.PasswordChar = '*';
            txtmktaotk.Size = new Size(100, 23);
            txtmktaotk.TabIndex = 1;
            // 
            // txtsotientaotk
            // 
            txtsotientaotk.Location = new Point(149, 134);
            txtsotientaotk.Name = "txtsotientaotk";
            txtsotientaotk.Size = new Size(100, 23);
            txtsotientaotk.TabIndex = 2;
            // 
            // btnxacnhantaotk
            // 
            btnxacnhantaotk.Location = new Point(174, 193);
            btnxacnhantaotk.Name = "btnxacnhantaotk";
            btnxacnhantaotk.Size = new Size(75, 23);
            btnxacnhantaotk.TabIndex = 3;
            btnxacnhantaotk.Text = "xác nhận";
            btnxacnhantaotk.UseVisualStyleBackColor = true;
            btnxacnhantaotk.Click += btnxacnhantaotk_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 42);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 4;
            label1.Text = "tên tài khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 116);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 5;
            label2.Text = "mật khẩu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(150, 116);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 6;
            label3.Text = "nạp tiền ";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Pink;
            groupBox1.Controls.Add(txttentaotk);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtsotientaotk);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtmktaotk);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnxacnhantaotk);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(265, 252);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tạo tài khoản";
            // 
            // frmTaoTK
            // 
            AcceptButton = btnxacnhantaotk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(291, 277);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "frmTaoTK";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmTaoTK";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txttentaotk;
        private TextBox txtmktaotk;
        private TextBox txtsotientaotk;
        private Button btnxacnhantaotk;
        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
    }
}