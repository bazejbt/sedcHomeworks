using System;

namespace domasna_1
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Please Two Numbers And A Charecter");
            string userInput = Console.ReadLine();
            int firstNum = int.Parse(userInput);
            string userSecondInput = Console.ReadLine();
            int secondNum = int.Parse(userSecondInput);
            string userThirdInput = Console.ReadLine();
            string charNum = userThirdInput;

            int result = 0;

            switch (charNum)
            {
                case "+":
                    result = firstNum + secondNum;
                    break;
                case "-":
                    result = firstNum - secondNum;
                    break;
                case "*":
                    result = firstNum * secondNum;
                    break;
                case "/":
                    result = firstNum / secondNum;
                    break;
                default:

                    Console.WriteLine("Invalid Character");
                    break;
            }

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
