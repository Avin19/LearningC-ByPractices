
public class Customer
{
    public string Name;
    public int Id;
    public List<Order> orders;
    public Person customer;
    public Customer()
    {
        orders = new List<Order>();
        customer = new Person();
        customer.Introduce("Avinash", 1992);
    }
    public Customer(string name, int id) : this()
    {
        this.Name = name;
        this.Id = id;


    }
}