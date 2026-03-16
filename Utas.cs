namespace VonatProjekt;

public class Utas
{
    private string nev;
    private int ponggyasszam;
    private string felszalasHelye;
    private string leszalasHelye;

    public Utas(string nev, int ponggyasszam, string felszalasHelye, string leszalasHelye)
    {
        this.nev = nev;
        this.ponggyasszam = ponggyasszam;
        this.felszalasHelye = felszalasHelye;
        this.leszalasHelye = leszalasHelye;
        
    }


    public string Nev
    {
        get => nev;
    }

    public int Ponggyasszam
    {
        get => ponggyasszam;
        set => ponggyasszam = value;
    }

    public string FelszalasHelye
    {
        get => felszalasHelye;
    }
    
    public string LeszalasHelye
    {
        get => leszalasHelye;
        set => leszalasHelye = value;
    }

    public override string ToString()
    {
        return $"{this.nev} felszáll a vonatra: {this.felszalasHelye} {this.ponggyasszam} csomaggal, és leszál:  {this.leszalasHelye}.";
    }
    
}
