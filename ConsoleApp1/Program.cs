using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int digit;
            int number_initial = int.Parse(Console.ReadLine());
            int number = number_initial;
            int total_sum = 0;
            while (true)
            {
                
                int sum = 1;
                digit = number % 10;
                for (int i = 1; i <= digit; i++)
                {
                    sum = sum * i; 
                }
                total_sum = total_sum + sum;
                
                number = number /10;
                if (number == 0)
                {
                    break;
                }
            }
            if (total_sum == number_initial)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
