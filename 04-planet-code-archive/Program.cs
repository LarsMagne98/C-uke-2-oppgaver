// En foreach som sjekker om "KAPPA-9" finnes i kolleksjonen planetCodes.
// Deretter skrives det i konsollen hvor mange planetkoder den inneholder,
// første og siste planetkoden,
// og så om "KAPPA-9" ble funnet.

string[] planetCodes = { "ORION-4", "KAPPA-9", "LYRA-2", "NOVA-7", "VEGA-3" };
bool found = false;


foreach (var planet in planetCodes)
{
    if (planet == "KAPPA-9")
    {
        found = true;
    }
}
Console.WriteLine($"Number of codes: {planetCodes.Length}");
Console.WriteLine($"First code:{planetCodes[0]}");
Console.WriteLine($"Last code:{planetCodes[^1]}");
Console.WriteLine($"Found KAPPA-9: {found}");

// Ferdig.