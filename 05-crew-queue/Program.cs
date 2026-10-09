List<string> crew = new List<string> { "Bex", "Ivo", "Nia" };

// TODO: Endre listen etter instruksjonene.
// Kan burke AddRange(), men står spesifikt i oppgaven at eg skal burke Add.
crew.Add("Mira"); 
crew.Add("Sol");
crew.Remove("Bex");

Console.WriteLine($"Crew count: {crew.Count}");

// TODO: Skriv alle navn med en løkke.
crew.ForEach(Console.WriteLine);
// List<T> har innebygd .ForEach() metode. Kinda cool.
// Ferdig.