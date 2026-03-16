namespace VonatProjekt;

public class MozdonyVezeto
{
    private string nev;
    private string utvonalEngedely;

    public MozdonyVezeto(string nev, string utvonalEngedely)
    {
        this.nev = nev;
        this.utvonalEngedely = utvonalEngedely;
    }

    public string Nev
    {
        get => nev;
        set => nev = value;
    }

    public string UtvonalEngedely
    {
        get => utvonalEngedely;
        set => utvonalEngedely = value;
    }

    public override string ToString()
    {
        return $"{this.Nev}, engedélye: {this.UtvonalEngedely}";
    }
}