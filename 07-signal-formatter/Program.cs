// En metode som tar inn en string, og returnerer den i nytt format
// med en metode som gjør alle bokstaver til store bokstaver.

Console.WriteLine(FormatSignal("moon-base"));
Console.WriteLine(FormatSignal("relay-7"));
Console.WriteLine(FormatSignal("cargo-deck"));

static string FormatSignal(string source)
{
    return $"[SIGNAL FROM: {source.ToUpper()}]";
}

// Ferdig.