using LibrarySystem.Inheritance;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;


namespace LibrarySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, LibraryItems> libraryStock = new Dictionary<string, LibraryItems>();
            bool userOff = false;

            while(!userOff)
            {
                try
                {
                    Console.WriteLine("Library System Menu: ");
                    Console.WriteLine("1. Add Item");
                    Console.WriteLine("2. Delete Item by ID");
                    Console.WriteLine("3. Search Item using ID");
                    Console.WriteLine("4. Display All Item");
                    Console.WriteLine("5. Exit");
                    string choice = Console.ReadLine();
                    int intChoice = int.Parse(choice);

                    switch (intChoice)
                    {
                        case 1:
                            Console.WriteLine("Choose an item to add to the library list");
                            Console.WriteLine("1. Book");
                            Console.WriteLine("2. Magazine");
                            Console.WriteLine("3. DVD");

                            string itemChoice = Console.ReadLine();
                            int intItemChoice = int.Parse(itemChoice);
                            if (intItemChoice == 1)
                            {
                                Console.WriteLine("What is the Book ID? (B: 0-9)");
                                string bookId = Console.ReadLine();

                                Console.WriteLine("What is the Book Title?");
                                string bookTitle = Console.ReadLine();
                                    
                                Console.WriteLine("What is the Year published?");
                                string bookYearPublished = Console.ReadLine();

                                Console.WriteLine("Who is the Author?");
                                string bookAuthor = Console.ReadLine();

                                Console.WriteLine("What is the Book Genre?");
                                string bookGenre = Console.ReadLine();


                                LibraryItems bookItem = new Books(bookId.ToUpper(),bookTitle.ToUpper(), bookYearPublished, bookAuthor.ToUpper(), bookGenre.ToUpper());
                                libraryStock.Add(bookId, bookItem);
                                Console.WriteLine("Book Successfully Added to the Library List!");
                            }

                            if (intItemChoice == 2)
                            {
                                Console.WriteLine("What is the Magazine ID? (M: 0-9)");
                                string magazineId = Console.ReadLine();

                                Console.WriteLine("What is the Magazine Title?");
                                string magazineTitle = Console.ReadLine();

                                Console.WriteLine("What is the Year published?");
                                string magazineYearPublished = Console.ReadLine();

                                Console.WriteLine("What is the Magazine issue number??");
                                string issueNumber = Console.ReadLine();
                                int intIssueNumber = int.Parse(issueNumber);

                                Console.WriteLine("What is the Month it was realeased?");
                                string magazineMonth = Console.ReadLine();

                                LibraryItems magazineItem = new Magazines(magazineId.ToUpper(), magazineTitle.ToUpper().ToUpper(), magazineYearPublished, intIssueNumber, magazineMonth.ToUpper());
                                libraryStock.Add(magazineId , magazineItem);
                                Console.WriteLine("Magazine Successfully Added to the Library List!");
                            }
                            if (intItemChoice == 3)
                            {
                                Console.WriteLine("What is the DVD ID? (D: 0-9)");
                                string dvdId = Console.ReadLine();

                                Console.WriteLine("What is the DVD Title?");
                                string magazineTitle = Console.ReadLine();

                                Console.WriteLine("What is the Year published?");
                                string dvdYearPublished = Console.ReadLine();

                                Console.WriteLine("Who is the Director?");
                                string dvdDirector = Console.ReadLine();

                                Console.WriteLine("What is the duration of the DVD? (Hrs)");
                                string dvdHours = Console.ReadLine();

                                Console.WriteLine("What is the duration of the DVD? (Mins)");
                                string dvdmins = Console.ReadLine();


                                LibraryItems dvdItem = new Dvds(dvdId.ToUpper(), magazineTitle.ToUpper(), dvdYearPublished, dvdDirector.ToUpper(), $"{dvdHours} HOUR(S) & {dvdmins} MINS");
                                libraryStock.Add(dvdId, dvdItem);
                                Console.WriteLine("DVD Successfully Added to the Library List!");
                            }

                            Console.WriteLine("\nPress Enter to return to the menu...");
                            Console.ReadLine();
                            Console.Clear();

                            break;
                        case 2:
                            Console.WriteLine("Choose an item to remove from the library list");
                            string removeId = Console.ReadLine();

                            if (libraryStock.ContainsKey(removeId))
                            {
                                libraryStock.Remove(removeId);
                                Console.WriteLine("Successfully removed");
                            }
                            else
                            {
                                Console.WriteLine("Item does not exist! Try Again");
                            }

                            Console.WriteLine("\nPress Enter to return to the menu...");
                            Console.ReadLine();
                            Console.Clear();

                            break;
                        case 3:
                            Console.WriteLine("What is the ID of the item wanted from the library list?");
                            string itemSearch = Console.ReadLine();

                            if (libraryStock.ContainsKey(itemSearch))
                            {
                                LibraryItems searchedItem = libraryStock[itemSearch];
                                searchedItem.DisplayItems();
                            }
                            else
                            {
                                Console.WriteLine("Item Not Found! Try Again");
                            }

                            Console.WriteLine("\nPress Enter to return to the menu...");
                            Console.ReadLine();
                            Console.Clear();

                            break;
                        case 4:

                            Console.Clear();
                            Console.WriteLine("All Items in Library:\n");

                            foreach (var item in libraryStock.Values)
                            {
                                item.DisplayItems();
                            }

                            Console.WriteLine("Press Enter to return to the menu...");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case 5:
                            userOff = true;
                            Console.Clear();
                            Console.WriteLine("Exiting... Thank you for using the Library System.");
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid Choice, Try Again!");
                }
            }
        }
    }
}