using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string evszak = "";
            bool ervenyes = false;


            Console.WriteLine("Ez a program megmondja, hogy egy adott hónap milyen évszakban van!");
        
            
            
            
            

            while (!ervenyes)
            {
                Console.WriteLine("Kérlek add meg a hónap nevét!");


                string honap = Console.ReadLine();
                honap = honap.ToLower();
                //így akármilyen kapitálissal adjuk meg a hónapot működni fog


                if (honap == "december" | honap == "január" | honap == "február")
                {
                    evszak = "Tél";
                    ervenyes = true;
                }
                else if (honap == "március" | honap == "április" | honap == "május")
                {
                    evszak = "Tavasz";
                    ervenyes = true;
                }
                else if (honap == "június" | honap == "július" | honap == "augusztus")
                {
                    evszak = "Nyár";
                    ervenyes = true;
                }
                else if (honap == "szeptember" | honap == "október" | honap == "november")
                {
                    evszak = "Ősz";
                    ervenyes = true;
                }


                else { Console.WriteLine("Rosszul adtad meg a hónapot, add merg újra!");}
            }


                Console.WriteLine("Az általad megadott hónap ehhez az évszakhoz tartozik: " + evszak);



            
        }
    }
}