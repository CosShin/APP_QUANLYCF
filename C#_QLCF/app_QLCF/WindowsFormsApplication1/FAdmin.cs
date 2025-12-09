using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApplication1.DAO;
using WindowsFormsApplication1.DTO;

namespace WindowsFormsApplication1
{
    public partial class FAdmin : Form
    {
        BindingSource foodList = new BindingSource();
        public FAdmin()
        {
            InitializeComponent();
            dataViewFood.DataSource = foodList;
            loadListBydate(dateTimePicker1.Value, dateTimePicker2.Value);
            loadAddFoodBindding();
            loadTimerPicker();
            loadComboxgetLisFood(CB_DAnhMuc);
          
        }
        
        

        #region methods
        void loadListBydate(DateTime checkIn, DateTime checkOut)
        {
            dataGridView1.DataSource = BillDAO.Instance.GetBillBydate(checkIn, checkOut);


        }
        void loadTimerPicker()
        {
            DateTime today = DateTime.Now;
            dateTimePicker1.Value = new DateTime(today.Year, today.Month, 1);
            dateTimePicker2.Value = dateTimePicker2.Value.AddMonths(1).AddDays(-1);
        }
        void loadListfood()
        {
            foodList.DataSource = FoodDAO.Instance.GetListFood();
            foodList.ResetBindings(false); // <== Thêm dòng này
        }


        void loadAddFoodBindding()
        {
            foodList.DataSource = FoodDAO.Instance.GetListFood();
            dataViewFood.DataSource = foodList;
            TBNameFood.DataBindings.Add(new Binding("Text", dataViewFood.DataSource, "Name",true, DataSourceUpdateMode.Never ));
            TBID.DataBindings.Add(new Binding("Text", dataViewFood.DataSource, "id", true, DataSourceUpdateMode.Never));

            numericPỉce.DataBindings.Add(new Binding("Value", dataViewFood.DataSource, "Price", true, DataSourceUpdateMode.Never));
        }
        void loadComboxgetLisFood(ComboBox cb)
        {
            cb.DataSource = CatogeryDAO.Instance.GetListCategory();
            cb.DisplayMember = "Name";
        }
        #endregion


        #region events

        private void button1_Click(object sender, EventArgs e)
        {
            dataViewFood.DataSource = FoodDAO.Instance.SearchFoodByName(TBSEARCHName.Text);
        }
        private void BTViewBill_Click(object sender, EventArgs e)
        {
            loadListBydate(dateTimePicker1.Value, dateTimePicker2.Value);
        }

        private void BTView_Click(object sender, EventArgs e)
        {
            loadListfood();
        }
        private void BTaddFood_Click(object sender, EventArgs e)
        {
            string name = TBNameFood.Text;
            int categoryID = (CB_DAnhMuc.SelectedItem as CategoryID).Id;
            float price= (float)numericPỉce.Value;
            if (FoodDAO.Instance.insertFood(name, categoryID, price))
            {
                MessageBox.Show("Insert food succesful.");
                loadListfood();
            }
            else {
                MessageBox.Show("error cannot add food!!!!");
            }
        }


        private void BTUpDATE_Click(object sender, EventArgs e)
        {

            string name = TBNameFood.Text;
            int categoryID = (CB_DAnhMuc.SelectedItem as CategoryID).Id;
            float price = (float)numericPỉce.Value;
            int id = Convert.ToInt32(TBID.Text);
            if (FoodDAO.Instance.UpdateFood(name, categoryID, price, id))
            {
                MessageBox.Show("UPADATE food succesful.");
                loadListfood();
            }
            else
            {
                MessageBox.Show("error cannot UPADATE food!!!!");
            }
        }

        private void BTRemove_Click(object sender, EventArgs e)
        {
            string name = TBNameFood.Text;
            int categoryID = (CB_DAnhMuc.SelectedItem as CategoryID).Id;
            float price = (float)numericPỉce.Value;
            int id = Convert.ToInt32(TBID.Text);
            if (FoodDAO.Instance.DeleteFood(id))
            {
                MessageBox.Show("DELETE food succesful.");
                loadListfood();
            }
            else
            {
                MessageBox.Show("error cannot DELETE food!!!!");
            }

        }

        #endregion
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabControll_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataViewFood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BTViewCatory_Click(object sender, EventArgs e)
        {

        }

        private void BTRemoveCatory_Click(object sender, EventArgs e)
        {

        }

        private void BTUpDateCatogory_Click(object sender, EventArgs e)
        {

        }

        private void BTAddCategory_Click(object sender, EventArgs e)
        {

        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel18_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TBID_TextChanged(object sender, EventArgs e)
        {
            if (dataViewFood.SelectedCells.Count > 0)
            {
                int id = (int)dataViewFood.SelectedCells[0].OwningRow.Cells["category"].Value;
                CategoryID category = CatogeryDAO.Instance.GetCategoryByID(id);

                CB_DAnhMuc.SelectedItem = category;

                int index = -1;
                int i = 0;

                foreach (CategoryID item in CB_DAnhMuc.Items)
                {
                    if (item.Id == category.Id)
                    {
                        index = i;
                        break;
                    }
                    i++;
                }

                CB_DAnhMuc.SelectedIndex = index;
            }
        }

       

    }
}
