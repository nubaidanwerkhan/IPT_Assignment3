using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPT_Assignment3.Data.Helper
{
    public class CustomerHelper
    {
        IPT_Assignment3Entities db = new IPT_Assignment3Entities();
        public void Insert(Customer customer)
        {
            db.Customers.Add(customer);
            db.SaveChanges();
            db.Dispose();
        }
    }
}
