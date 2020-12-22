using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IPT_Assignment3.Data;
using IPT_Assignment3.Data.Helper;

namespace IPT_Assignment3.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var packagehelper = new PackageHelper();
            var package = new Package { 
                Name = "Icon design",
                Price = 10,
                Description = "2 unique icon design"
            };

            packagehelper.Insert(package);

        }
    }
}
