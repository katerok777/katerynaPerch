using System;

namespace _4_13_zlatopolskiy
{
    class Program
    {
        static void Main(string[] args)
        {
            //златопольський №4.13
            Console.Write("Введiть a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введiть b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введiть c: ");
            int c = Convert.ToInt32(Console.ReadLine());

            int D = b * b - 4 * a * c;
            if (D > 0)
                Console.WriteLine("Рiвняння має два дiйсних коренi.");
            else if (D == 0)
                Console.WriteLine("Рiвняння має один розв'язок (два однаковi дiйсних коренi).");
            else
                Console.WriteLine("Рiвняння не має дiйсних коренiв.");

            Console.ReadKey();
        }
    }
}
