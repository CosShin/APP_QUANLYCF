using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.DTO
{
    class Bill
    {

        public Bill(int id, DateTime? dateCheckin, DateTime dateCheckout, int status, int discount =0) {

            this.Id = id;
            this.DateCheckIn = dateCheckin;
            this.DateCheckOut = dateCheckout;
            this.Status = status;
            this.Discount = discount;
        }
        public Bill(DataRow row) {
            this.Id = (int)row["id"];
            this.DateCheckIn = (DateTime?)row["dateCheckin"];
            var dateCheckoutTemp = row["dateCheckout"];
            if(dateCheckoutTemp.ToString() != "")
                this.DateCheckOut = (DateTime?)dateCheckoutTemp;
            this.Status = (int)row["status"];
            this.Discount = (int)row["discount"];
        }
        private int discount;

        public int Discount
        {
            get { return discount; }
            set { discount = value; }
        }
        
        private int status;

        public int Status
        {
            get { return status; }
            set { status = value; }
        }
        private DateTime? dateCheckOut;

        public DateTime? DateCheckOut
        {
            get { return dateCheckOut; }
            set { dateCheckOut = value; }
        }
        private DateTime? DateCheckIn;

        public DateTime? DateCheckIn1
        {
            get { return DateCheckIn; }
            set { DateCheckIn = value; }
        }
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }


    }
}
