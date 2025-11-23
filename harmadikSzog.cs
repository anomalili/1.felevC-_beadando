using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cSzog;
            
            Console.WriteLine("Ez a program kiszámolja a képzeletbeli háromszögünk harmadik szögét, miután megadtuk az első két szögét!");
            Console.WriteLine("Adja meg az 'A' szög értékét!");
            int aSzog = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adja meg az 'B' szög értékét!");
            int bSzog = Convert.ToInt32(Console.ReadLine());

            cSzog = 180 - (bSzog + aSzog);

            Console.WriteLine("A háromszög harmadik szögének értéke " + cSzog);

        }
    }
}