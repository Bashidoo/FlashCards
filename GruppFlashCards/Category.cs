using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppFlashCards
{
    public class Category
    {


        public int categoryID { get; set; } 

        public string categoryName { get; set; }
        public Category(int categoryid, string categoryname)
        {
            categoryID = categoryid;
            categoryName = categoryname;
        }
    }
}
