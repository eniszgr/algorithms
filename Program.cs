using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace euler20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 100;
            long sumofdigits = 0;
            BigInteger sum = 1;
            //find factorial
            for (int i = num; i >= 1; i--)
            {
                sum = sum * i;
            }
            
            //data type conversion
            string number = sum.ToString();
            
            //access each number
            foreach (char c in number)
            {
                sumofdigits += (int)char.GetNumericValue(c);
            }
            Console.WriteLine("equals = " + sumofdigits);
            Console.ReadLine();
        }
       
    }
}
