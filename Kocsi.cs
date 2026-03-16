namespace VonatProjekt;

public class Kocsi
{
    private int max_ulesszam;
    private List<Utas> utaslista;

    public Kocsi(int max_ulesszam)
    {
        this.max_ulesszam = max_ulesszam;
        this.utaslista = new List<Utas>();
    }

    public List<Utas> Utaslista
    {
        get => utaslista;
        set => utaslista = value;
    }

    public int MaxUlesszam
    {
        get => max_ulesszam;
        set => max_ulesszam = value;
    }

    public int UtasSzam
    {
        get
        {
            return utaslista.Count;
        }
    }

    public void Beszall(Utas utas)
    {
        if (UtasSzam < max_ulesszam)
        {
            this.utaslista.Add(utas);
            Console.WriteLine($"{utas.Nev} felszállt a vonatra, integet!");
        }
        else
        {
            Console.WriteLine("Nincs elég hely!");
        }
    }

    public Utas Leszall(string nev)
    {
        Utas s = null;
        foreach (var item in utaslista)
        {
            if (item.Nev == nev)
            {
                s = item;
            }
            
        }
        utaslista.Remove(s);
        return s; 
    }
}