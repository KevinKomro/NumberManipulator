using System;

namespace NumberManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            string response = Console.ReadLine();
            double numResponse = Int32.Parse(response);
            numResponse = (Math.Pow(numResponse,2) + 14 -3);
            Console.WriteLine(numResponse);
        }
    }
}
