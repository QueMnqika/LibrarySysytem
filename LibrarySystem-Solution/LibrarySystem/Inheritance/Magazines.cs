using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Inheritance
{
    internal class Magazines : LibraryItems
    {
        public string month {  get; set; }
        public int issueNumber {  get; set; }

        public Magazines(string id, string title, string yearPublished, int  issueNumber, string month) : base (id, title, yearPublished)
        {
            this.month = month;
            this.issueNumber = issueNumber;
        }

        public override void DisplayItems()
        {
            Console.WriteLine($"ID: {id}; Title: {title}; Year: {yearPublished}; Month: {month}; Issue Number: {issueNumber}\n\n");
        }
    }
}
