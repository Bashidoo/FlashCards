using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppFlashCards
{
    public class FlashCard
    {
        private static readonly Random random = new Random();
        public int FlashCardID { get; set; }

        public string flashCardName { get; set; }

        public string flashCardDescription { get; set; }

        public DateOnly flashCardInterval { get; set; }

        public FlashCard()
        {
            
        }
    }
}
