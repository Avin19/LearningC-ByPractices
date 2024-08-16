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
public class Library
{
    public List<Member> members = new List<Member>();
    public List<Book> booksInLibaray = new List<Book>();



    public void AddBook(Book book)
    {
        if (!booksInLibaray.Contains(book))
        {
            booksInLibaray.Add(book);
        }
    }
    public void RegisterMember(Member member)
    {
        if (!members.Contains(member))
        {
            members.Add(member);
        }
    }

    public void BorrowedBook(Member member, Book book)
    {
        if (!members.Contains(member))
        {
            RegisterMember(member);
        }
        else
        {
            if (booksInLibaray.Contains(book))
            {

                member.BorrowBook(book);
                booksInLibaray.Remove(book);
            }

        }
    }

}