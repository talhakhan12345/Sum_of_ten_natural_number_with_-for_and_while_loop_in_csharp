using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Practice_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
       Console.WriteLine("Display Sum of 10 Natural number with while and for loop ");
          

            Console.WriteLine("For loop");
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
                sum = sum + i;
                // 0 = 0 + 1; //
                // 1 = 1 + 2; //

            }

            Console.WriteLine("The sum of Ten Natural Numbers " + sum);

            Console.WriteLine("-------");
            Console.WriteLine("While Loop");

           int sum1 = 0;
            int a = 1;
            while (a<=10) {
                Console.WriteLine(a);
                sum1 = sum1 + a;
                a++;
             
            }

            Console.WriteLine("The sum of Ten Natural Numbers " + sum1);
            Console.ReadKey();
        }
    }
}
