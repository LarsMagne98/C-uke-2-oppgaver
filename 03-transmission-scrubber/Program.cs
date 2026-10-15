// En for loop som teller antall "?" i kolleksjonen "transmission".
// Deretter skrives det ut i konsollen hvor mange "?" det var.

string transmission = "AX?19??Q";
int markerCount = 0;

for (int i = 0; i < transmission.Length - 1; i++)
{
    if (transmission[i] == '?')
    {
        Console.WriteLine(i);
        markerCount++;
    }
}

Console.WriteLine($"Marker count: {markerCount}");

// Ferdig.