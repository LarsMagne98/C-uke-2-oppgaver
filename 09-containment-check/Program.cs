bool accepted = CanContain(10, 6, 4);

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
    // TODO
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