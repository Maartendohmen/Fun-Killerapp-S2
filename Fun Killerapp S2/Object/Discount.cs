using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun_Killerapp_S2.Object
{
    public class Discount
    {
        private int discountid;
        private int amount;
        private int date;
        private string comment;

        public int DiscountID
        {
            get { return discountid; }
            private set { discountid = value; }
        }

        public int Amount
        {
            get { return amount; }
            private set { amount = value; }
        }

        public int Date
        {
            get { return date; }
            private set { date = value; }
        }

        public string Comment
        {
            get { return comment; }
            private set { comment = value; }
        }

        public Discount(int discountid, int amount, int date, string comment)
        {
            this.discountid = discountid;
            this.amount = amount;
            this.date = date;
            this.comment = comment;
        }
    }
}
