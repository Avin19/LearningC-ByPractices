// See https://aka.ms/new-console-template for more information

/*

 Design a Mini Library System
Task: Design a mini library system that includes classes for Book, Member, and Library. Implement borrowing and returning books, and ensure that members cannot borrow more books than allowed.
Requirements:
Create a Book class with properties like Title, Author, and IsAvailable.
Create a Member class with properties like Name, BorrowedBooks,and a method BorrowBook(Book book).
Create a Library class that manages the collection of books and members. 
Include methods like AddBook(Book book), RegisterMember(Member member),
 and BorrowBook(Member member, Book book).
Implement constraints so that members cannot borrow more than 5 books 
at a time and cannot borrow a book that is already borrowed.

*/


public class Program
{
    public static void Main()
    {
        Library library = new Library();

        Book b1 = new Book("Book 1 ", " Avinash ", true);
        Book b2 = new Book("Book 2", " Yadav ", true);

        library.booksInLibaray.Add(b1);
        library.booksInLibaray.Add(b2);

        Member m1 = new Member("Avinash");
        Member m2 = new Member("Welcome");

        m1.BorrowBook(b1);
        m1.DisplayBookBorrowed();

        m2.BorrowBook(b2);
        m2.DisplayBookBorrowed();


    }
}