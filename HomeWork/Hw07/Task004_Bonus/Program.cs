int CheckMethod(string message)
{
    Console.Write($"{message}");
    string input = Console.ReadLine();

    if (string.IsNullOrEmpty(input))
    {
        return -1;
    }

    int result;
    if (!int.TryParse(input, out result))
    {
        return -1;
    }
    return result;
}

int[,] GetMatrix(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n]; // Таблица из m строк и n столбцов
    for (int i = 0; i < matrix.GetLength(0); i++) // Цикл по строчкам , i < m
    {
        // // i,j,m,k
        for (int j = 0; j < matrix.GetLength(1); j++)// Цикл по стобцам , j < n
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int DiagonalResult(int[,] matrix, int rows, int columns)
{
    Console.WriteLine("Сумма диагонали:");
    int sum = 0;
    for (int i = rows - 1; i >= 0; --i)
    {
        for (int j = columns - 1; j >= 0; --j)
        {
            if (i == j)
                sum += matrix[i, j];
        }
    }
    return sum;
}

int rows = CheckMethod("Введите кол-во строк массива: ");
int columns = CheckMethod("Введите кол-во столбцов массива: ");

int[,] resMatrix = GetMatrix(rows, columns, 10, 100);
PrintMatrix(resMatrix);

Console.WriteLine(DiagonalResult(resMatrix, rows, columns));
