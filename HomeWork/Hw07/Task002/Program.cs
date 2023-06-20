//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int CheckMethod(string message)
{   
    Console.Write($"{message}");
    string input = Console.ReadLine();

    if(string.IsNullOrEmpty(input))
    {
        return -1;
    }
    
    int result;
    if(!int.TryParse(input, out result))
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
            Console.Write(matrix[i,j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int FindNumbersByIndex(int[,] matrix, int row, int column)
{
  if(row < 0 || row >= matrix.GetLength(0) || column < 0 || column >= matrix.GetLength(1))
  {
    Console.WriteLine("Такого значения не существует");
  }
  return matrix[row, column];
}

int rows = CheckMethod("Введите кол-во строк массива: ");
int columns = CheckMethod("Введите кол-во столбцов массива: ");

int[,] resMatrix = GetMatrix(rows, columns, 10, 100);
PrintMatrix(resMatrix);

int row = CheckMethod("Введите индекс строки: ");
int column = CheckMethod("Введите индекс столбца: ");

int result = FindNumbersByIndex(resMatrix, row, column);
Console.WriteLine(result);


//Не смог привязать проверку на символы и пустые строки, можете дописать?
