using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPT_Assignment3.Data.Helper
{
    public class OrderHelper
    {
        IPT_Assignment3Entities db = new IPT_Assignment3Entities();
        public void Insert(Order order) 
        {
            db.Orders.Add(order);
            db.SaveChanges();
        }
    }
}
