Console.Write("Введите количество строк матрицы: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы: ");
int cols = int.Parse(Console.ReadLine());
// Создание и заполнение двумерной матрицы
int[,] matrix = new int[rows, cols];
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Console.Write($"Введите элемент [{i},{j}]: ");
        matrix[i, j] = int.Parse(Console.ReadLine());
    }
}
int sum = 0;
// Поиск и суммирование модулей отрицательных нечетных элементов
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        if (matrix[i, j] < 0 && matrix[i, j] % 2 != 0)
        {
            sum += Math.Abs(matrix[i, j]);
        }
    }
}
Console.WriteLine($"Сумма модулей отрицательных нечетных элементов: {sum}");
Console.ReadLine();
