class Matematika
{
    public int Minimum(int x, int y)
    {
        if (y < x)
        {
            return y;
        }
        else
        {
            return x;
        }
    }

    public int Minimum(int x, int y, int z)
    {
        if (x <= y && x <= z)
        {
            return x;
        } else if (y <= z && y <= x)
        {
            return y;
        } else
        {
            return z;
        }
    }

    public int Minimum(int[] pole)
    {
        int min = pole[0];
        for (int i = 1; i < pole.Length; i++)
        {
            if (pole[i] < min)
            {
                min = pole[i];
            }
        }
        return min;
    }
}

class Program
{
    static void Main()
    {
        Matematika mat = new Matematika();
        Console.WriteLine(mat.Minimum(5, 10));
        Console.WriteLine(mat.Minimum(5, 10, 3));
        int[] pole = { 5, 10, 3, 8, 2 };
        Console.WriteLine(mat.Minimum(pole));
    }
}
