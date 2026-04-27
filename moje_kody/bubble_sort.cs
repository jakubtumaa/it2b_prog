class Program                                 
{
    static void Main()
    {
        int[] pole = new int[10];
        int temp;

        for (int i = 0; i < pole.Length; i++)
        {
            Console.WriteLine("Zadej cislo: ");
            pole[i] = int.Parse(Console.ReadLine());
        }

        for (int j = 0; j <= pole.Length - 2; j++)
        {
            for (int i = 0; i <= pole.Length - 2; i++)
            {
                if (pole[i] > pole[i + 1])
                {
                    temp = pole[i + 1];
                    pole[i + 1] = pole[i];
                    pole[i] = temp;
                }
            }
        }

        Console.WriteLine("Sorted:");
        foreach (int p in pole)
        {
            Console.Write($"{p} ");
        }
        Console.ReadLine();
    }
}