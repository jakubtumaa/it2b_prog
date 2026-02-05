class Program                                //Největší společný dělitel
{
    static int Delitele(int a, int b)
    {
        int NejvetsiCislo = 0; 
        if (a < b)
        {
            NejvetsiCislo = b;
        } else if (a > b)
        {
            NejvetsiCislo = a;
        } else if (a == b)
        {
            Console.WriteLine($"Cisla jsou stejne takze maji stejne delitele.");
            return a;
        }

        int SpolecnyDelitel = 0;

        for (int i = 1; i < NejvetsiCislo; i++)
        {
            if (a %  i == 0 && b % i == 0)
            {
                SpolecnyDelitel = i;
            }
        }
        return SpolecnyDelitel;
    } 

    static void Main()
    {
        Console.WriteLine("Zadej cele cislo: ");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Zadej druhe cele cislo: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine($"Jejich spolecny delitel je {Delitele(a, b)}.");
    }     
    }