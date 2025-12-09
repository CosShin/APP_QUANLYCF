using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.DTO;
using System.Data;
namespace WindowsFormsApplication1.DAO
{
    class TableDAO
    {
        private static TableDAO instance;

        internal static TableDAO Instance
        {
            get { if (instance == null) instance = new TableDAO(); return TableDAO.instance; }
           private set { TableDAO.instance = value; }
        }
        private TableDAO() { }
        public static int  tableWtih = 100;
        public static int tableHeight = 100;

        public List<Table> loadTableList() { 
        
            List<Table> tableList = new List<Table>();
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetTableList");
            
            foreach (DataRow iteam in data.Rows){
                Table table = new Table(iteam);
                tableList.Add(table);
            } 
            return tableList;

        }
        
    }
}
