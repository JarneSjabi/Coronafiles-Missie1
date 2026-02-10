class Virus
{
    public string Naam { get; private set; }
    private int doomCountDown;

    public int DoomCountDown
    {
        get { return doomCountDown; }
        set
        {
            if (value <= 0)
            {
                Console.WriteLine("Game Over");
            }
            doomCountDown = value;
        }
    }

    private int killcode;
    static Random r = new Random();
    public Virus()
    {
        DoomCountDown = r.Next(100, 200);
        killcode = r.Next(0, 99);

        for (int i = 0; i < 3; i++)
        {
            Naam += (char)r.Next('a', 'z' + 1);
        }
        Naam += r.Next(1, 100);
    }

    virtual public bool TryVaccin(Vaccin vacin)
    {
        var ktest = vacin.TryKillCode();
        if (ktest == killcode)
        {
            vacin.Oplossing = ktest;
            return true;

        }
        DoomCountDown--;
        return false;
    }
}