class Program              //Výpočet výplaty učitele
{
    static void Main()
    {
        Console.WriteLine("Zadej pocet prednasek: ");      //printf("Zadej pocet prednasek: ");
        int prednasky = int.Parse(Console.ReadLine());     //scanf("%d", &prednasky); //int prednasky;

        Console.WriteLine("Zadej pocet seminaru: ");       //printf("Zadej pocet seminaru: ");
        int seminare = int.Parse(Console.ReadLine());      //scanf("%d", &seminare); //int seminare;

        Console.WriteLine("Zadej hodinovou mzdu ucitele: ");      //printf("Zadej hodinovou mzdu ucitele: ");
        int mzda = int.Parse(Console.ReadLine());                 //scanf("%d", &mzda); //int mzda;

        Console.WriteLine($"Jeho/ji vyplata je: {(2 * prednasky) * seminare * mzda}");    //printf("Jeho/ji vyplata je: %d", vyplata); //int vyplata = (2 * prednasky) * seminare * mzda
    }
}