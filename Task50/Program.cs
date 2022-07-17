// Task51
Console.WriteLine("введите число 'М' и 'N': "); int m = Convert.ToInt32(Console.ReadLine()); int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число 'I' и 'J': "); int i0 = Convert.ToInt32(Console.ReadLine()); int j0 = Convert.ToInt32(Console.ReadLine());
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
if (i0 >= m || j0 >= n || i0 <= 0 || j0 <= 0) Console.WriteLine("Нет такого числа!");
else
{
    Console.WriteLine("Число с координатами {0}.{1} = {2}", i0, j0, arr[i0, j0]);
}

