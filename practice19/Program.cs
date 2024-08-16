// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
Create an abstract class Payment with an abstract method ProcessPayment(). 
Then create two derived classes CreditCardPayment and PayPalPayment that implement this method.
Additionally, define an interface IRefundable with a method ProcessRefund() 
and implement it in CreditCardPayment class.
Demonstrate the use of both abstraction and interfaces.
*/

public abstract class Payment
{
    public abstract void ProcessPayment();


}


public class CreditCardPayment : Payment, IRefundable
{
    public override void ProcessPayment()
    {
        throw new NotImplementedException();
    }
    public void ProcessRefund()
    {

    }

}

public class PayPalPayment : Payment, IRefundable
{
    public override void ProcessPayment()
    {
        throw new NotImplementedException();
    }

    public void ProcessRefund()
    {
        throw new NotImplementedException();
    }
}

public interface IRefundable
{
    public void ProcessRefund();



}