using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Inheritance
{
    internal class Books : LibraryItems
    {
        private string author { get; set; }
        private string genre { get; set; }

        public Books (string id, string title, string yearPublished, string author, string genre) : base (id, title, yearPublished)
        {
            this.author = author;
            this.genre = genre;
        }

        public override void DisplayItems()
        {
            Console.WriteLine($"ID: {id}; Title: {title}; Year: {yearPublished}; Author: {author}; Genre: {genre}\n\n");
        }
    }
}
