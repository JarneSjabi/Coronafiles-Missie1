Dictionary<string, VaccinatieCentrum> centraDB = new Dictionary<string, VaccinatieCentrum>();

while (true)
{
    Console.WriteLine("Wat wil je doen?");
    Console.WriteLine("1. Centra tonen");
    Console.WriteLine("2. Centrum bijmaken");
    Console.WriteLine("3. Centra vaccins laten maken");
    int keuze = Convert.ToInt32(Console.ReadLine());
    switch (keuze)
    {
        case 1:
            foreach (var centrum in centraDB)
            {
                Console.WriteLine(centrum.Key);
            }
            break;
        case 2:
            Console.WriteLine("Waar wil je dit bouwen?");
            string waar = Console.ReadLine();
            if (centraDB.ContainsKey(waar))
                Console.WriteLine("Dat land heeft reeds een centrum");
            else
                centraDB.Add(waar, new VaccinatieCentrum());
            Console.WriteLine("Gebouwd!");
            break;
        case 3:
            Console.WriteLine("Welk land moet vaccins maken?");
            string waarv = Console.ReadLine();
            if (centraDB.ContainsKey(waarv))
            {
                Vaccin gemaaktVaccin = centraDB[waarv].GeefVaccin();
                Console.WriteLine("Vaccin gemaakt");
                // ...
            }

            else
                Console.WriteLine("Dat land heeft geen vaccinatiecntrum");
            break;
        default:
            Console.WriteLine("Onbekend getal");
            break;
    }


    Console.WriteLine("Waar moet centra komen?");
    string stadin = Console.ReadLine();

}