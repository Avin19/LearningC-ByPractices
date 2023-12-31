namespace Practice2;

class Program
{
    static void Main(string[] args)
    {
       Welcome();
       PurchseItem();

    }
    static void Welcome()
    {
        System.Console.WriteLine(" Welcome to the store ! Here the list of item :");
        System.Console.WriteLine("BOok");
        System.Console.WriteLine("Clothing");
        System.Console.WriteLine("Computers");
        System.Console.WriteLine("What would like to you buy?");

    }
    static void PurchseItem()
    {
        string itemName = Console.ReadLine();
        switch (itemName)
        {
            case "book":
                Book book = new Book();
                book.Author = " Avinash Author";
                book.Title = " Coding Practices";
                book.Price =9.99;
                System.Console.WriteLine($" You purchase a {book.Title}"+ $"{book.Author} for {book.Price}");
                break;
            case "clothing":
                Shirt cloth = new Shirt();
                cloth.Title = " Blue Shirt";
                cloth.Price = 10.00;
                cloth.Size = "XXL";
                System.Console.WriteLine($" You purchase a {cloth.Title} " + $" {cloth.Size} for { cloth.Price}");
                break;
            case "Computers":
                Computer computer   = new Computer();
                computer.Title = " Windows Computer";
                computer.Price = 200.00;
                computer.Type = " Gaming Computer";
                System.Console.WriteLine($"You Purchse a {computer.Title}" + $" {computer.Type} for {computer.Price}");
                break;
            default:
                break;
        }
    }
    public class BaseITem
    {
        public string Title {get; set;}
        public double Price { get;set;}
        
    }
    public class Book :BaseITem
    {
        public string Author { get; set;}

    }
    public class Shirt : BaseITem{
        public string Size{ get; set;}
    }
    public class Computer: BaseITem
    {
        public string Type { get; set;}
    }
    
}
