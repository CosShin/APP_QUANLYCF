using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.DTO;

namespace WindowsFormsApplication1.DAO
{
    class MenuDAO
    {
        private static MenuDAO instance;

        internal static MenuDAO Instance
        {
            get {if(instance == null ) instance = new MenuDAO(); return MenuDAO.instance; }
            private set { MenuDAO.instance = value; }
        }

        public List<Menu> GetLisMenuByTable(int id)
        {
            List<Menu> listMenu  = new List<Menu>();
            string query  = " SELECT f.name, bi.count, f.price, f.price * bi.count AS totalPrice FROM dbo.BillInfo AS bi, dbo.Bill AS b, dbo.Food AS f WHERE bi.idBill = b.id AND bi.idFood = f.id AND b.status = 0 AND b.idTable = " + id ;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow iteam in data.Rows) 
            {
                Menu menu = new Menu(iteam);
                listMenu.Add(menu);
            }
            return listMenu;
        }
    }
}
