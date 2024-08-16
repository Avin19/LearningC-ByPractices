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
public class Book
{

    // Fields
    private string _title;
    private string _author;
    private bool _isAvailable;
    // Properties

    public string Title { get { return _title; } }
    public string Author { get { return _author; } }
    public bool IsAvailable { get { return _isAvailable; } }
    // Constructor

    public Book(string title, string author, bool isAvailable)
    {
        _title = title;
        _author = author;
        _isAvailable = isAvailable;
    }


}
