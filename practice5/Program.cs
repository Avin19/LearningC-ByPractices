public class Program
{
    public static void Main(string[] args)
    {
        Customer c = new Customer();
        Order order = new Order();
        c.orders.Add(order);
    }
}
