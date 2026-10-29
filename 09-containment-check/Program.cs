// En metode som tar inn flere integers, gjør en kalkulasjon, returener true eller false
// ut i fra om occupied + incoming er større enn eller mindre enn capacity.
// Så en if sjekk for å sjekke om accepted er true eller false,
// og skriver så ut i konsollen om det var plass eller ikke.

bool accepted = CanContain(10, 0, 10);


if (accepted)
{
    Console.WriteLine("ACCEPTED");
}
else
{
    Console.WriteLine("REJECTED");
}

static bool CanContain(int capacity, int occupied, int incoming)
{
    if (occupied + incoming > capacity)
    {
        return false;
    }
    else
    {
        return true;
    }
}

// Ferdig.