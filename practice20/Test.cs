// See https://aka.ms/new-console-template for more information
// counter1.ThresholdReached += 



public class Test
{
    private Counter counter1;

    public void Test12()
    {
        counter1 = new Counter();
        counter1.ThresholdReached += Test23();
    }

    public Counter.ThresholdReachedEventHandler Test23()
    {
        System.Console.WriteLine("Test Coming ");
    }
}