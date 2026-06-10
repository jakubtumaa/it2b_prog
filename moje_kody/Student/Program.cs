class Program
{
    static void Main()
    {
        Student Jakub = new Student("Jakub", 18, "IT2B");

        Jakub.Znamka(2);
        Jakub.Znamka(1);
        Jakub.ZmenaTridy("IT2A");

        Console.WriteLine($"Jmeno: {Jakub.Jmeno} | Vek: {Jakub.Vek} | Trida: {Jakub.Trida} | Znamky: {string.Join(", ", Jakub.Znamky)}");
    }
}
