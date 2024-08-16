// See https://aka.ms/new-console-template for more information
/*
Define a delegate ThresholdReachedEventHandler and an 
event ThresholdReached in a class Counter. 
The Counter class should increment a counter and
 trigger the event when the counter reaches a certain threshold. 
 Write a program that subscribes to this event and handles
  it when it is triggered.
*/

public class Counter
{
    public delegate void ThresholdReachedEventHandler();
    public event ThresholdReachedEventHandler ThresholdReached;

    private const int maxCount = 100;

    public Counter()
    {
        for (int i = 0; i < maxCount; i++)
        {
            System.Console.WriteLine($"");
            if (i == maxCount - 1)
            {
                ThresholdReached?.Invoke();
            }
        }
    }

}
