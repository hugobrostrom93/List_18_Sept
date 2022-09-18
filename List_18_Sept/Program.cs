// List<> <----- Generisk typ - den byter form till det vi anger
// Listan bryr sig inte om vi lägger till eller tar bort, den anpassar sig.
// En array har alltid en fast läng till skillnad från List
// Behöver vi snabbhet och vi vet hur många poster det är. Använd en array, annars är List bättre om vi vill att den ska vara dynamisk och anpassa sig

// C.R.U.D
// C = Create   ( Add )
// R = Read     ( list[x] )
// U = Update   ( list [x] = "Hello" )
// D = Delete   ( Remove, RemoveAll ) 
// L = List     ( For Each)

List<int> siffror = new List<int>();
siffror.Add(20);
siffror.Add(30);
siffror.Add(36);
siffror.Add(4);
siffror.Add(3);
siffror.Add(72);
siffror.Add(20);
siffror.Add(20);
siffror.Remove(20); // Tar bort FÖRSTA specifika siffran 20
siffror.RemoveAt(1); // Tar bort index 1. Alltså siffran 30
siffror.RemoveAll(x => x == 20); // Tar bort alla nummer 20
// Lambda kod                =>
// x är bara en variabel
// Kommandot RemoveAll loopar igenom ALLA värden i listan och tar bort matchande
siffror = siffror.FindAll(x => x > 10); // Skriver över den gamla listan och tar fram tal där x är större än 10

for (int i = 0; i < siffror.Count; i++) // På listor används .Count istället för .Length
{
    Console.WriteLine(siffror[i]);
}
siffror.ForEach(x => Console.WriteLine(x)); // Exakt samma som koden ovan (For loopen)
// x = en helt vanlig variabel
// efter => talar vi om vad som ska köras
// ForEach loopar igenom hela listan


List<string> namn = new ();
namn.Add("Hugo Broström");
namn.Add("Peter Frändberg");

// En lista i en lista. Hemskt med det funkar! 
List<List<int>> listaMedNummer = new();
listaMedNummer.Add(new List<int> {1, 2, 3, 4});