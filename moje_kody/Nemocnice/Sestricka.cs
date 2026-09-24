using System;

class Sestricka
{
    public string Jmeno {  get; set; }
    private int Plat {  get; set; }

    public Sestricka (string jmeno, int plat)
    {
        Jmeno = jmeno;
        Plat = plat;
    }

    public void PridejPlat(int pridani)
    {
        Plat = Plat + pridani;
        Console.WriteLine($"Pridano k platu: {pridani}, novy plat: {Plat}");
    }

    public void StrhniPlat(int strhnuti)
    {
        Plat = Plat - strhnuti;
        Console.WriteLine($"Plat byl strhnut, strhnuti : {strhnuti}, novy plat: {Plat}");
    }
}