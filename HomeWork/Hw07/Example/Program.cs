// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

// Двумерный массив

// метод для создания массива
// Двумерный массив = matrix
// m - кол-во строчек, n - столбцов

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