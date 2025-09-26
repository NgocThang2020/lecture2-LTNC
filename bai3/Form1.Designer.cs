namespace bai3
{
    partial class Form1
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
            groupBox1 = new GroupBox();
            cboSo = new ComboBox();
            button1 = new Button();
            txtSo = new TextBox();
            groupBox2 = new GroupBox();
            lstTinh = new ListBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboSo);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtSo);
            groupBox1.Location = new Point(28, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(267, 125);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập số";
            // 
            // cboSo
            // 
            cboSo.FormattingEnabled = true;
            cboSo.Location = new Point(16, 77);
            cboSo.Name = "cboSo";
            cboSo.Size = new Size(234, 28);
            cboSo.TabIndex = 2;
            cboSo.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(156, 31);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Cập nhật";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtSo
            // 
            txtSo.Location = new Point(16, 32);
            txtSo.Name = "txtSo";
            txtSo.Size = new Size(125, 27);
            txtSo.TabIndex = 2;
            txtSo.TextChanged += textBox1_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lstTinh);
            groupBox2.Location = new Point(335, 31);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(316, 154);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách các ước số";
            // 
            // lstTinh
            // 
            lstTinh.FormattingEnabled = true;
            lstTinh.Location = new Point(29, 32);
            lstTinh.Name = "lstTinh";
            lstTinh.Size = new Size(262, 104);
            lstTinh.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(201, 261);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(335, 191);
            button3.Name = "button3";
            button3.Size = new Size(316, 29);
            button3.TabIndex = 4;
            button3.Text = "Tổng các ước số";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(335, 226);
            button4.Name = "button4";
            button4.Size = new Size(316, 29);
            button4.TabIndex = 5;
            button4.Text = "Số lượng các ước số chẵn";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(335, 261);
            button5.Name = "button5";
            button5.Size = new Size(316, 29);
            button5.TabIndex = 6;
            button5.Text = "Số lượng các số nguyên tố";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 312);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Combobox";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cboSo;
        private Button button1;
        private TextBox txtSo;
        private GroupBox groupBox2;
        private ListBox lstTinh;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}
