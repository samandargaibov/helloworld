using System;

namespace ders2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1ci ededi daxil edin:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("2ci ededi daxil edin: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a < b || a==b)
            {
                int c = a + b;
                Console.WriteLine($"Cemi: {a}+{b}={c}");
            }
            else if (a == b)
            {
                int c = a * b;
                Console.WriteLine($"Hasil: {a}*{b}={c}");
            }
            else
            {
                int c = a - b;
                Console.WriteLine($"Ferq: {a}-{b}={c}");
            }
            

            
        }
    }
}
