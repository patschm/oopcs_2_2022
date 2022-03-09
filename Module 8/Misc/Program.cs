using Misc;

Point p1 = new Point { X = 10, Y = 20 };
Console.WriteLine(p1);
DoeIets(p1);
Console.WriteLine(p1);

void DoeIets(Point aa)
{
    aa.X = 100;
    aa.Y = 200;
}