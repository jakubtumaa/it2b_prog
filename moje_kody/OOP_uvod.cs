Student: 
class Student
{
    //atributy:
    public string Jmeno {  get; set; }
    public int Vek { get; set; }
    public string Trida { get; set; }
    public List<int> Znamky { get; set; }

    //konstruktor: 
    public Student(string jmeno, int vek, string trida)
    {
        Jmeno = jmeno;
        Vek = vek;
        Trida = trida;
        Znamky = new List<int>();
    }

    public void PridejZnamku(int znamka)
    {
        Znamky.Add(znamka);
    }
}

Program: 
class Program
{
    static void Main()
    {
        Student karel = new Student("Karel", 5, "IT-10A");

        karel.PridejZnamku(2);

        Student monika = new Student("Monika", 12, "IT-3B");

        Console.WriteLine($"Jmeno: { karel.Jmeno} | Vek: { karel.Vek} | Trida: { karel.Trida}");

        Console.WriteLine($"Jmeno: {monika.Jmeno} | Vek: {monika.Vek} | Trida: {monika.Trida}");
    }
}