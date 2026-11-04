class DopravniProstredek
{
    public string Znacka {  get; set; }
    public int RokVyroby { get; set; }

    public DopravniProstredek(string znacka, int rokVyroby)
    {
        Znacka = znacka;
        RokVyroby = rokVyroby;
    }

    public virtual void Jed()
    {
        Console.WriteLine("Dopravni prostredek jede");
    }

    public void Info()
    {
        Console.WriteLine($"Znacka: {Znacka} | Rok vyroby: {RokVyroby}"); 
    }
}

class Auto : DopravniProstredek
{
    public int PocetDveri { get; set; }
    public Auto(string znacka, int rokVyroby, int pocetDveri) : base(znacka, rokVyroby)
    {
        PocetDveri = pocetDveri;
    }

    public override void Jed()
    {
        Console.WriteLine("Auto jede po silnici");
    }
}

class Motorka : DopravniProstredek
{
    public int ObjemMotoru { get; set; }
    public Motorka(string znacka, int rokVyroby, int objemMotoru) : base(znacka, rokVyroby)
    {
        ObjemMotoru = objemMotoru;
    }

    public override void Jed()
    {
        Console.WriteLine("Motorka jede po silnici");
    }
}

class Program
{
    static void Main()
    {
        List<DopravniProstredek> Dopravniprostredek = new List<DopravniProstredek>();
        Auto auto = new Auto("Skoda", 2012, 4);
        Dopravniprostredek.Add(auto);
        Motorka motorka = new Motorka("Bati", 2014, 49);
        Dopravniprostredek.Add(motorka);

        foreach(DopravniProstredek x in  Dopravniprostredek)
        {
            x.Info();
            x.Jed();
        }
    }
}
