using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.DTO
{
    public class Account
    {
        public Account(string name, string displayname, int type , string password = null) 
        {
            this.Name = name;
            this.Displayname = displayname;
            this.Type = type;
            this.Password = password;
        }

        public Account(DataRow row )
 
        {
            this.Name = row["UserName"].ToString();
            this.Displayname = row["Displayname"].ToString();
            this.Type = (int)row["type"];
            this.Password = row["password"].ToString();
        }
        private string displayname;

        public string Displayname
        {
            get { return displayname; }
            set { displayname = value; }
        }
        private int type;

        public int Type
        {
            get { return type; }
            set { type = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}
