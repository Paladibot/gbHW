//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

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

double[] FindColumnArray(int[,] matrix)
{
    int rowLength = matrix.GetLength(0);
    int colLength = matrix.GetLength(1);
    double[] array = new double[colLength];

    for (int i = 0; i < colLength; i++)
    {
        double sum = 0;

        for (int j = 0; j < rowLength; j++)
        {
            sum += matrix[j, i];
        }

        array[i] = sum / rowLength;
    }

    return array;
}
void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "\t");
    }
}

int rows = CheckMethod("Введите кол-во строк массива: ");
int columns = CheckMethod("Введите кол-во столбцов массива: ");

int[,] resMatrix = GetMatrix(rows, columns, 10, 100);
PrintMatrix(resMatrix);

double[] result = FindColumnArray(resMatrix);
PrintArray(result);
