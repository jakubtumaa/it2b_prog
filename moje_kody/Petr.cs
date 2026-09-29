using System.Runtime.InteropServices;

class Program
{
    static void Main()
    {
        Clovek Petr = new Clovek("Petr", 90, 18);
        Petr.Promluv();
    }
}

class Savec
{
    public string Jmeno {  get; set; }
    public int Hmotnost { get; set; }

    public Savec (string jmeno, int hmotnost)
    {
        Jmeno = jmeno;
        Hmotnost = hmotnost;
    }

    static void Koznumace(string jidlo, Savec Jmeno)
    {
        Console.WriteLine($"{Jmeno} snedl {jidlo}");
    }
}

class Clovek
{
    public string JmenoCloveka { get; set; }
    public int HmotnostCloveka { get; set; }
    public int VekCloveka { get; set; }

    public Clovek(string jmenoCloveka, int hmotnostCloveka, int vekCloveka)
    {
        JmenoCloveka = jmenoCloveka;
        HmotnostCloveka = hmotnostCloveka;
        VekCloveka = vekCloveka;
    }

    public void Promluv()
    {
        Console.WriteLine($"Ahoj, jsem {JmenoCloveka}. Vazim {HmotnostCloveka} kg a je mi {VekCloveka} let.");
    }
}