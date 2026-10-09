using System.Security.Permissions;

string[] planetCodes = { "ORION-4", "KAPPA-9", "LYRA-2", "NOVA-7", "VEGA-3" };
bool found = false;

// TODO: Skriv Length, første og siste element.
// TODO: Finn KAPPA-9 med en løkke.

foreach (var plant in planetCodes)
{
    if (plant == "KAPPA-9")
    {
        found = true;
    }
}
Console.WriteLine($"Number of codes: {planetCodes.Length}");
Console.WriteLine($"First code:{planetCodes[0]}");
Console.WriteLine($"Last code:{planetCodes[^1]}");
Console.WriteLine($"Found KAPPA-9: {found}");

// Ferdig.