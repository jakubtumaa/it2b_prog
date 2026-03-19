class Program                          
{
    static void Main()
    {
        char odpoved;
        string login;
        string password;
        string message;
        int pokus = 0;

        Console.WriteLine("Vytvor Username/Login: ");
        login = Console.ReadLine();

        Console.WriteLine("Vytvor Password/Heslo: ");
        password = Console.ReadLine();
        
        Console.WriteLine("Vytvoreni udaju probehlo uspesne, prosim prihlaste se pomocí svych novych udaju. Zadejte Username/Login: ");
        string login1 = Console.ReadLine();
        while(login1 != login)
        {
            Console.WriteLine("Spatne Username/Login! Zkuste to znovu: ");
            login1 = Console.ReadLine();
            pokus += 1;
            if (pokus > 5)
            {
                break;
            }
        }

        pokus = 0;

        Console.WriteLine("Zadejte Password/Heslo: ");
        string password1 = Console.ReadLine();
        while(password1 != password)
        {
            Console.WriteLine("Spatne Password/Heslo! Zkuste to znovu: ");
            password1 = Console.ReadLine();
            pokus += 1;
            if (pokus > 5)
            {
                break;
            }
        }

        Console.WriteLine("Uspesne jste se prihlasil/a, napiste tajnou zpravu, kterou uvidite jen vy: ");
        message = Console.ReadLine();

        Console.WriteLine("Chcete si precist zpravu? Y/N");
        odpoved = char.Parse(Console.ReadLine()); 
        if (odpoved == 'Y' || odpoved == 'y')
        {
            Console.WriteLine($"{message}");
        } else if (odpoved == 'N' || odpoved == 'n')
        {
            return;
        }

    }
}