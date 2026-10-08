using System;

class Program
{
    static void Main()
    {
        Dum dum = new Dum(8654000, "Hezky domecek", 11.2, 20.1, 2);

        dum.Info();
    }
}

class Objekt
{
    public int Cena { get; set; }
    public string Popis { get; set; }
    public double VnitrniVymera { get; set; }

    public Objekt (int cena, string popis, double vnitrniVymera)
    {
        Cena = cena;
        Popis = popis;
        VnitrniVymera = vnitrniVymera;
    }
}

class Dum : Objekt
{
    public double Zahrada { get; set; }
    public int PocetPater {  get; set; }

    public Dum (int cena, string popis, double vnitrnivymera, double zahrada, int pocetPater) : base (cena, popis, vnitrnivymera)
    {
        Zahrada = zahrada;
        PocetPater = pocetPater;
    }

    public void Info()
    {
        Console.WriteLine($"{Cena}\n{Popis}\n{VnitrniVymera}\n{Zahrada}\n{PocetPater}");
    }
}