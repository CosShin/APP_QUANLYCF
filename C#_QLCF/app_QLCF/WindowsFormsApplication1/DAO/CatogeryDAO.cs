using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.DTO;


namespace WindowsFormsApplication1.DAO
{
    public class CatogeryDAO
    {
        private static CatogeryDAO instance;

        public static CatogeryDAO Instance
        {
            get { if (instance == null) instance = new CatogeryDAO(); return CatogeryDAO.instance; }
            private set { CatogeryDAO.instance = value; }
        }
        private CatogeryDAO() { }
        public List<CategoryID> GetListCategory()
        {
            List<CategoryID> list = new List<CategoryID>();
            string query = "select * from FoodCategory";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow  item in data.Rows)
            {
                CategoryID category = new CategoryID(item);

                list.Add(category);
            }
            return list;
        
        }
        public CategoryID GetCategoryByID(int id)
        {
            CategoryID category = null;
            string query = "SELECT * FROM FoodCategory WHERE id = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                category = new CategoryID(item);
                return category;
            }

            return category;
        }

    }
}
