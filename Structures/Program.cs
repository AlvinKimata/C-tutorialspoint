//Structures enables one to create a dtype that holds related data of various data types.
using System;

struct Books
{
    public string title;
    public string author;
    public string subject;
    public string book_id;
};

public class testStructure
{
    public static void Main(string[] args)
    {
        Books book1;
        Books book2;

        //Book 1 specifications.
        book1.title = "C programming";
        book1.author = "Nuha Ali";
        book1.subject = "C programming tutorial";
        book1.book_id = 6495408.ToString();

        //Book 2 specifications.
        book2.title = "Telecom billing";
        book2.author = "Dele Ali";
        book2.subject = "Telecom billing tutorial";
        book2.book_id = 6495407.ToString();

        //Print book 1 information.
        Console.WriteLine("Book 1 title: {0}", book1.title);
        Console.WriteLine("Book 1 author: {0}", book1.author);
        Console.WriteLine("Book 1 subject: {0}", book1.subject);
        Console.WriteLine("Book 1 book_id: {0} \n", book1.book_id);

        //Print book 2 information.
        Console.WriteLine("Book 2 title: {0}", book2.title);
        Console.WriteLine("Book 2 author: {0}", book2.author);
        Console.WriteLine("Book 2 subject: {0}", book2.subject);
        Console.WriteLine("Book 2 book_id: {0}", book2.book_id);

        Console.ReadKey();
    }   
}