using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.DTO;

namespace WindowsFormsApplication1.DAO
{
    public class AccountDAO
{
    private static AccountDAO instance;

    public static AccountDAO Instance
    {
        get
        {
            if (instance == null)
                instance = new AccountDAO();
            return instance;
        }
        private set
        {
            instance = value;
        }
    }

    private AccountDAO() { }


    public bool Login(string userName, string password)
    {
        string query = "USP_Login @userName , @passWord ";  
        DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[]{userName, password} );
        return result.Rows.Count > 0;
    }
    public Account GetAccountBytheName(string name)
    {
  
            string query = "SELECT * FROM Account WHERE Username = @username";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { name });
            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }
            
            return null;
        
    }
    public bool UpdateAccount(string userName, string displayName, string pass, string newPass)
    {
        int result = DataProvider.Instance.ExecuteNonQuery( "EXEC USP_UpdateAccount @userName , @displayName , @password , @newPassword ",new object[] { userName, displayName, pass, newPass});

        return result > 0;
    }







}

}
