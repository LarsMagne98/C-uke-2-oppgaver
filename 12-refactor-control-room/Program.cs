// Et lite konsollprogram som bruker metoder til å gjøre operasjoner.
// Du kan legge til, fjerne eller skrive ut ting fra listen "beacons".


List<string> beacons = new List<string>();

bool running = true;

void PrintMenu()
{
    Console.WriteLine();
    Console.WriteLine("1 - Add beacon");
    Console.WriteLine("2 - Remove beacon");
    Console.WriteLine("3 - List beacons");
    Console.WriteLine("4 - Quit");
    Console.Write("Choice: ");
}

void AddBeacon(string? name)
{
    if (!string.IsNullOrWhiteSpace(name))
    {
        beacons.Add(name);
        Console.WriteLine("Beacon added.");
    }
}

void RemoveBeacon(string? name)
{
    if (name is not null && beacons.Remove(name))
    {
        Console.WriteLine("Beacon removed.");
    }
    else
    {
        Console.WriteLine("Beacon not found.");
    }
}

void PrintBeacons()
{
    if (beacons.Count == 0)
    {
        Console.WriteLine("No beacons registered.");
    }
    else
    {
        foreach (string beacon in beacons)
        {
            Console.WriteLine($"- {beacon}");
        }
    }
}



while (running)
{
    PrintMenu();

    string? choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.Write("Beacon name: ");
            AddBeacon(Console.ReadLine());
            break;

        case "2":
            Console.Write("Beacon name: ");
            RemoveBeacon(Console.ReadLine());
            break;

        case "3":
            PrintBeacons();
            break;

        case "4":
            running = false;
            break;

        default:
            Console.WriteLine("Unknown choice.");
            break;

    }
}


// Ferdig. Lærerik oppgave!