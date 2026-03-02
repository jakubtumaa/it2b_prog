class Program                            
{
    static void Main()
    {
        double a, b;
        Console.WriteLine("Zadej cislo: ");
        a = double.Parse(Console.ReadLine());

        Console.WriteLine("Zadej druhe cislo: ");
        b = double.Parse(Console.ReadLine());

        Console.WriteLine($"Soucet cisel je {a + b}");
    }
}