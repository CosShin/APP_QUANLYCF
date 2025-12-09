using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.DTO
{
     public class Table
    {
         public Table(int id, String name, String status) 
         {
             this.Id = id;
             this.Name = name;
             this.Status = status;


         }

         public Table(DataRow row) {

             this.Id = (int)row["id"];
             this.Name = row["name"].ToString();
             this.Status = row["status"].ToString();
             
         }
         private String status;

        public String Status
        {
            get { return status; }
            set { status = value; }
        }
        private String name;

        public String Name
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
