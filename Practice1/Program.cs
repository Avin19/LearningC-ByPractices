namespace Practice1;

class Program
{
    static void Main(string[] args)
    {
        bool isRunning = true;
        while (isRunning)
        {   
            Console.WriteLine("Please enter your Age : ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age < 18)
            {
                Console.WriteLine("Hello Child");
            }
            else if (age >= 18 && age < 70)
            {
                Console.WriteLine("Hello Adult");
            }
            int remainingAge = 100 - age;
            Console.WriteLine("How many yearts until you turn 100  {0}", remainingAge);
            Console.WriteLine("Do you wish to run the application again  [y/n]");
            string check = Console.ReadLine();
            if(check == "Y" || check =="y")
            {
                isRunning =true;
            }
            else if( check == "N" || check=="n")
            {
                isRunning = false;
            }
            else
            {
                Console.WriteLine("Please enter your Response in [y/n]");
            }
        }
    }
}
