// See https://aka.ms/new-console-template for more information


/*

 Design a Mini Library System
Task: Design a mini library system that includes classes for Book, Member, and Library. Implement borrowing and returning books, and ensure that members cannot borrow more books than allowed.
Requirements:
Create a Book class with properties like Title, Author, and IsAvailable.
Create a Member class with properties like Name, BorrowedBooks,and a 
method BorrowBook(Book book).
Create a Library class that manages the collection of books and members. 
Include methods like AddBook(Book book), RegisterMember(Member member),
 and BorrowBook(Member member, Book book).
Implement constraints so that members cannot borrow more than 5 books 
at a time and cannot borrow a book that is already borrowed.

*/
public class Member
{
    private string _name;
    public List<Book> _borrowedBook;

    public Member(string _name)
    {
        this._name = _name;
        _borrowedBook = new List<Book>();
    }

    public string Name { get { return _name; } }

    public void BorrowBook(Book book)
    {
        if (_borrowedBook.Capacity < 5)
        {
            _borrowedBook.Add(book);
        }
    }
    public void ReturnBook(Book book)
    {
        _borrowedBook.Remove(book);
    }
    public void DisplayBookBorrowed()
    {
        System.Console.WriteLine($" Name ; {_name}");
        foreach (Book book in _borrowedBook)
        {
            System.Console.WriteLine(book.Title);
        }
    }

}
