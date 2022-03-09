using Willem;

WillemKlein willem = new WillemKlein();
SimonVanDeMeer simon = new SimonVanDeMeer();

//willem.Bereken(simon.Add, 3, 4);


MathDel m1 = simon.Add;
m1 = m1 + simon.Add;
m1 = m1 + simon.Subtract;
m1 = m1 + simon.Add;
m1 += simon.Subtract;
m1 = m1 - simon.Subtract;
m1 -= simon.Add;

foreach (var m in m1.GetInvocationList())
{
    Console.WriteLine(m.Method.Name);
}

int res = m1(1, 2);
Console.WriteLine(res);
