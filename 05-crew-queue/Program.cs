// En liste med navn, noen metoder for å legge til og fjerne navn fra listen.
// Skriver så ut hvor mange navn listen inneholder, og hvert navn i listen.

List<string> crew = new List<string> { "Bex", "Ivo", "Nia" };

// Kan burke AddRange(), men står spesifikt i oppgaven at eg skal burke Add.
crew.Add("Mira");
crew.Add("Sol");
crew.Remove("Bex");

Console.WriteLine($"Crew count: {crew.Count}");

crew.ForEach(Console.WriteLine);
// List<T> har innebygd .ForEach() metode. Kinda cool.
// Ferdig.