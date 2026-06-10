public class Student
{
    public string Jmeno { get; set; }
    public int Vek { get; set; }
    public string Trida { get; set; }
    public List<int> Znamky { get; set; }


    public Student (string jmeno, int vek, string trida)
    {
        Jmeno = jmeno;
        Vek = vek;
        Trida = trida;
        Znamky = new List<int>();
    }

    public void Znamka(int znamka)
    {
        Znamky.Add(znamka);
    }

    public void ZmenaTridy(string novaTrida)
    {
        Trida = novaTrida;
    }
}
