Console.Write("Введите m массива: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите n массива: ");
int n = int.Parse(Console.ReadLine());

Console.Write("Введите минимальное значение элементов: ");
int min = int.Parse(Console.ReadLine());

Console.Write("Введите максимальное значение элементов: ");
int max = int.Parse(Console.ReadLine());

int[,] array = new int[m, n];
Random rand = new Random();

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
   {
    array[i, j] = rand.Next(min, max + 1);
   }
}
Console.WriteLine("Массив:");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write("{0, 4}", array[i, j]);
    }
    Console.WriteLine();
}

Console.WriteLine("Среднее арифметическое элементов в столбцах:");
for (int j = 0; j < n; j++)
{
    double sum = 0;
    for (int i = 0; i < m; i++)
    {
        sum += array[i, j];
    }
    double average = sum / m;
    Console.WriteLine("Столбец {0}: {1}", j + 1, average);
}