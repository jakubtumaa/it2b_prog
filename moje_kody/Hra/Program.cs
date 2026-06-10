class Program
{
    static void Main()
    {
        Hra Jakub = new Hra("Jakub", 10, 0);

        Jakub.PridejPredmet("Mec");
        Jakub.PridejPredmet("Helma");
        Jakub.LevelUp(3);
        Jakub.VypisInfo();

        Hra Filip = new Hra("Filip", 10, 0);

        Filip.PridejPredmet("Mec");
        Filip.PridejPredmet("Helma");
        Filip.PridejPredmet("Lek");
        Filip.LevelUp(3);
        Filip.VypisInfo();

        Jakub.Utok(Filip, 2);
        Filip.VypisInfo();
        Filip.Vyleceni(Filip, 2);
        Filip.VypisInfo();
    }
}
