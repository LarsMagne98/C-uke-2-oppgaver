// while (ture) kjører til brukeren skriver EXIT i konsollen, eller hvis f.eks en .txt fil ikke har mere innhold.
// string? gjør at den kan ta i mot "null".
// Alt annet blir skrevet ut igjen i konsollen.

while (true)
{
    Console.Write("Command: ");
    string? command = Console.ReadLine();

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