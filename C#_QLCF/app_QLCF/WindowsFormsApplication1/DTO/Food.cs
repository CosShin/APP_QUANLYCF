using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.DTO
{
    public class Food
    {
        public Food(int id, string name, int category, float price) 
        {
            this.Id = id;
            this.Name = name;
            this.Category = category;
            this.Price = price;

        }
        public Food(DataRow row) 
        {
            this.Id = (int)row["id"];
            this.Name = row["name"].ToString();
            this.Category = (int)row["idCategory"];
            this.Price = (float)Convert.ToDouble(row["price"].ToString());
        }
        private float price;

        public float Price
        {
            get { return price; }
            set { price = value; }
        }
        private int category;

        public int Category
        {
            get { return category; }
            set { category = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}
