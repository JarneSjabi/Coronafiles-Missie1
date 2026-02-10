class VaccinatieCentrum
{
    public static int Oplossing { get; set; } = -1;
    public static void BewaarVaccin(int killcodein)
    {
        Oplossing = killcodein;
    }

    public Vaccin GeefVaccin()
    {
        if (Oplossing == -1) return null;

        return new Vaccin("THECURE", Oplossing);
    }
}