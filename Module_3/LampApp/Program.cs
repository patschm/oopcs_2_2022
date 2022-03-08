// Virtuele wereld (Big bang)

using LampApp;

Lamp l1 = new Lamp(200, ConsoleColor.Green);
l1.Intensiteit = 400;
//l1.kleur = ConsoleColor.Yellow;
l1.Naam = "Fi fi";

l1.Aan();
Console.WriteLine(l1.Verbruik);

Console.WriteLine("In het licht schrijven");


l1.Uit();

Console.WriteLine("In het donker");

Lamp tl = new Lamp() { Kleur = ConsoleColor.Red, Intensiteit=300};
tl.Aan();
