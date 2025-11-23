using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float yen = 2.13f;
            float usd = 333.44f;
            float gbp = 436.25f;
            float eur = 383.44f;
            float chf = 411.96f;
            float szorzo = 0f;
            string penznem = "" ;
            Boolean ervenyes = false;

            Console.WriteLine("Adjon meg egy pénznemet és az összegét és átváltom forintba!");

            while (!ervenyes)
            {
                Console.WriteLine("Adja meg a pénznemet!\n" + "Választható pénznemek: YEN, USD, GPD, EUR, CHF ");
                penznem = Console.ReadLine();

                penznem = penznem.ToUpper();
                //így akármilyen kapitálissal adjuk meg a pénznemet működni fog


                if (penznem == "YEN")
                {
                    penznem = "YEN";
                    szorzo = yen;
                    ervenyes = true;
                }
                else if (penznem == "USD")
                {
                    penznem = "USD";
                    szorzo = usd;
                    ervenyes = true;
                }
                else if (penznem == "GBP")
                {
                    penznem = "GBP";
                    szorzo = gbp;
                    ervenyes = true;
                }
                else if (penznem == "EUR")
                {
                    penznem = "EUR";
                    szorzo = eur;
                    ervenyes = true;
                }
                else if (penznem == "CHF")
                {
                    penznem = "CHF";
                    szorzo = chf;
                    ervenyes = true;
                }


                else { Console.WriteLine("Érvénytelen pénznemet adtál meg, add meg újra!"); }
            }

            Console.WriteLine("Adja meg az összeget!");
            float osszeg = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Az általad megadott " + osszeg + " " + penznem +
                  " Forintba átváltva = " + (osszeg * szorzo).ToString("0.00") + " Ft");



        }


    }
    }
