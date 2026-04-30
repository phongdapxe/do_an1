namespace WinFormsApp1
{
    partial class frmbaocao
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            datetime1 = new DateTimePicker();
            datetime2 = new DateTimePicker();
            datetime3 = new DateTimePicker();
            datetime4 = new DateTimePicker();
            btnxacnhanbaocao = new Button();
            btnxuatbaocao = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(63, 22);
            label1.Name = "label1";
            label1.Size = new Size(195, 30);
            label1.TabIndex = 0;
            label1.Text = "báo cáo doanh thu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 73);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 1;
            label2.Text = "từ ngày";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 147);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 2;
            label3.Text = "đến ngày";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(220, 77);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 3;
            label4.Text = "từ giờ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(220, 147);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 4;
            label5.Text = "đến giờ";
            // 
            // datetime1
            // 
            datetime1.Location = new Point(14, 95);
            datetime1.Name = "datetime1";
            datetime1.Size = new Size(200, 23);
            datetime1.TabIndex = 5;
            // 
            // datetime2
            // 
            datetime2.Location = new Point(14, 165);
            datetime2.Name = "datetime2";
            datetime2.Size = new Size(200, 23);
            datetime2.TabIndex = 6;
            // 
            // datetime3
            // 
            datetime3.Location = new Point(220, 95);
            datetime3.Name = "datetime3";
            datetime3.Size = new Size(82, 23);
            datetime3.TabIndex = 7;
            // 
            // datetime4
            // 
            datetime4.Location = new Point(220, 165);
            datetime4.Name = "datetime4";
            datetime4.Size = new Size(82, 23);
            datetime4.TabIndex = 8;
            // 
            // btnxacnhanbaocao
            // 
            btnxacnhanbaocao.Location = new Point(220, 206);
            btnxacnhanbaocao.Name = "btnxacnhanbaocao";
            btnxacnhanbaocao.Size = new Size(75, 23);
            btnxacnhanbaocao.TabIndex = 9;
            btnxacnhanbaocao.Text = "xác nhận";
            btnxacnhanbaocao.UseVisualStyleBackColor = true;
            btnxacnhanbaocao.Click += btnxacnhanbaocao_Click;
            // 
            // btnxuatbaocao
            // 
            btnxuatbaocao.Location = new Point(14, 206);
            btnxuatbaocao.Name = "btnxuatbaocao";
            btnxuatbaocao.Size = new Size(83, 23);
            btnxuatbaocao.TabIndex = 10;
            btnxuatbaocao.Text = "xuất báo cáo";
            btnxuatbaocao.UseVisualStyleBackColor = true;
            btnxuatbaocao.Click += btnxuatbaocao_Click;
            // 
            // frmbaocao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(317, 252);
            Controls.Add(btnxuatbaocao);
            Controls.Add(btnxacnhanbaocao);
            Controls.Add(datetime4);
            Controls.Add(datetime3);
            Controls.Add(datetime2);
            Controls.Add(datetime1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmbaocao";
            Text = "frmbaocao";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker datetime1;
        private DateTimePicker datetime2;
        private DateTimePicker datetime3;
        private DateTimePicker datetime4;
        private Button btnxacnhanbaocao;
        private Button btnxuatbaocao;
    }
}