namespace VonatProjekt;

class Program
{
    static void Main(string[] args)
    {
        List<string> megallohelyek = new List<string>{"Budapest","Ferihegy","Cegléd","Szolnok","Püspökladány","Hajdúszoboszló","Debrecen","Nyiregháza","Kisvárda","Záhony"};
        Utas u1 = new Utas("János", 2, "Budapest", "Debrecen");
        Utas u2 = new Utas("Juliska", 1, "Budapest", "Szolnok");

        Console.WriteLine(u1);
        Console.WriteLine(u2);

        Kocsi k1 = new Kocsi(32);
        k1.Beszall(u1);
        k1.Beszall(u2);

        Console.WriteLine($"{k1.UtasSzam} utas ül a kocsiban");
        k1.Leszall("Juliska");
        Console.WriteLine($"{k1.UtasSzam} utas ül a kocsiban");
    }
}