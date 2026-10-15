// En metode som tar inn listen med ting og en string.
// En foreach som sjekker om listen inneholder hva enn string search er.
// Returnerer true eller false ut i fra om den innehold tingen eller ikke.

List<string> manifest = new List<string> { "LENS", "BATTERY", "FILTER", "CABLE" };

Console.WriteLine(ContainsItem(manifest, "FILTER"));
Console.WriteLine(ContainsItem(manifest, "WRENCH"));

static bool ContainsItem(List<string> items, string search)
{
    foreach (var item in items)
    {
        if (item == search)
        {
            return true;
        }
    }
    return false;
}

// Ferdig.