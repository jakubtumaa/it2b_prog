class Program
{
    static void Main() {
        char odpoved;
        int cislo;
        int opakovani = 0;
        int SmazVyskyt;

        List<int> list = new List<int>();

        Console.WriteLine("Chces zadat nahodne cisla? Y/N ");
        odpoved = char.Parse(Console.ReadLine());

        if (odpoved == 'N' || odpoved == 'n')
        {
            return;
        }

        do
        {
            Console.WriteLine("Zadej nahodne cele cislo do listu: ");
            cislo = int.Parse(Console.ReadLine());

            list.Add(cislo);
            opakovani++;

            if (opakovani == 3)
            {
                Console.WriteLine("Chces pokracovat? Y/N ");
                odpoved = char.Parse(Console.ReadLine());
                opakovani = 0;
            }

        } while (odpoved != 'N' && odpoved != 'n');

        Console.WriteLine("Vyber jake cislo chces z listu odstranit: ");
        SmazVyskyt = int.Parse(Console.ReadLine());

        while (list.Contains(SmazVyskyt))
        {
            list.Remove(SmazVyskyt);
        }

        foreach (int i in list)
        {
            Console.Write(" " + i);
        }
        
    }
}