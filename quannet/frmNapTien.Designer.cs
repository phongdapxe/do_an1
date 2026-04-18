namespace WinFormsApp1
{
    partial class frmNapTien
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
            txttendn = new TextBox();
            txtsotien = new TextBox();
            btnXacNhan = new Button();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txttendn
            // 
            txttendn.Location = new Point(27, 45);
            txttendn.Name = "txttendn";
            txttendn.Size = new Size(100, 23);
            txttendn.TabIndex = 0;
            // 
            // txtsotien
            // 
            txtsotien.Location = new Point(27, 103);
            txtsotien.Name = "txtsotien";
            txtsotien.Size = new Size(100, 23);
            txtsotien.TabIndex = 1;
            // 
            // btnXacNhan
            // 
            btnXacNhan.Location = new Point(93, 160);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(75, 23);
            btnXacNhan.TabIndex = 2;
            btnXacNhan.Text = "xác nhận";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 27);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 3;
            label1.Text = "tên đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 85);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 4;
            label2.Text = "số tiền";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Pink;
            groupBox1.Controls.Add(txttendn);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtsotien);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnXacNhan);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(195, 209);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nạp tiền";
            // 
            // frmNapTien
            // 
            AcceptButton = btnXacNhan;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(222, 231);
            Controls.Add(groupBox1);
            Name = "frmNapTien";
            Text = "frmNapTien";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnXacNhan;
        private Label label1;
        private Label label2;
        public TextBox txttendn;
        public TextBox txtsotien;
        private GroupBox groupBox1;
    }
}