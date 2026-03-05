class Program
{
    static void Main()                        //Max, Min, Rozdíl, 3 nejmenší čísla
    {
        int[] temperatures = new int[10];       //vytvoření pole s 10 místy

        for (int i = 0; i < temperatures.Length; i++)
        {
            Console.WriteLine("Zadej cislo: ");
            temperatures[i] = int.Parse(Console.ReadLine());
        }

        int max = temperatures.Max();          //automaticky najde nejvěší číslo v poli
        int min = temperatures.Min();          //automaticky najde nejmenší číslo v poli
        int rozdil = max - min;                //rozdíl mezi max a min
        int Nejm1 = 0, Nejm2 = 0, Nejm3 = 0;

        Array.Sort(temperatures);         //seřadí čísla v poli od nejmenšího po největší
        Nejm1 = temperatures[0];
        Nejm2 = temperatures[1];
        Nejm3 = temperatures[2];

        Console.WriteLine($"Nejvetsi cislo: {max}\nNejmensi cislo: {min}\nRozdil mezi nejvetsim a nejmensim je: {rozdil}\nTri nejmensi cisla: {Nejm1}, {Nejm2}, {Nejm3}");

    }
}