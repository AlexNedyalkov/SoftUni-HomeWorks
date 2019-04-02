using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogIn
{
    class Program
    {
        static void Main(string[] args)
        {
            string login = Console.ReadLine();
            
            
            int counter = 0;
            while (true)
            {
                string passowrd_input = Console.ReadLine();

                if (passowrd_input == password)
                {
                    Console.WriteLine($"User {login} logged in.");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                    counter++;
                    if (counter == 0)
                    {
                        break;
                    }
                }
        }
    }
}
