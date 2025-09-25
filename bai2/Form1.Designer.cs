namespace bai2
{
    partial class FrmBai2_2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtHoTen = new TextBox();
            rad1 = new RadioButton();
            groupBox1 = new GroupBox();
            rad2 = new RadioButton();
            btnXoa = new Button();
            btnKQ = new Button();
            txtKQ = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 41);
            label1.Name = "label1";
            label1.Size = new Size(134, 22);
            label1.TabIndex = 0;
            label1.Text = "Nhập họ và tên:";
            label1.Click += label1_Click;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(236, 38);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(480, 30);
            txtHoTen.TabIndex = 1;
            // 
            // rad1
            // 
            rad1.AutoSize = true;
            rad1.Location = new Point(24, 40);
            rad1.Name = "rad1";
            rad1.Size = new Size(119, 26);
            rad1.TabIndex = 2;
            rad1.TabStop = true;
            rad1.Text = "chữ thường";
            rad1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rad2);
            groupBox1.Controls.Add(rad1);
            groupBox1.Location = new Point(50, 84);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(566, 137);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chọn kiểu chữ";
            // 
            // rad2
            // 
            rad2.AutoSize = true;
            rad2.Location = new Point(24, 88);
            rad2.Name = "rad2";
            rad2.Size = new Size(146, 26);
            rad2.TabIndex = 3;
            rad2.TabStop = true;
            rad2.Text = "CHỮ IN HOA";
            rad2.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(622, 95);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 126);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += button1_Click;
            // 
            // btnKQ
            // 
            btnKQ.Location = new Point(50, 227);
            btnKQ.Name = "btnKQ";
            btnKQ.Size = new Size(134, 39);
            btnKQ.TabIndex = 5;
            btnKQ.Text = "Kết quả";
            btnKQ.UseVisualStyleBackColor = true;
            btnKQ.Click += button2_Click;
            // 
            // txtKQ
            // 
            txtKQ.Location = new Point(209, 232);
            txtKQ.Name = "txtKQ";
            txtKQ.Size = new Size(507, 30);
            txtKQ.TabIndex = 6;
            // 
            // FrmBai2_2
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(744, 297);
            Controls.Add(txtKQ);
            Controls.Add(btnKQ);
            Controls.Add(btnXoa);
            Controls.Add(groupBox1);
            Controls.Add(txtHoTen);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmBai2_2";
            Text = "Đổi kiểu chữ";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtHoTen;
        private RadioButton rad1;
        private GroupBox groupBox1;
        private RadioButton rad2;
        private Button btnXoa;
        private Button btnKQ;
        private TextBox txtKQ;
    }
}
