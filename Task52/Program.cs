// Task52
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[m, n];
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = new Random().Next(0, 10);
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}
for (int j = 0; j < arr.GetLength(1); j++)
{
    double numb = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        numb += arr[i, j];
    }
    Console.WriteLine("Сумма в столбце  = {0}", numb);
}