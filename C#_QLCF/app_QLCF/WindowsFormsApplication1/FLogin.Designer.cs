namespace WindowsFormsApplication1
{
    partial class FLogin
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
            this.BTDangNhap = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TBPassWord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TBUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BTexit);
            this.panel1.Controls.Add(this.BTDangNhap);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 276);
            this.panel1.TabIndex = 0;
            // 
            // BTexit
            // 
            this.BTexit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTexit.Location = new System.Drawing.Point(404, 230);
            this.BTexit.Name = "BTexit";
            this.BTexit.Size = new System.Drawing.Size(117, 33);
            this.BTexit.TabIndex = 3;
            this.BTexit.Text = "Thoát";
            this.BTexit.UseVisualStyleBackColor = true;
            this.BTexit.Click += new System.EventHandler(this.BTexit_Click);
            // 
            // BTDangNhap
            // 
            this.BTDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTDangNhap.Location = new System.Drawing.Point(266, 230);
            this.BTDangNhap.Name = "BTDangNhap";
            this.BTDangNhap.Size = new System.Drawing.Size(117, 33);
            this.BTDangNhap.TabIndex = 3;
            this.BTDangNhap.Text = "Đăng Nhập";
            this.BTDangNhap.UseVisualStyleBackColor = true;
            this.BTDangNhap.Click += new System.EventHandler(this.BTDangNhap_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.TBPassWord);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(14, 110);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(519, 87);
            this.panel3.TabIndex = 1;
            // 
            // TBPassWord
            // 
            this.TBPassWord.Location = new System.Drawing.Point(236, 22);
            this.TBPassWord.Name = "TBPassWord";
            this.TBPassWord.Size = new System.Drawing.Size(240, 20);
            this.TBPassWord.TabIndex = 2;
            this.TBPassWord.Text = "123456";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mât Khẩu :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TBUserName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(14, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(519, 71);
            this.panel2.TabIndex = 0;
            // 
            // TBUserName
            // 
            this.TBUserName.Location = new System.Drawing.Point(236, 35);
            this.TBUserName.Name = "TBUserName";
            this.TBUserName.Size = new System.Drawing.Size(240, 20);
            this.TBUserName.TabIndex = 1;
            this.TBUserName.Text = "admin";
            this.TBUserName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FLogin
            // 
            this.AcceptButton = this.BTDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTexit;
            this.ClientSize = new System.Drawing.Size(589, 295);
            this.Controls.Add(this.panel1);
            this.Name = "FLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FLogin_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBUserName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TBPassWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTDangNhap;
        private System.Windows.Forms.Button BTexit;
    }
}

