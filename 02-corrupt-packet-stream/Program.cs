string[] packets = { "P-100", "CORRUPT", "P-101", "P-102", "CORRUPT", "P-103" };
int processedCount = 0;


// For hver ting i kolleksjonen "packets", så sjekkes det om hver ting er "CORRUPT". Hvis det stemmer, hopper den over den tingen.
// Hvis den ikke er "CORRUPT", så skrives den ut i konsollen, og øker tellingen på processedCount.
// Til slutt skrives det ut i konsollen hvor mange ting som ble tellt og prossesert.
foreach (string packet in packets)
{
    if (packet == "CORRUPT")
    {
        continue;
    }
    else
    {
        Console.WriteLine($"Processed {packet}");
        processedCount++;
    }
}

Console.WriteLine($"Processed packets: {processedCount}");

// Ferdig