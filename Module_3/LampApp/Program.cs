// Virtuele wereld (Big bang)

using LampApp;

Lamp l1 = new Lamp(200, ConsoleColor.Green);
//l1.intensiteit = 200;
//l1.kleur = ConsoleColor.Yellow;
l1.naam = "Fi fi";

l1.Aan();

Console.WriteLine("In het licht schrijven");


l1.Uit();

Console.WriteLine("In het donker");

Lamp tl = new Lamp { kleur = ConsoleColor.Red, intensiteit = 300 };
tl.Aan();
