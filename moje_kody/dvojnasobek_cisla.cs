class Program                  //Dvojnásobek zadaného čísla
{
    static void Main()
    {
        Console.WriteLine("Zadej cislo: ");
        int cislo = int.Parse(Console.ReadLine());

        Console.WriteLine($"Dvojnasobek je: {2 * cislo}");
    }
}