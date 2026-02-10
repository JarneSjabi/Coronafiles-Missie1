Virus v = new Virus();

List<Vaccin> vaccins = new List<Vaccin>();
for (int i = 0; i < 5; i++)
{
    vaccins.Add(new Vaccin(i.ToString()));
}

Vaccin theCure = null;
bool cureGevonden = false;
while (v.DoomCountDown > 0 && cureGevonden == false)
{
    foreach (Vaccin vaccin in vaccins)
    {
        if (v.TryVaccin(vaccin) == true)
        {
            theCure = vaccin;
            cureGevonden = true;
            break;
        }
    }
}

if (cureGevonden == true)
{
    //Fase 2
    theCure.ToonInfo();
    VaccinatieCentrum.BewaarVaccin(theCure.Oplossing);

    List<VaccinatieCentrum> centra = new List<VaccinatieCentrum>();
    for (int i = 0; i < 5; i++)
    {
        centra.Add(new VaccinatieCentrum());
    }

    List<Vaccin> containerVaccins = new List<Vaccin>();
    foreach (var centrum in centra)
    {
        for (int i = 0; i < 7; i++)
        {

            containerVaccins.Add(centrum.GeefVaccin());
        }
    }


    for (int i = 0; i < containerVaccins.Count; i++)
    {
        Console.Write(i);
        containerVaccins[i].ToonInfo();
    }

}
else
{
    Console.WriteLine("Gedaan");
}