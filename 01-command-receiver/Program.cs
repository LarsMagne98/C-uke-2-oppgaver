while (true)
{
    Console.Write("Command: ");
    string? command = Console.ReadLine();

    // TODO: Avslutt med break når command er EXIT eller null.
    // TODO: Ellers skriv Received: <command>.
    if (command == "EXIT" || command == null)
    {
        break;
    }
    else
    {
        Console.WriteLine($"Recieved: {command}");
    }
}

Console.WriteLine("Receiver stopped.");

// Ferdig. dotnet run < test.txt hadde vert en evig loop uten null som break.