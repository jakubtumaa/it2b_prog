class Zvire
{
    public string Jmeno {  get; set; }
    public int Vek { get; set; }

    public Zvire(string jmeno, int vek)
    {
        Jmeno = jmeno;
        Vek = vek;
    }

    public virtual void VydavejZvuk()
    {
        Console.WriteLine("Zvuk zvirete");
    }
}

class Pes : Zvire
{
    public Pes(string jmeno, int vek) : base(jmeno, vek) 
    {
    }

    public override void VydavejZvuk()
    {
        Console.WriteLine("Haf haf!");
    }
}

class Kocka : Zvire
{
    public Kocka (string jmeno, int vek) : base(jmeno, vek)
    {
    }

    public override void VydavejZvuk()
    {
        Console.WriteLine("Mnau!");
    }
}

class Program
{
    static void Main()
    {
        List<Zvire> Zvire = new List<Zvire>();
        Pes pes = new Pes("Alik", 3);
        Zvire.Add(pes);
        Kocka kocka = new Kocka("Micka", 2);
        Zvire.Add(kocka);

        foreach (Zvire x in Zvire)
        {
            x.VydavejZvuk();
        }
    }
}
