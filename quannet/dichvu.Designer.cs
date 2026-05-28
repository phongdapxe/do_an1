namespace WinFormsApp1
{
    partial class dichvu
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
            flpmenu = new FlowLayoutPanel();
            lblTongTien = new Label();
            lbldanhsach = new Label();
            button1 = new Button();
            pnlOrder = new Panel();
            label1 = new Label();
            btnthemmon = new Button();
            SuspendLayout();
            // 
            // flpmenu
            // 
            flpmenu.AutoScroll = true;
            flpmenu.BackColor = Color.Pink;
            flpmenu.Location = new Point(0, 0);
            flpmenu.Name = "flpmenu";
            flpmenu.Size = new Size(575, 450);
            flpmenu.TabIndex = 0;
            // 
            // lblTongTien
            // 
            lblTongTien.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTongTien.Location = new Point(710, 378);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(0, 25);
            lblTongTien.TabIndex = 0;
            lblTongTien.Click += lblTongTien_Click;
            // 
            // lbldanhsach
            // 
            lbldanhsach.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbldanhsach.AutoSize = true;
            lbldanhsach.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbldanhsach.Location = new Point(598, 9);
            lbldanhsach.Name = "lbldanhsach";
            lbldanhsach.Size = new Size(176, 25);
            lbldanhsach.TabIndex = 1;
            lbldanhsach.Text = "danh sách đã order";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.MediumSeaGreen;
            button1.Location = new Point(674, 406);
            button1.Name = "button1";
            button1.Size = new Size(126, 44);
            button1.TabIndex = 2;
            button1.Text = "gọi món";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pnlOrder
            // 
            pnlOrder.AutoScroll = true;
            pnlOrder.BackColor = SystemColors.ControlLight;
            pnlOrder.Location = new Point(575, 37);
            pnlOrder.Name = "pnlOrder";
            pnlOrder.Size = new Size(225, 338);
            pnlOrder.TabIndex = 3;
            pnlOrder.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(581, 378);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 4;
            label1.Text = "tổng tiền:";
            // 
            // btnthemmon
            // 
            btnthemmon.BackColor = Color.MediumSeaGreen;
            btnthemmon.Location = new Point(581, 406);
            btnthemmon.Name = "btnthemmon";
            btnthemmon.Size = new Size(95, 44);
            btnthemmon.TabIndex = 5;
            btnthemmon.Text = "thêm món";
            btnthemmon.UseVisualStyleBackColor = false;
            btnthemmon.Click += btnthemmon_Click;
            // 
            // dichvu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnthemmon);
            Controls.Add(lbldanhsach);
            Controls.Add(label1);
            Controls.Add(pnlOrder);
            Controls.Add(lblTongTien);
            Controls.Add(flpmenu);
            Controls.Add(button1);
            Name = "dichvu";
            Text = "dichvu";
            Load += dichvu_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flpmenu;
        private Label lbldanhsach;
        private Button button1;
        private Panel pnlOrder;
        private Label lblTongTien;
        private Label label1;
        private Button btnthemmon;
    }
}