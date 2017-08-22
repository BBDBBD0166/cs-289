using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemon2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("神奇寶貝名稱:");
            string Name = Console.ReadLine();
            Console.Write("神奇寶貝身高:");
            string Height = Console.ReadLine();
            Console.Write("神奇寶貝體重:");
            string Weight = Console.ReadLine();
            Console.Write("神奇寶貝屬性:");
            string Category = Console.ReadLine();
            Console.WriteLine("恭喜你獲得了:{0}__你的神奇寶貝已登錄圖鑑:身高{1}__體重:{2}__屬性:{3}", Name,Height,Weight,Category);
        }
    }
}
