// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using static LibraryConsoleAppTask.Book;
//using System.Text;
//using System.Threading.Tasks;
using LibraryConsoleAppTask;


class Library
{

    public void DisplayMenu()
    {
        Console.WriteLine("MainMenu");
        Console.WriteLine("1.View");
        Console.WriteLine("2.Borrow");
        Console.WriteLine("3.Return book");
        Console.WriteLine("4.AddNewBook()");
        //Console.WriteLine("5.SaveData");

    }

}

class Prpgram
{
   

    static Dictionary<string, Book> BooksDictionary = new Dictionary<string, Book>();
    static Dictionary<int,User> UserDictionary = new Dictionary<int,User>();
    public static void Main(string[] args)
    {
        //Console.Title "Login";
        //Console.WriteLine();
        Library library = new Library();

        while (true)
        {
            library.DisplayMenu();
            Console.WriteLine("enter your choice");
            string choice = Console.ReadLine();
            switch(choice)
            {
                case "1":
                    ViewAvailableBooks();
                    //Console.WriteLine("english,urdu,pashto");
                    break;
                    case "2":
                    if (LabAdmin()) BorrowBook() ;
                    else Console.WriteLine("borrowed ");
                    break;
                //return;
                case "3":
                    if (LabAdmin()) ReturnBook();
                    Console.WriteLine("Thanks for the Returning") ;
                    return;
                    //break;
                     case "4":
                    if (Admin()) AddNewBook();
                    else Console.WriteLine("Admin access required.");
                    break;
                //case "4":
                //AddNewBook();
                /*break*/

                case "5":

                    Console.WriteLine("Exit");
                    return;
                default:
                    Console.WriteLine("error plz try again");
                    break;

            }

        }
    }
    
    static void ViewAvailableBooks()
    {
        Console.WriteLine("");
        if(BooksDictionary.Values.Count > 0)
        foreach (var book in BooksDictionary.Values)
        {   
                Console.WriteLine($"Tittle is {book.Tittle} " +
                    $" Author Name is {book.Author}");
            
        }
    }
    static void BorrowBook()
    {
        Console.Write("Book borrowed successfully.Please return on timely ");
       
    }
    static void ReturnBook()
    {
        Console.WriteLine("Successfully Return .Thank you");
        
    }


    static void AddNewBook()
    {
        Console.Write("Enter the book's ISBN: ");
        //Console.Write();
        
        string isbn = Console.ReadLine();
        if (!BooksDictionary.ContainsKey(isbn))
        {
            Console.Write("Enter the book's title: ");
            string title = Console.ReadLine();
            Console.Write("Enter the author's name: ");
            string author = Console.ReadLine();
            BooksDictionary[isbn] = new Book(title, author,isbn);
            Console.WriteLine("Book added successfully.");
        }
        else
        {
            Console.WriteLine("Book with the same ISBN already exists.");
        }
    }
    static bool Admin()
    {
        Console.Write("Enter lib password: ");
        string password = Console.ReadLine();
        return password == "ttt";
    }
    static bool LabAdmin()
    {
        Console.Write("Enter ISBN:");
        string? password = Console.ReadLine();
        Console.Write("Enter your ID Library Card: ");
        string password2 = Console.ReadLine();
        return password == password2;
        return password == "ttt";
    }


}