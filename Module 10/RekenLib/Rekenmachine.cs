using System.Diagnostics;

namespace RekenLib
{
    public class Rekenmachine
    {
        public int Add(int a, int b) => a + b;

        public double Divide(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch 
            {
                Trace.WriteLine($"gedeeld door 0 ({a}/{b}");
                throw;
            }
        }
    }
}