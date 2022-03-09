// .NET 1.0/1.1 (2002/2003)
MathDel m1 = new MathDel(Add);
int result = m1(1, 2);

// .NET 2.0 (2005)
MathDel m2 = Add;
result = m2(2, 3);

int c = 100;
MathDel m3 = delegate(int a, int b)
{
    return a + b + c;
};
result = m3(3,4);

// .NET 3.0/3.5  (2008)
MathDel m4 =  (a, b) => a + b;
result = m4(4, 5);

// Procedures
Action<int> a1 = (x) => Console.WriteLine(x);
a1(42);

// Functions
Func<int, int, int> m5 = Add;
result = m5(5,6);


Console.WriteLine(result);


int Add(int a, int b)
{
    return a + b;   
}
