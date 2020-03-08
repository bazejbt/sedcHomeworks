using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Two Numbers");
            string userInput = Console.ReadLine();
            int firstNum = int.Parse(userInput);
            string userSecondInput = Console.ReadLine();
            int secondNum = int.Parse(userSecondInput);

            int tempFirstNumber = firstNum;

            firstNum = secondNum;
            secondNum = tempFirstNumber;


            Console.WriteLine(firstNum);
            Console.WriteLine(secondNum);


            Console.ReadLine();
        }
    }
}
