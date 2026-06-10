public class Hra
{
    public string Jmeno { get; set; }
    public int Zivoty { get; set; }
    public int Level { get; set; }
    public List<string> Inventar { get; set; }

    public Hra (string jmeno, int zivoty, int level)
    {
        Jmeno = jmeno;
        Zivoty = zivoty;
        Level = level;
        Inventar = new List<string>();
    }

    public void PridejPredmet (string predmet)
    {
        Inventar.Add(predmet);
    }

    public void OdeberPredmet (string predmet)
    {
        Inventar.Remove(predmet);
    }

    public void LevelUp(int lvl)
    {
        Level = Level + lvl;
    }

    public void VypisInfo()
    {
        Console.WriteLine($"Jmeno: {Jmeno}, Pocet zivotu: {Zivoty}, Level: {Level}, Inventar: {string.Join(", ", Inventar)}");
    }

    public void Utok(Hra hrac, int utok)
    {
        hrac.Zivoty -= utok;
    }

    public void Vyleceni(Hra hrac, int lek)
    {
        if (Inventar.Contains("Lek"))
        {
            hrac.Zivoty += lek;
            Inventar.Remove("Lek");
        } else
        {
            Console.WriteLine("Nemas zadny lek!");
        }
    }
}
