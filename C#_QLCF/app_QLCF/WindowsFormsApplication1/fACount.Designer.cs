namespace WindowsFormsApplication1
{
    partial class fACount
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTexit = new System.Windows.Forms.Button();
            this.BTUpDate = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txbcomfimpassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txbnewPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxBdisplayName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BTexit);
            this.panel1.Controls.Add(this.BTUpDate);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(563, 477);
            this.panel1.TabIndex = 0;
            // 
            // BTexit
            // 
            this.BTexit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTexit.Location = new System.Drawing.Point(407, 411);
            this.BTexit.Name = "BTexit";
            this.BTexit.Size = new System.Drawing.Size(96, 53);
            this.BTexit.TabIndex = 12;
            this.BTexit.Text = "Thoát";
            this.BTexit.UseVisualStyleBackColor = true;
            this.BTexit.Click += new System.EventHandler(this.BTexit_Click);
            // 
            // BTUpDate
            // 
            this.BTUpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.BTUpDate.Location = new System.Drawing.Point(281, 411);
            this.BTUpDate.Name = "BTUpDate";
            this.BTUpDate.Size = new System.Drawing.Size(106, 53);
            this.BTUpDate.TabIndex = 11;
            this.BTUpDate.Text = "Cập nhật";
            this.BTUpDate.UseVisualStyleBackColor = true;
            this.BTUpDate.Click += new System.EventHandler(this.BTUpDate_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txbcomfimpassword);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(13, 322);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(519, 71);
            this.panel5.TabIndex = 10;
            // 
            // txbcomfimpassword
            // 
            this.txbcomfimpassword.Location = new System.Drawing.Point(236, 35);
            this.txbcomfimpassword.Name = "txbcomfimpassword";
            this.txbcomfimpassword.Size = new System.Drawing.Size(240, 20);
            this.txbcomfimpassword.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nhập Lại";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txbnewPassword);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(13, 245);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(519, 71);
            this.panel4.TabIndex = 9;
            // 
            // txbnewPassword
            // 
            this.txbnewPassword.Location = new System.Drawing.Point(236, 35);
            this.txbnewPassword.Name = "txbnewPassword";
            this.txbnewPassword.Size = new System.Drawing.Size(240, 20);
            this.txbnewPassword.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mật Khẩu Mới:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbPassword);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(13, 168);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(519, 71);
            this.panel3.TabIndex = 8;
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(236, 35);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(240, 20);
            this.txbPassword.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mật Khẩu";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TxBdisplayName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(13, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(519, 71);
            this.panel2.TabIndex = 7;
            // 
            // TxBdisplayName
            // 
            this.TxBdisplayName.Location = new System.Drawing.Point(236, 35);
            this.TxBdisplayName.Name = "TxBdisplayName";
            this.TxBdisplayName.Size = new System.Drawing.Size(240, 20);
            this.TxBdisplayName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Hiển Thị ";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txbName);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Location = new System.Drawing.Point(13, 14);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(519, 71);
            this.panel6.TabIndex = 6;
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(236, 35);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(240, 20);
            this.txbName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Đăng Nhập :";
            // 
            // fACount
            // 
            this.AcceptButton = this.BTUpDate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTexit;
            this.ClientSize = new System.Drawing.Size(587, 501);
            this.Controls.Add(this.panel1);
            this.Name = "fACount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông Tin Cá Nhân";
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

       

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BTexit;
        private System.Windows.Forms.Button BTUpDate;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txbcomfimpassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txbnewPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TxBdisplayName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label label1;
    }
}