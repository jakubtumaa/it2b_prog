class Program                  //FizzBuzz
{
    static void Main()
    {
        Console.WriteLine("Zadej cele cislo: ");
        int cislo = int.Parse(Console.ReadLine());

        for (int i = 1; i <= cislo; i++) { 
            if (i % 3 == 0)
            {
                Console.WriteLine($"Fizz");
            }
            else if (i % 5 == 0) {
                Console.WriteLine($"Buzz");
            } else
            {
                Console.WriteLine(i);
            }
        }
    }
}