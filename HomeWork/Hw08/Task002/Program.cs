// Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int InputCheckMethod(string message)
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

int rows = InputCheckMethod("Введите кол-во строк: ");
if(rows == -1) return;
int columns = InputCheckMethod("Введите кол-во столбцов: ");
if(columns == -1) return;
int range = InputCheckMethod("Введите диапазон: от 1 до ");
if(range == -1) return;

int[,] matrix = new int[rows, columns];
GetMatrix(matrix);
WriteMatrix(matrix);

int minSumRow = 0;
int sumRow = SumRow(matrix, 0);
for (int i = 1; i < matrix.GetLength(0); i++)
{
    int tempSumRow = SumRow(matrix, i);
    if (sumRow> tempSumRow)
    {
        sumRow = tempSumRow;
        minSumRow = i;
    }
}

int SumRow(int[,] matrix, int i)
{
    int sumRow = matrix[i, 0];
    for (int j = 1; j < matrix.GetLength(1); j++)
    {
        sumRow += matrix[i, j];
    }
    return sumRow;
}

void GetMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(range + 1);
        }
    }
}

void WriteMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine($"{minSumRow + 1} - строкa с наименьшей суммой значений ({sumRow})");