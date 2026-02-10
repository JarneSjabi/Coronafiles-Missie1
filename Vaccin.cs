class Vaccin
{
    public string Naam { get; private set; }
    public Vaccin(string naamin)
    {
        Naam = naamin;

    }
    public Vaccin(string naamin, int oploss)
    {
        Oplossing = oploss;
        Naam = naamin; //:this(naamin)
    }

    static Random r = new Random();
    public int Oplossing { get; set; } = -1;
    virtual public int TryKillCode()
    {
        if (Oplossing != -1)
        {
            return Oplossing;
        }

        return r.Next(1, 100);
    }
    public void ToonInfo()
    {
        Console.WriteLine($"{Naam}, Oplossing is: {Oplossing}");
    }
}