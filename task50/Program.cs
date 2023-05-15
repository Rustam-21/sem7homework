Console.Write("Введите m массива: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите n массива: ");
int n = int.Parse(Console.ReadLine());

double[,] array = new double[m, n];
Random rand = new Random();

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = rand.NextDouble() * 200 - 100;
    }
}

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write($"{array[i, j]:F2}\t");
    }
    Console.WriteLine();
}
Console.Write("Введите номер строки элемента: ");
int row = int.Parse(Console.ReadLine());

Console.Write("Введите номер столбца элемента: ");
int col = int.Parse(Console.ReadLine());

if (row >= 0 && row < m && col >= 0 && col < n)
{
    Console.WriteLine($"Значение элемента [{row}, {col}]: {array[row, col]:F2}");
}
else
{
    Console.WriteLine("Элемент с такими координатами не существует");
}
