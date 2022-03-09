using System.Collections;

//ArrayList list = new ArrayList();
List<int> list = new List<int>(); 

list.Add(1);
list.Add(2);
list.Add(3);
//list.Add("4");

foreach (int x in list)
{
    Console.WriteLine(x);
}

Queue<long> queue = new Queue<long>();
queue.Enqueue(3);

long dq = queue.Dequeue();

Stack<short> stack = new Stack<short>();
stack.Push(1); 

short u = stack.Pop();

Dictionary<string, int> dict = new Dictionary<string, int>();

dict.Add("een", 1);
int nr = dict["een"];