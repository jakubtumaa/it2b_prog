using System;

class Pokoj
{
    public string Jmeno { get; set; }
    public int Postele { get; set; }
    public int VolneMista { get; set; }
    public List<string> Pacienti { get; set; } = new List<string>();

    public Pokoj(string jmeno, int postele, int volneMista)
    {
        Jmeno = jmeno;
        Postele = postele;
        VolneMista = volneMista;
    }

    public void PridejPacienta(string pacient)
    {
        if (VolneMista > 0)
        {
            Pacienti.Add(pacient);
            VolneMista--;
            Console.WriteLine($"Pacient {pacient} byl pridan.");
        }
    }

    public void OdeberPacienta(string pacient)
    {
        Pacienti.Remove(pacient);
        VolneMista++;
        Console.WriteLine($"Pacient {pacient} byl odebran.");
    }
}