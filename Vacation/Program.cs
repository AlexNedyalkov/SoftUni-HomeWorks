using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int People = int.Parse(Console.ReadLine());
            string Type = Console.ReadLine();
            string Day = Console.ReadLine();
            double price;
            double total_price;
            if (Day == "Friday")
            {
                if (Type == "Students")
                {
                    price = 8.45;
                    if (People >= 30)
                    {
                        total_price = People * price * 0.85;
                        Console.WriteLine($"Total price: {total_price:N2}");
                    }
                    else
                    {
                        total_price = People * price;
                        Console.WriteLine($"Total price: {total_price:N2}");
                    }
                   
                }
                else if (Type == "Business")
                {
                    price = 10.90;

                    if (People >= 100)
                    {
                        total_price = (People - 10) * price;
                        Console.WriteLine($"Total price: {total_price:N2}");
                    }
                    else
                    {
                        total_price = People * price;
                        Console.WriteLine($"Total price: {total_price:N2}");
                    }
                        
                    
                }
                else if (Type == "Regular")
                {
                    price = 15;

                    if (People >= 10 && People <= 20)
                    {
                        total_price = People * price * 0.95;
                        Console.WriteLine($"Total price: {total_price:N2}");
                    }
                    else
                    {
                        total_price = People * price;
                        Console.WriteLine($"Total price: {total_price:N2}");
                    }
                }
            }
            else if (Day == "Saturday")
            {
                if (Type == "Students")
                {
                    price = 9.80;
                    if (People >= 30)
                    {
                        total_price = People * price * 0.85;
                        Console.WriteLine($"Total price: {total_price:N2}");
                    }
                    else
                    {
                        total_price = People * price;
                        Console.WriteLine($"Total price: {total_price:N2}");
                    }

                   

                }
                else if (Type == "Business")
                {
                    price = 15.60;
                    if (People >= 100)
                    {
                        total_price = (People - 10) * price;
                        Console.WriteLine($"Total price: {total_price:N2}");
                    }
                    else
                    {
                        total_price = People * price;
                        Console.WriteLine($"Total price: {total_price:N2}");
                    }
                }
                else if (Type == "Regular")
                {
                    price = 20;
                    if (People >= 10 && People <= 20)
                    {
                        total_price = People * price * 0.95;
                        Console.WriteLine($"Total price: {total_price:N2}");
                    }
                    else
                    {
                        total_price = People * price;
                        Console.WriteLine($"Total price: {total_price:N2}");
                    }
                }
            }
            else if (Day == "Sunday")
            {
                if (Type == "Students")
                {
                    price = 10.46;
                    if (People >= 30)
                    {
                        total_price = People * price * 0.85;
                        Console.WriteLine($"Total price: {total_price:N2}");
                    }
                    else
                    {
                        total_price = People * price;
                        Console.WriteLine($"Total price: {total_price:N2}");
                    }

                    
                }
                else if (Type == "Business")
                {
                    price = 16;
                    if (People >= 100)
                    {
                        total_price = (People - 10) * price;
                        Console.WriteLine($"Total price: {total_price:N2}");
                    }
                    else
                    {
                        total_price = People * price;
                        Console.WriteLine($"Total price: {total_price:N2}");
                    }
                }
                else if (Type == "Regular")
                {
                    price = 22.50;
                    if (People >= 10 && People <= 20)
                    {
                        total_price = People * price * 0.95;
                        Console.WriteLine($"Total price: {total_price:N2}");
                    }
                    else
                    {
                        total_price = People * price;
                        Console.WriteLine($"Total price: {total_price:N2}");
                    }
                }
            }
            

        }
    }
}
