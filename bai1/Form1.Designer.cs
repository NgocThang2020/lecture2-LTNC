﻿namespace bai1
{
    partial class FrmBai1_1
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
            chkNho = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            txtUser = new TextBox();
            txtPass = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // chkNho
            // 
            chkNho.AutoSize = true;
            chkNho.Location = new Point(100, 189);
            chkNho.Name = "chkNho";
            chkNho.Size = new Size(110, 30);
            chkNho.TabIndex = 0;
            chkNho.Text = "Ghi nhớ";
            chkNho.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 65);
            label1.Name = "label1";
            label1.Size = new Size(151, 26);
            label1.TabIndex = 1;
            label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 126);
            label2.Name = "label2";
            label2.Size = new Size(99, 26);
            label2.TabIndex = 2;
            label2.Text = "Mật khẩu";
            label2.Click += label2_Click;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(288, 62);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(276, 33);
            txtUser.TabIndex = 3;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(288, 123);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(276, 33);
            txtPass.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(100, 265);
            button1.Name = "button1";
            button1.Size = new Size(123, 40);
            button1.TabIndex = 5;
            button1.Text = "Đăng nhập";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(288, 265);
            button2.Name = "button2";
            button2.Size = new Size(94, 40);
            button2.TabIndex = 6;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(470, 265);
            button3.Name = "button3";
            button3.Size = new Size(94, 40);
            button3.TabIndex = 7;
            button3.Text = "Dừng";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // FrmBai1_1
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(655, 365);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(chkNho);
            Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FrmBai1_1";
            Text = "Form Đăng Nhập";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkNho;
        private Label label1;
        private Label label2;
        private TextBox txtUser;
        private TextBox txtPass;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
