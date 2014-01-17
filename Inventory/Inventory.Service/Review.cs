using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace InventoryService
{
    public class Review
    {
        public Review(int rating, string reviewText)
        {
            ReviewText = reviewText;
            Rating = rating;
        }

        public int Rating { get; private set; }
        public string ReviewText { get; private set; }
    }
}


