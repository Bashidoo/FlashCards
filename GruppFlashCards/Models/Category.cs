using System;
using System.Collections.Generic;

namespace GruppFlashCards.Models;

public partial class Category
{
    public int CategoryId { get; set; }

    public string CategoryName { get; set; } = null!;

    public virtual ICollection<FlashCard> FlashCards { get; set; } = new List<FlashCard>();
    public Category(int categoryid, string categoryname)
    {
        CategoryId = categoryid;
        CategoryName = categoryname;
        FlashCards = new List<FlashCard>();
    }
    public Category()
    {
        
    }
}
