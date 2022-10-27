using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Price
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько товара?");
            int tovar = int.Parse(Console.ReadLine());
            Price[] arrayOfPrices=new Price[tovar];
            for (int i = 0; i < tovar; i++)
            {
                Console.WriteLine($"Товар номер {i+1}");

                Console.Write("Название товара:");
                string name = Console.ReadLine();
                Console.Write("Название магазина, где товар:");
                string shop= Console.ReadLine();
                Console.Write("Цена:");
                int cost = int.Parse(Console.ReadLine());

                Price price = new Price(name, shop, cost);
                arrayOfPrices[i] = price;
            }

            while (true)
            {
                Console.Write("Магазин, где искать:");
                string s = Console.ReadLine();
                if(string.IsNullOrEmpty(s))
                    break;

                bool flag = false;
                foreach (var price in arrayOfPrices)
                {
                    if (s == price.Shop)
                    {
                        flag = true;
                        Console.WriteLine(price.ToString());
                    }
                }
                if(flag==false)
                    Console.WriteLine("Товар раскупили, не расстраивайтесь ");
            }

        }
    }
}
