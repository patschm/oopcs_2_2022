Patrick p = new Patrick();
Reinout r = new Reinout();

r.RegelHetMaar(Explode);


void Explode(int e)
{
    for(int i = 0; i < e; i++)
        Console.WriteLine("Kabooommm!!!");
}
