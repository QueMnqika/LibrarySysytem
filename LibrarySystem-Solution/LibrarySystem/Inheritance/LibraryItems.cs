using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Inheritance
{
    internal class LibraryItems
    {
        public string id { get; set; }
        public string title { get; set; }
        public string yearPublished { get; set; }

        public LibraryItems(string id, string title, string yearPublished)
        {
            this.id = id;
            this.title = title;
            this.yearPublished = yearPublished;
        }

        public virtual void DisplayItems()
        {
            Console.WriteLine($"ID: {id}; Title: {title}; Year: {yearPublished}\n\n");
        }
     
    }
}
