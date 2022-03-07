int[] kluisjes = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
kluisjes[0] = 1;
kluisjes[1] = 2;

Console.WriteLine(kluisjes[1]);


int[,] matrix = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
Console.WriteLine(matrix[0,2]);

int[,,] kubus = new int[3, 3, 3];

int[][] jagged = new int[3][];
jagged[0] = new int[10];
jagged[1] = new int[5];


for(int i = 0; i < kluisjes.Length; i++)
{
    int tmp = kluisjes[i];
    Console.WriteLine(tmp);
}

foreach(int  tmp in kluisjes)
{
    Console.WriteLine(tmp);
}


