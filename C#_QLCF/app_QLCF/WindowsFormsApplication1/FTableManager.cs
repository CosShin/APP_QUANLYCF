using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.DAO;
using WindowsFormsApplication1.DTO;
using System.Globalization;

namespace WindowsFormsApplication1
{
    public partial class FTableManager : Form
    {
        private Account loginaccount;

        public Account Loginaccount
        {
            get { return loginaccount; }
            set { loginaccount = value; changAccount(loginaccount.Type); }
        }

        public FTableManager(Account acc)
        {
            InitializeComponent();
            this.loginaccount = acc;
            if (acc != null)
            {
                this.Loginaccount = acc; // Sử dụng thuộc tính để gọi setter
               
            }
            else
            {
                MessageBox.Show("Error: Account is null!");
            }
            loadTable();
            loadCategory();
            loadComboxTable(CBMoveTable);
            
            
                       
        }

        
        

        #region Method
        void loadCategory()
        {
            List<CategoryID> listCategory = CatogeryDAO.Instance.GetListCategory();
            cbcategory.DataSource = listCategory;
            cbcategory.DisplayMember = "name";
        }

        void changAccount(int type)
        {
            adimToolStripMenuItem.Enabled = type == 1;
            thongToolStripMenuItem.Text += "("+ loginaccount.Displayname+ ")";
        }
        void LoadCategoryById(int id) 
        {
            List<Food> listFood = FoodDAO.Instance.GetListFood(id);
            cbFood.DataSource = listFood;
            cbFood.DisplayMember = "name";
        
        }
        
        void loadTable()
        {
            flowLayoutPanel1.Controls.Clear();
            List<Table> tableList = TableDAO.Instance.loadTableList();

            foreach (Table iteam in tableList) {
                Button btn = new Button() { Width = TableDAO.tableWtih, Height = TableDAO.tableHeight };
                btn.Text = iteam.Name + Environment.NewLine + iteam.Status;
                btn.Click += btn_Click;
                btn.Tag = iteam;
                switch(iteam.Status){
                    case "Trống":
                        btn.BackColor = Color.Blue;
                        break;
                    default:
                        btn.BackColor = Color.Gray;
                        break;
                }
                flowLayoutPanel1.Controls.Add(btn);
            
            }
        }

        void showBill(int id) {
            listViewBill.Items.Clear();
            List<WindowsFormsApplication1.DTO.Menu> ListBillInfo = MenuDAO.Instance.GetLisMenuByTable(id);
            float totalPrice = 0;
            foreach (WindowsFormsApplication1.DTO.Menu iteam in ListBillInfo)
            {
                ListViewItem lsv = new ListViewItem(iteam.FoodName.ToString());
                lsv.SubItems.Add(iteam.Count.ToString());
                lsv.SubItems.Add(iteam.Price.ToString());
                lsv.SubItems.Add(iteam.TotalPrice.ToString());
                totalPrice += iteam.TotalPrice;
                listViewBill.Items.Add(lsv);
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            TxbTotalPrice.Text = totalPrice.ToString("N0", CultureInfo.GetCultureInfo("vi-VN")) ;

        }

        void loadComboxTable(ComboBox cb) 
        {
            cb.DataSource = TableDAO.Instance.loadTableList();
            cb.DisplayMember = "Name";

        }

        #endregion

        #region Events
        private void btn_Click(object sender, EventArgs e)
        {
            Table table = (sender as Button).Tag as Table;
            listViewBill.Tag = table; // Gán lại để dùng trong hàm thêm món
            showBill(table.Id);

        } 
        

        

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fACount f = new fACount(loginaccount);
            f.ShowDialog();

        }

        private void adimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FAdmin f = new FAdmin();
            f.ShowDialog();

        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {   
            int id =0;
      
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            CategoryID selected = cb.SelectedItem as CategoryID;
            id = selected.Id;
            LoadCategoryById(id);
            

        }
        private void BTADDFodd_Click(object sender, EventArgs e)
        {
            
            Table table = listViewBill.Tag as Table;
            
            int idBill = BillDAO.Instance.GetUncheckBillIdTableId(table.Id);
            int foodID = (cbFood.SelectedItem as Food).Id;
            int count = (int)numericUpDown1.Value;

            if (idBill == -1)
            {
                BillDAO.Instance.InsertBill(table.Id);
                BillInfoDAO.Instance.InsertBill(BillDAO.Instance.GetMaxidBill(), foodID, count);
                
            }
            else
            {
                BillInfoDAO.Instance.InsertBill(idBill , foodID, count);
                
            }
            loadTable();
            showBill(table.Id);
            

        }

        
        private void BT_pay_Click(object sender, EventArgs e)
        {
            Table table = listViewBill.Tag as Table;
            int idBill = BillDAO.Instance.GetUncheckBillIdTableId(table.Id);
            int discount = (int)numericUpDown2.Value;
            double totalPrice = Convert.ToDouble(TxbTotalPrice.Text.Split(',')[0]);
            double finalTotalPrice = totalPrice - (totalPrice/100)*discount;
            if (idBill != -1) 
            {
                if(MessageBox.Show(string.Format("Bạn có chắc muốn thanh toán cho bàn {0}?\nTổng tiền: {1:#,##0} VNĐ\nGiảm giá: {2}%\nThành tiền: {3:#,##0} VNĐ", table.Name, totalPrice, discount, finalTotalPrice),"Thông Báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    BillDAO.Instance.CheckOut(idBill, discount, (float)finalTotalPrice);
                    showBill(table.Id);
                    loadTable();
                }
                
            }

        }

        
        #endregion

       

        

        

        

        

        
    }
}
