using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3_systemtestning
{
    public class Calculator
    {
        public int num1 { get; set; }
        public int num2 { get; set; }
        public int result { get; set; }
        public List<string> calculations { get; set; }


        public void userMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose calculation method:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Division");
            Console.WriteLine("4. Multiplication");
            Console.WriteLine("5. Print calculations and results");
            Console.WriteLine("6. Exit application");
           

            try
            {
                int selection = Int32.Parse(Console.ReadLine());
                switch (selection)
                {
                    case 1:
                        addition(num1, num2);
                        break;
                    case 2:
                        subtraction(num1, num2);
                        break;
                    case 3:
                        division(num1, num2);
                        break;
                    case 4:
                        multiplication(num1, num2);
                        break;
                    case 5:
                        printResult();
                        break;
                    case 6:
                        Console.WriteLine("The program will now exit...");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;
                    default: Console.WriteLine("Invalid number!");
                        Console.ReadKey();
                        userMenu();
                        break;
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Please select a valid menu choice!");
                Console.ReadKey();
                userMenu();
            }
        }

        public int firstUserInput()
        {
            try
            {
                //Console.WriteLine("Enter the first number:");
                //*** User input disabled for testing purposes ****
                //num1 = int.Parse(Console.ReadLine());
                num1 = 5;
            }
            catch (Exception)
            {
                Console.WriteLine("Enter a number!");
                Console.ReadKey();
                firstUserInput();
            }
            return num1;

        }

        public int secondUserInput()
        {
            try
            {
                Console.WriteLine("Enter the second number:");
                num2 = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Enter a number!");
                Console.ReadKey();
                firstUserInput();
            }
            return num2;
        }



        public int addition(int num1, int num2)
        {
            //firstUserInput();
            //secondUserInput();
            result = num1 + num2;
            string calc = "Calculation: " + num1.ToString() + " + " + num2.ToString() + " = " + result.ToString();
            calculations.Add(calc);
            //userMenu();
            return result;
        }

        public int subtraction(int num1, int num2)
        {
            //firstUserInput();
            //secondUserInput();
            result = num1 - num2;
            string calc = "Calculation: " + num1.ToString() + " - " + num2.ToString() + " = " + result.ToString();
            calculations.Add(calc);
            //userMenu();
            return result;
        }

        public int division(int num1, int num2)
        {
            //firstUserInput();
            //secondUserInput();
            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException emsg)
            {
                Console.WriteLine(emsg.Message);
                throw;
            }
            string calc = "Calculation: " + num1.ToString() + " / " + num2.ToString() + " = " + result.ToString();
            calculations.Add(calc);
            userMenu();
            return result;
        }
        public int multiplication(int num1, int num2)
        {
            //firstUserInput()
            //secondUserInput();
            result = num1 * num2;
            string calc = "Calculation: " + num1.ToString() + " * " + num2.ToString() + " = " + result.ToString();
            calculations.Add(calc);
            //userMenu();
            return result;
        }

        public void printResult()
        {
            foreach (var calculation in calculations)
            {
                Console.WriteLine(calculation);
            }
            Console.ReadKey();
            userMenu(); 
        }
    }
}
