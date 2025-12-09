using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.DTO;

namespace WindowsFormsApplication1.DAO
{
   public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            private set { BillDAO.instance = value; }
        }

        private BillDAO() { }


        public int GetUncheckBillIdTableId(int id) {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Bill WHERE idTable = " + id );

            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.Id;
            }

            return -1;
        }
       
       
       public void InsertBill(int id) 
        {
            DataProvider.Instance.ExecuteNonQuery(" USP_InsertBill @idTable ", new object[]{id});
        }
       

       
       
       public int GetMaxidBill()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("Select Max(id) from dbo.Bill") ;

            }
            catch 
            {
                
                
                return -1;
            }
            
        }
       public void CheckOut(int id, int discount, float totalPrice)
       {
           string query = "UPDATE dbo.Bill " +
                          "SET datecheckout = GETDATE(), " +
                          "status = 1, " +
                          "discount = " + discount + ", " +
                          "totalPrice = " + totalPrice + " " +
                          "WHERE id = " + id;
           DataProvider.Instance.ExecuteNonQuery(query);
       }


       public DataTable GetBillBydate(DateTime checkIn, DateTime checkOut ) {

           return DataProvider.Instance.ExecuteQuery("exec USP_GetListBillByDate @DateCheckIn , @DateCheckOut ", new object[] { checkIn, checkOut });
       
       }


    }
}
