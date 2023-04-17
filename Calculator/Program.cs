using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the operation (example: 5 - 2)");
        Label:
            string[] num = Console.ReadLine().Split(' ');
            if (num.Length == 3)
            {
                double number1, number2, operationResult;
                number1 = int.Parse(num[0]);
                number2 = int.Parse(num[2]);
                if (num[1].Equals("+"))
                {
                    operationResult = number1 + number2;
                    Console.WriteLine(operationResult);
                }
                else if (num[1].Equals("-"))
                {
                    operationResult = number1 - number2;
                    Console.WriteLine(operationResult);
                }
                else if (num[1].Equals("*"))
                {
                    operationResult = number1 * number2;
                    Console.WriteLine(operationResult);
                }
                else if (num[1].Equals("/") || num[2].Equals("\""))
                {
                    if (number2 == 0)
                    {
                        Console.WriteLine("Zero divide");
                    }
                    else
                    {
                        operationResult = number1 / number2;
                        Console.WriteLine(operationResult);
                    }
                }
                Console.WriteLine("Yay, it works!");
                Console.Read();
            }
            else
            {
                Console.WriteLine("Please, enter all numbers");
                goto Label;
            }
        }
    }
}
