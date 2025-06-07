using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace LibrarySystem.Inheritance
{
    internal class Dvds : LibraryItems
    {
        public string director {  get; set; }
        public string duration {  get; set; }
        public Dvds(string id, string title, string yearPublished, string director, string duration) : base(id, title, yearPublished)
        {
            this.director = director;
            this.duration = duration;
        }

        public override void DisplayItems()
        {
            Console.WriteLine($"ID: {id}; Title: {title}; Year: {yearPublished}; Director: {director}; Duration: {duration}\n\n");
        }
    }
}
