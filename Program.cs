using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace mission_16
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            int result = 0,counter=1;
            BigInteger number = 1;
            while (counter <= 1000)
            {
                number *= 2;
                counter++;
            }
            //Also we can use another way
            //BigInteger number = (BigInteger)Math.Pow(2, 1000);

            do
            {
                result += (char)(number % 10);
                number /= 10;
            } while (number > 0);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
