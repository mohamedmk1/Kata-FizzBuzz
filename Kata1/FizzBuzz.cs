using System;
using System.Collections.Generic;
using System.Text;

namespace Kata1
{
    public class FizzBuzz
    {
        public string GetNumber(int startFrom)
        {
            if(startFrom % 3 == 0 && startFrom %5 == 0)
            {
                return "fizzbuzz";
            }
            if(startFrom % 3 == 0)
            {
                return "fizz";
            }
            if(startFrom % 5 == 0)
            {
                return "buzz";
            }
            return startFrom.ToString();
        }
    }
}
