// Tsk 47
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
double[,] arr = new double[m, n];
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = new Random().NextDouble() + new Random().Next(0, 10);
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}




