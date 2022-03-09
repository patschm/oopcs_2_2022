using RekenLib;
using System.Globalization;

//Thread.CurrentThread.CurrentCulture = new CultureInfo("de-DE");

Console.WriteLine(DateTime.Now.ToString());
Rekenmachine calc = new Rekenmachine();

int a =AskUserInput("A");
int b =AskUserInput("B");

int result = calc.Add(a, b);
Console.WriteLine(result);
try
{
    double r2 = calc.Divide(a, b);
    Console.WriteLine(r2);
}
catch (Exception ex)
{
    Console.WriteLine(ex);
}


int AskUserInput(string v)
{
    do
    {
        Console.WriteLine($"Geeft getal {v}");
        string s = Console.ReadLine();
        try
        {
            int nr = int.Parse(s);
            return nr;
        }
        catch (FormatException fe)
        {
            Console.WriteLine("Dit is een ongeldig getal");
        }
        catch (OverflowException fe)
        {
            Console.WriteLine("Het getal is te groot of te klein");
        }
        catch(Exception e)
        {

        }
        finally
        {
            Console.WriteLine("Tenslotte");
        }
    }
    while (true);
}