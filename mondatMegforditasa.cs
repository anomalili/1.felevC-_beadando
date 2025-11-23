internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ez a program megfordítja a megadott mondatot!");

        Console.WriteLine("Adj meg egy mondatot!");
        string mondat = Console.ReadLine();

        char[] karakterek = mondat.ToCharArray();
        Array.Reverse(karakterek);

        string forditott = new string(karakterek);

        Console.WriteLine("Megfordítva: " + forditott);

    }
}