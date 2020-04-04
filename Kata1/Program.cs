using System;

namespace Kata1
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz fb = new FizzBuzz();

            int max = 1000;
            int startFrom = 4;
            int currentNumber = startFrom;

            while(currentNumber < max)
            {
                string result = fb.GetNumber(currentNumber);
                Console.WriteLine(result);
                currentNumber++;
            }
            
        }
    }
}
