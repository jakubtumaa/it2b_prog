class Obchod
{
    public double Cena(double x)
    {
        return x;
    }

    public double Cena(double x, double y)
    {
        return x * y;
    }

    public double Cena(double x, double y, double z) 
    {
        return (x * y) - ((x * y) * (z / 100));
    }
}

class Program
{
    static void Main()
    {
        Obchod a = new Obchod();

        Console.WriteLine(a.Cena(100));
        Console.WriteLine(a.Cena(100, 3));
        Console.WriteLine(a.Cena(100, 3, 20));
    }
}
