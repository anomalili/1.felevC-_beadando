internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ez a program bekéri egy számtani sorozat első elemét és differenciáját és kiírja a sorozat első 10 elemét.");

        Console.WriteLine("Adja meg az első tagját a számtani soroztatnak!");
        int elsoTag = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Adja meg differencia értéket!");
        int differencial = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(elsoTag+(i*differencial));
        }
    }
}