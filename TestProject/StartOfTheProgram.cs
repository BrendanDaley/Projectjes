﻿using System;

namespace TestProject
{
    class StartOfTheProgram
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Which app wohuld you like to use?: ");
            Console.WriteLine("1 for the The calculator");
            Console.WriteLine("69 to Exit the app");
            String tempAppChoice = Console.ReadLine();
            int appChoice = Convert.ToInt32(tempAppChoice);
;
            if (appChoice == 1)
            {
                Calculator calc = new Calculator();
                calc.Start();
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
