class Program
{
    static bool Trojuhelnik(double a, double b, double c)
    {
        double NejvetsiCislo = 0;
        double MensiCislo = 0;

        if (a > b && a > c)
        {
            NejvetsiCislo = a;
            MensiCislo = b + c;
        }
        else if (b > a && b > c)
        {
            NejvetsiCislo = b;
            MensiCislo = a + c;
        }
        else if (c > a && c > b)
        {
            NejvetsiCislo = c;
            MensiCislo = b + a;
        }

        if (MensiCislo > NejvetsiCislo)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    static void Main()
    {
        double x, y, z;
        int NejvetsiCislo;

        Console.WriteLine("Zadej prvni stranu trojuheliku: ");
        x = double.Parse(Console.ReadLine());

        Console.WriteLine("Zadej druhou stranu trojuhelniku: ");
        y = double.Parse(Console.ReadLine());

        Console.WriteLine("Zadej treti stranu trojuhelniku: ");
        z = double.Parse(Console.ReadLine());

       Console.WriteLine($"Cisla se rovnaji: {Trojuhelnik(x, y, z)}");
    }
}