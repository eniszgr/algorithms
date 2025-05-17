// At the end of the job we have to go to 20 times down and 20 times right
//so,we can use combination
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Data.SqlTypes;

namespace mission_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //C(40,20) ==> ∀(a>b)->C(a,b)= a!/(b!(a-b)!)   
            BigInteger numerator = 1, denominator=1, result;

            for (int i = 1; i <= 40; i++) // a!
            {
                numerator *= i;
            }
            for (int i = 1; i <= 20; i++) //b!
            {
                denominator *= i;
            }
            for (int i = 1; i <= 20; i++) //(a-b)!
            {
                denominator*= i;
            }
            result= numerator / denominator;
            Console.WriteLine(result);
            Console.ReadLine();   
        }
    }
    
}
