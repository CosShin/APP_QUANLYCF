using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.DTO;

namespace WindowsFormsApplication1.DAO
{
     public class FoodDAO
    {
        private static FoodDAO instance;

        public static FoodDAO Instance
        {
            get { if (instance == null) instance = new FoodDAO(); return FoodDAO.instance; }
            private set { FoodDAO.instance = value; }
        }
        private FoodDAO() { }

        public List<Food> GetListFood(int id) 
        {
            List<Food> list = new List<Food>();
            string query = " select * from Food where idCategory ="+id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
                
            }
            return list;

        }

        public List<Food> GetListFood()
        {
            List<Food> list = new List<Food>();

            string query = "SELECT * FROM Food";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }

            return list;
        }
        public bool insertFood(string name, int id, float price) 
        {
            string query = string.Format("INSERT FOOD (name, idcategory, price)VALUES (N'{0}', {1}, {2})", name, id, price);

            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
       
         public bool UpdateFood(string name, int categoryID, float price, int id)
        {
            string query = string.Format("UPDATE Food SET name = N'{0}', idcategory = {1}, price = {2} WHERE id = {3}",
                                         name.Replace("'", "''"), categoryID, price, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
         public bool DeleteFood(int id)
         {
             string query = string.Format("DELETE FROM Food WHERE id = {0}", id);
             int result = DataProvider.Instance.ExecuteNonQuery(query);
             return result > 0;
         }

         public List<Food> SearchFoodByName(string name)
         {
             List<Food> list = new List<Food>();

             string query = string.Format(
                 "SELECT * FROM dbo.Food WHERE dbo.fuConvertToUnsign1(name) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + N'%'", name
             );

             DataTable data = DataProvider.Instance.ExecuteQuery(query);

             foreach (DataRow item in data.Rows)
             {
                 Food food = new Food(item);
                 list.Add(food);
             }

             return list;
         }




    }
}
