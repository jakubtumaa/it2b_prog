using System;
using System.Runtime.CompilerServices;

class Oddeleni
{
    public int VolnePostele { get; set; }

    public List <Pokoj> List = new List <Pokoj> ();

    public Oddeleni (int volnePostele = 0)
    {
        VolnePostele = volnePostele;
    }

    public void PridatPokoj(Pokoj pokoj, Pokoj VolneMista)
    {
        List.Add (pokoj);
        VolnePostele = VolnePostele + pokoj.VolneMista;
    }

    public void Volno()
    {
        Console.WriteLine($"Pocet volnych mist: {VolnePostele}");
    }
}