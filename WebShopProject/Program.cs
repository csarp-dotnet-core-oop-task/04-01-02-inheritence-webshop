using System;

using WebShopProjekt.Models;

namespace WebShopProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Food food = new Food("tej", 459, 0.055, "liter", 4);
            Console.WriteLine(food.ToString());
            Console.WriteLine(food.Item);
        }
    }
}
