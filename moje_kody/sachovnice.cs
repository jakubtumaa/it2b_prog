class Program              //3*3 šachovnice
{
    static void Main()
    {
        Console.WriteLine("Zadej prvni znak: ");
        char znak1 = char.Parse(Console.ReadLine());

        Console.WriteLine("Zadej druhy znak: ");
        char znak2 = char.Parse(Console.ReadLine());

        Console.WriteLine($"{znak1} {znak2} {znak1}");
        Console.WriteLine($"{znak2} {znak1} {znak2}");
        Console.WriteLine($"{znak1} {znak2} {znak1}");
    }
}