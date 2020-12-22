using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPT_Assignment3.Data.Helper
{
    public class PackageHelper
    {
        IPT_Assignment3Entities db = new IPT_Assignment3Entities();
        public void Insert(Package packae)
        {
            db.Packages.Add(packae);
            db.SaveChanges();
            db.Dispose();
        }
    }
}
