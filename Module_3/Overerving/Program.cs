using LampApp;
using Overerving;

LampFactory fact = new TLFactory { StarterTijd = 600 };

// Generaliseren
//Lamp l1 = new TL { Intensiteit = 100, Kleur = ConsoleColor.Green, StarterTijd=800 };
Lamp l1 = fact.Create(200, ConsoleColor.Red);
l1.Aan();

l1.Uit();
