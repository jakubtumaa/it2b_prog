class Program                            //binární číslice
{
    static bool Overeni(string a)
    {
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] != '0' && a[i] != '1' && a[i] != ',')
            {
                return false;
            }
        }
        return true;
    }

    static void Main()
    {
        Console.WriteLine("Zadej nahodne binarni cislice: ");
        string x = Console.ReadLine();

        Console.WriteLine(Overeni(x));
    }
}