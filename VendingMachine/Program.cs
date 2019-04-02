using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            double total_coins = 0;
            string product;
            double Nuts = 2.0;
            double Water = 0.7;
            double Crisps = 1.5;
            double Soda = 0.8;
            double Coke = 1.0;
            double Cost;

            while (true)
            {
                string coins_string = Console.ReadLine();
                if (coins_string =="Start")
                {
                    break;
                }
                double coins = double.Parse(coins_string);
                if (coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1 || coins == 2)
                {
                    total_coins = total_coins + coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                    continue;
                }
                
            }
            while (true)
            {
                product = Console.ReadLine();
                if (product == "End")
                {
                    Console.WriteLine($"Change: {total_coins:N2}");
                    break;
                }
                else if (product == "Nuts" || product == "Water" || product == "Soda" || product == "Coke" || product =="Crisps" )
                {
                    if (product == "Nuts")
                    {
                        Cost = Nuts;
                        if (total_coins >= Cost)
                        {
                            Console.WriteLine($"Purchased nuts");
                            total_coins = total_coins - Cost;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                    }
                    else if (product == "Water")
                    {
                        Cost = Water;
                        if (total_coins >= Cost)
                        {
                            Console.WriteLine($"Purchased water");
                            total_coins = total_coins - Cost;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                    }
                    else if (product == "Soda")
                    {
                        Cost = Soda;
                        if (total_coins >= Cost)
                        {
                            Console.WriteLine($"Purchased soda");
                            total_coins = total_coins - Cost;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                    }
                    else if (product == "Coke")
                    {
                        Cost = Coke;
                        if (total_coins >= Cost)
                        {
                            Console.WriteLine($"Purchased coke");
                            total_coins = total_coins - Cost;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                    }
                    else if (product == "Crisps")
                    {
                        Cost = Crisps;
                        if (total_coins >= Cost)
                        {
                            Console.WriteLine($"Purchased crisps");
                            total_coins = total_coins - Cost;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                    }
                  
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
            }
        }
    }
}
