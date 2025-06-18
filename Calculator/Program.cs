using System.ComponentModel.Design;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter first number");
            double firstNum = double.Parse(Console.ReadLine());

            Console.WriteLine("Please, enter second number");
            double secondNum = double.Parse(Console.ReadLine());

            Console.WriteLine("Please, enter one math operation");
            char mathOperation = char.Parse(Console.ReadLine());
            double result = 0;

            //if (mathOperation == '+')
            //{
            //    result = firstNum + secondNum;
            //}
            //else if (mathOperation == '-')
            //{
            //    result = firstNum - secondNum;
            //}
            //else if (mathOperation == '*')
            //{
            //    result = firstNum * secondNum;
            //}
            //else if (mathOperation == '/')
            //{
            //    if (secondNum == 0)
            //    {
            //        Console.WriteLine("You can not divide by 0");
            //    }
            //    result = firstNum / secondNum;
            //}
            //else
            //{
            //    Console.WriteLine("You entered incorrect math operation!");
            //}
            switch (mathOperation)
            {
                case '+':
                    result = firstNum + secondNum;
                    break;
                case '-':
                    result = firstNum - secondNum;
                    break;
                case '*':
                    result = firstNum * secondNum;
                    break;
                case '/':
                    {
                        if (secondNum == 0)
                        {
                            Console.WriteLine("You can not divide by 0");
                        }
                        result = firstNum / secondNum;
                        break;
                    }
                default:
                    Console.WriteLine("You entered incorrect math operation!");
                    break;
                case '%':
                    result = (secondNum / 100.0) * firstNum;
                    Console.WriteLine($"{secondNum / 100.0}% from {firstNum}={result}");
                    break;
            }

            bool ismathOperationisCorrect = mathOperation == '+' || mathOperation == '-' || mathOperation == '*' || mathOperation == '/';
            if (result != double.PositiveInfinity && ismathOperationisCorrect)
            {
                Console.WriteLine($"{firstNum} {mathOperation} {secondNum} = {result}");

            }
            else
            {
                Console.WriteLine("Something went wrong!");
            }
        }          

       }


    }

