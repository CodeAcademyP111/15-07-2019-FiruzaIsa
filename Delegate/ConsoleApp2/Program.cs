using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb;
            Console.WriteLine($"Enter a number:");
            numb =Convert.ToInt32(Console.ReadLine());
            Action<int> check = CheckIntegers;
            check += CheckPrime;
            check += CheckParity;
            check(numb);


        }
         static void CheckIntegers(int a)
        {
            if (a < 0)
            {
                Console.WriteLine($"This {a} is the negative number");
            }
            else
            {
                Console.WriteLine($"This {a} is the positive number");
            }
        }
        static void CheckPrime(int a)
        {

            for (int i = 2; i < a; i++)

            {

                if(a % i == 0)
                {
                    Console.WriteLine($"This {a} is not the prime number");
                }
                else
                {
                    Console.WriteLine($"This {a} is the prime number");
                }
                return;
            }

        }
        static void CheckParity(int a)
        {
            if (a % 2 == 0)
            {
                Console.WriteLine($"This {a} is the even number");

            }
            else
            {
                Console.WriteLine($"This {a} is the odd number");

            }
        }
    }
}
