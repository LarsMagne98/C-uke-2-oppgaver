// En liste med orderer.
// foreach som sjekker om en ordre er "CANCELLED" og hopper over de.
// og så skriver ut rekkefølgen på orderen og hva orderen gjelder.

List<string> repairs = new List<string>
{
    "Replace antenna",
    "CANCELLED: Paint corridor",
    "Seal cargo hatch",
    "Recalibrate sensor",
    "CANCELLED: Move storage crate"
};

int jobNumber = 1;

foreach (string repair in repairs)
{
    if (repair.StartsWith("CANCELLED:"))
    {
        continue;
    }
    else
    {
        Console.WriteLine($"Job {jobNumber}: {repair}");
        jobNumber++;
    }
}

// Ferdig
