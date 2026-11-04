class Bojovnik
{
    public void Utok()
    {
        Console.WriteLine("Bojovnik utoci");
    }

    public void Utok(int sila)
    {
        Console.WriteLine($"Bojovnik utoci silou {sila}");
    }

    public void Utok(string zbran)
    {
        Console.WriteLine($"Bojovnik utoci pomoci {zbran}");
    }

    public void Utok(int sila,  string zbran)
    {
        Console.WriteLine($"Bojovnik utoci pomoci {zbran} silou {sila}");
    }
}

class Program
{
    static void Main()
    {
        Bojovnik karel = new Bojovnik();

        karel.Utok();
        karel.Utok(10);
        karel.Utok("Sekera");
        karel.Utok(10, "Sekera");
    }
}
