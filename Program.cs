using System;

namespace Calculator
{
     class Program
    {
        static void Main(string[] args)
        {
            // set variables to insert numbers to be calculated
            int num1;
           
            int num2;
            
            int result;
            
            string answer;

            Console.WriteLine("Hello, welcome to the calculator program!");

            Console.WriteLine("Please enter your first number!");
            
            // convert the input from string to int
            num1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Please enter your second number! ");
            
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("what type of operation would you like to do?");
            
            Console.WriteLine("Please enter a for addition, s for subtraction, m for multiplication, and d for dividion.");

            answer = Console.ReadLine();    
        
            if (answer == "a")
            {
                result = num1 + num2;
            }
            else if (answer == "s")
            {
                result = num1 - num2;
            }    
            else if (answer == "m")
            {
                result = num1 * num2;
            }
            else  
            {
                result = num1 / num2;
            }
             
            Console.WriteLine("The result is " + result);

            Console.WriteLine("Thank you for using the calculator program!");
        }
    }
}