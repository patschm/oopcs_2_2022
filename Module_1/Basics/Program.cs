namespace Basics
{
    public class Program
    {
        public static void Main()
        {
            //double age = 45/2D;
            string? name = null;
            int a = 1; // 0001
            int b = 3; // 0011

            int c = a ^ b;

            bool d = a == 2 && b == 3;

            short x =(short)a; //(as short)
           
            Console.WriteLine(name ?? "X");

        }
    }
}
