using System;

namespace pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("pokemon Name:");
            string Name = Console.ReadLine();
            Console.Write("pokemon Height:");
            string Height = Console.ReadLine();
            Console.Write("pokemon Weight:");
            string Weight= Console.ReadLine();
            Console.Write("pokemon Category:");
            string Category = Console.ReadLine();
            Console.WriteLine("your pokemon data:Name:{0}Height:{1}Weight:{2}Category:{3}",Name,Height,Weight,Category);
        }
    }

}
