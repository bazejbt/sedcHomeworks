using System;

namespace domasna_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Four Numbers");
            string userInput = Console.ReadLine();
            int firstNum = int.Parse(userInput);
            string userSecondInput = Console.ReadLine();
            int secondNum = int.Parse(userSecondInput);
            string userThirdInput = Console.ReadLine();
            int thirdNum = int.Parse(userThirdInput);
            string userForthInput = Console.ReadLine();
            int forthNum = int.Parse(userForthInput);



            int result = (firstNum + secondNum + thirdNum + forthNum) / 4;




            Console.WriteLine(result);


            Console.ReadLine();
        }
    }
}
