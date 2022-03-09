Tuple<string, int, double> t1 = new Tuple<string, int, double>("Hoi", 42, 800);

//Console.WriteLine(t1.Item1);
//Console.WriteLine(t1.Item2);
//Console.WriteLine(t1.Item3);


(string Name, int Age, double Year) t2 = ("Hallo", 42, 1000);


(string n, int c, double y) = t2;

Console.WriteLine(n);
Console.WriteLine(c);


Show(t2);


void Show((string Name, int Age, double Year) val)
{
    Console.WriteLine(t2.Name);
    Console.WriteLine(t2.Age);
    Console.WriteLine(t2.Year);
}

