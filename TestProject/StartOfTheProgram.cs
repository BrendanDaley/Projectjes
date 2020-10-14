using System;

namespace TestProject
{
    class StartOfTheProgram
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Which app wohuld you like to use?: ");
            Console.WriteLine("1 to Exit the app");
            Console.WriteLine("2 for the The calculator");
            String tempAppChoice = Console.ReadLine();
            int appChoice = Convert.ToInt32(tempAppChoice);
;
            if (appChoice == 1)
            {
                Calculator calc1 = new Calculator();
                calc1.Start();
            }
            else if (appChoice == 2)
            {
                
            }
            else if (appChoice == 69)
            {
                Console.WriteLine("Goodbye <3");
                System.Threading.Thread.Sleep(1000);
                System.Environment.Exit(1);

            };
        }
       
    }
}
