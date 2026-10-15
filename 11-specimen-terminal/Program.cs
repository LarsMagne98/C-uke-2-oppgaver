// Et lite konsollprogram som lar deg legge til og fjerne ting fra en liste,
// skriver ut hver ting i listen eller hvor mange ting listen inneholder.


List<string> specimens = new List<string>();

while (true)
{
    Console.Write("Command (ADD/REMOVE/LIST/COUNT/QUIT): ");
    string? command = Console.ReadLine().ToUpper();

    if (command == "QUIT" || command == null)
    {
        break;
    }

    switch (command)
    {
        case "ADD":
            Console.WriteLine("Write the name you would like to add.");
            string? nameToAdd = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(nameToAdd))
            {
                specimens.Add(nameToAdd);
            }

            break;

        case "REMOVE":
            Console.WriteLine("Write the name you would like to remove.");
            string? nameToRemove = Console.ReadLine();
            if (nameToRemove != null && specimens.Remove(nameToRemove))
            {
                Console.WriteLine("Removed successfully.");
            }
            else
            {
                Console.WriteLine("That name does not exist in the list. Please try again.");
            }

            break;

        case "LIST":
            if (specimens.Count == 0)
            {
                Console.WriteLine("The list is empty");
            }
            else
            {
                specimens.ForEach(Console.WriteLine);
            }

            break;

        case "COUNT":
            Console.WriteLine($"Count: {specimens.Count}");

            break;

        default:
            Console.WriteLine("Unknown command. Please try again.");

            break;
    }

}

// Ferdig.