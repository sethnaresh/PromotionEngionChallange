using PromotionEngineChallange.Models;
using System;
using System.Linq;
using System.Collections.Generic;

namespace PromotionEngineChallange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Promotion Engine!");

            List<SkuOrder> skus = new List<SkuOrder>();
            Console.WriteLine("enter total number of types of products");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("enter the type of product:A,B,C or D");
                string type = Console.ReadLine();
                Console.WriteLine("enter the quantity of product:A,B,C or D");
                int no = Convert.ToInt32(Console.ReadLine());
                SkuOrder p = new SkuOrder(type);
                p.Quantity = no;
                skus.Add(p);
            }

            var items = new CartItems(skus).FinalPrice() ;
            Console.WriteLine("Final Price after applying Promotion = {0}", items.Sum(x => x.Price));
        }
    }
}
