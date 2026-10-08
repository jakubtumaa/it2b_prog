class Program
{
    static void Main()
    {

    }
}
class Maksym
{
    public void Max(int x, int y)
    {
        if (x < y)
        {
            Console.WriteLine($"Maksym je {y}");
        }
        else if (y < x)
        {
            Console.WriteLine($"Maksym je {x}");
        }
        else
        {
            Console.WriteLine($"Maksym je, ale cisla jsou stejne velka {x}={y}");
        }
    }
    public void Max(int x, int y, int z)
    {
        if (x >= y && x >= z)
        {
            Console.WriteLine($"Maksym je {x}");
        }
        else if (y >= x && y >= z)
        {
            Console.WriteLine($"Maksym je {y}");
        }
        else if (z >= x && z >= y)
        {
            Console.WriteLine($"Maksym je {z}");
        }
        else
        {
            Console.WriteLine($"Maksym je, ale cisla jsou stejne velka {x}={y}={z}");
        }     
    }
    public void Max(int[] x)
    {
        int max = x[0];
        foreach (int i in x)
        {
            if (max < x[i]) 
            {
                max = x[i];
            }
        }
        Console.WriteLine(max);
    }
}