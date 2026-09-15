class Program
{
    static void Main()
    {
        float cena;
        float osoby;

        try
        {
            Console.WriteLine("Nacti cenu listku: ");
            cena = int.Parse(Console.ReadLine());

            Console.WriteLine("Nacti pocet osob: ");
            osoby = int.Parse(Console.ReadLine());

            Console.WriteLine($"Kazda osoba zaplatila {cena / osoby:F2} Kc.");
        } catch (FormatException)
        {
            Console.WriteLine("Musis zadat cislo!");
        }
    }
}