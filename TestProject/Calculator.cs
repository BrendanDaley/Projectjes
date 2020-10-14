using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject
{
    class Calculator
    {

        public void Start()
        {
          
            calculatorApp();

        }

        public void calculate(int choice, int number1, int number2)
        {
            int solution = 0;

            if (choice == 1)
            {
                solution = number1 + number2;
            }
            else if (choice == 2)
            {
                solution = number1 - number2;
            }
            else if (choice == 3)
            {
                solution = number1 * number2;
            }
            else if (choice == 4)
            {
                solution = number1 / number2;
            }


            Console.WriteLine("Here is the solution BooBoo: " + solution);
        }

        public void calculatorApp()
        {
            String yesOrNo = "";
            Console.WriteLine("Welcome to the calculator App");
            do
            {
                Console.WriteLine(@"
        Would you like to:
        1. Add 
        2. Subtract 
        3. Multiply
        4. Devide
        Put in a number to start.");

                String choiseUser = Console.ReadLine();
                Console.WriteLine("What is the first number: ");
                String input1 = Console.ReadLine();
                Console.WriteLine("What is the second number: ");
                String input2 = Console.ReadLine();

                int number1 = Convert.ToInt32(input1);
                int number2 = Convert.ToInt32(input2);
                int choice = Convert.ToInt32(choiseUser);

                calculate(choice, number1, number2);

                Console.WriteLine("Would you like to Calcualte some more stuff? Y/N");
                yesOrNo = Console.ReadLine();
            } while (yesOrNo == "Y");
            
            if (yesOrNo == "N")
            {
                Console.WriteLine("Goodbye <3");
                System.Threading.Thread.Sleep(1000);
                System.Environment.Exit(1);
            }
        }


       


    }
}
