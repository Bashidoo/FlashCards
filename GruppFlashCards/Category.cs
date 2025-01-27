using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppFlashCards
{
    public class Category
    {

        public List<FlashCard> flashCardID = new List<FlashCard>();

        public int categoryID { get; set; };

        public string categoryName { get; set; }
        public Category()
        {
            
        }
    }
}
