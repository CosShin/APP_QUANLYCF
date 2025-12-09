namespace WindowsFormsApplication1
{
    partial class FTableManager
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.BTADDFodd = new System.Windows.Forms.Button();
            this.cbFood = new System.Windows.Forms.ComboBox();
            this.cbcategory = new System.Windows.Forms.ComboBox();
            this.listViewBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.TxbTotalPrice = new System.Windows.Forms.TextBox();
            this.BT_chuyenBan = new System.Windows.Forms.Button();
            this.BTDiscount = new System.Windows.Forms.Button();
            this.CBMoveTable = new System.Windows.Forms.ComboBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.BT_pay = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adimToolStripMenuItem,
            this.thongToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1095, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adimToolStripMenuItem
            // 
            this.adimToolStripMenuItem.Name = "adimToolStripMenuItem";
            this.adimToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.adimToolStripMenuItem.Text = "Adim";
            this.adimToolStripMenuItem.Click += new System.EventHandler(this.adimToolStripMenuItem_Click);
            // 
            // thongToolStripMenuItem
            // 
            this.thongToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thongToolStripMenuItem.Name = "thongToolStripMenuItem";
            this.thongToolStripMenuItem.Size = new System.Drawing.Size(135, 20);
            this.thongToolStripMenuItem.Text = "Thông Tin Tài khoảng";
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.thôngTinToolStripMenuItem.Text = "Thông Tin";
            this.thôngTinToolStripMenuItem.Click += new System.EventHandler(this.thôngTinToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.numericUpDown1);
            this.panel2.Controls.Add(this.BTADDFodd);
            this.panel2.Controls.Add(this.cbFood);
            this.panel2.Controls.Add(this.cbcategory);
            this.panel2.Controls.Add(this.listViewBill);
            this.panel2.Location = new System.Drawing.Point(602, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(481, 427);
            this.panel2.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(419, 30);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(59, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BTADDFodd
            // 
            this.BTADDFodd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.BTADDFodd.Location = new System.Drawing.Point(306, 8);
            this.BTADDFodd.Name = "BTADDFodd";
            this.BTADDFodd.Size = new System.Drawing.Size(107, 61);
            this.BTADDFodd.TabIndex = 2;
            this.BTADDFodd.Text = "Thêm Món";
            this.BTADDFodd.UseVisualStyleBackColor = true;
            this.BTADDFodd.Click += new System.EventHandler(this.BTADDFodd_Click);
            // 
            // cbFood
            // 
            this.cbFood.FormattingEnabled = true;
            this.cbFood.Location = new System.Drawing.Point(13, 42);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(287, 21);
            this.cbFood.TabIndex = 1;
            // 
            // cbcategory
            // 
            this.cbcategory.FormattingEnabled = true;
            this.cbcategory.Location = new System.Drawing.Point(13, 13);
            this.cbcategory.Name = "cbcategory";
            this.cbcategory.Size = new System.Drawing.Size(287, 21);
            this.cbcategory.TabIndex = 0;
            this.cbcategory.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listViewBill
            // 
            this.listViewBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewBill.GridLines = true;
            this.listViewBill.Location = new System.Drawing.Point(3, 80);
            this.listViewBill.Name = "listViewBill";
            this.listViewBill.Size = new System.Drawing.Size(475, 344);
            this.listViewBill.TabIndex = 0;
            this.listViewBill.UseCompatibleStateImageBehavior = false;
            this.listViewBill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên Món";
            this.columnHeader1.Width = 144;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số Lượng";
            this.columnHeader2.Width = 61;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn Giá";
            this.columnHeader3.Width = 98;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành Tiền";
            this.columnHeader4.Width = 165;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.TxbTotalPrice);
            this.panel3.Controls.Add(this.BT_chuyenBan);
            this.panel3.Controls.Add(this.BTDiscount);
            this.panel3.Controls.Add(this.CBMoveTable);
            this.panel3.Controls.Add(this.numericUpDown2);
            this.panel3.Controls.Add(this.BT_pay);
            this.panel3.Location = new System.Drawing.Point(599, 462);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(481, 87);
            this.panel3.TabIndex = 3;
            // 
            // TxbTotalPrice
            // 
            this.TxbTotalPrice.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbTotalPrice.Location = new System.Drawing.Point(209, 20);
            this.TxbTotalPrice.Name = "TxbTotalPrice";
            this.TxbTotalPrice.ReadOnly = true;
            this.TxbTotalPrice.Size = new System.Drawing.Size(165, 30);
            this.TxbTotalPrice.TabIndex = 8;
            this.TxbTotalPrice.Text = "0";
            this.TxbTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BT_chuyenBan
            // 
            this.BT_chuyenBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.BT_chuyenBan.Location = new System.Drawing.Point(3, 3);
            this.BT_chuyenBan.Name = "BT_chuyenBan";
            this.BT_chuyenBan.Size = new System.Drawing.Size(103, 46);
            this.BT_chuyenBan.TabIndex = 7;
            this.BT_chuyenBan.Text = "Chuyển Bàn";
            this.BT_chuyenBan.UseVisualStyleBackColor = true;
            // 
            // BTDiscount
            // 
            this.BTDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.BTDiscount.Location = new System.Drawing.Point(112, 4);
            this.BTDiscount.Name = "BTDiscount";
            this.BTDiscount.Size = new System.Drawing.Size(91, 46);
            this.BTDiscount.TabIndex = 6;
            this.BTDiscount.Text = "Giảm Giá";
            this.BTDiscount.UseVisualStyleBackColor = true;
            // 
            // CBMoveTable
            // 
            this.CBMoveTable.FormattingEnabled = true;
            this.CBMoveTable.Location = new System.Drawing.Point(3, 53);
            this.CBMoveTable.Name = "CBMoveTable";
            this.CBMoveTable.Size = new System.Drawing.Size(103, 21);
            this.CBMoveTable.TabIndex = 5;
            this.CBMoveTable.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(112, 54);
            this.numericUpDown2.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(91, 20);
            this.numericUpDown2.TabIndex = 4;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BT_pay
            // 
            this.BT_pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.BT_pay.Location = new System.Drawing.Point(380, 3);
            this.BT_pay.Name = "BT_pay";
            this.BT_pay.Size = new System.Drawing.Size(98, 71);
            this.BT_pay.TabIndex = 3;
            this.BT_pay.Text = "Thanh Toán ";
            this.BT_pay.UseVisualStyleBackColor = true;
            this.BT_pay.Click += new System.EventHandler(this.BT_pay_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 27);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(584, 522);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // FTableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 559);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FTableManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Phần mềm quản lý Cà Phê";
           
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button BTADDFodd;
        private System.Windows.Forms.ComboBox cbFood;
        private System.Windows.Forms.ComboBox cbcategory;
        private System.Windows.Forms.ListView listViewBill;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BTDiscount;
        private System.Windows.Forms.ComboBox CBMoveTable;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button BT_pay;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button BT_chuyenBan;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox TxbTotalPrice;
    }
}