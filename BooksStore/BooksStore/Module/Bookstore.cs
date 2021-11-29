using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksStore.Module
{
       public class BookStore
        {
            public string Title { get; set; }
            public string Description { get; set; }
            public int Amount { get; set; }

            public BookStore(string title, string description, int amount)
            {
                Title = title;
                Description = description;
                Amount = amount;
            }
        }
   
}
