//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int MaxNumber(int num1, int num2, int num3)
{
    int maxNum = Math.Max(num1, Math.Max(num2, num3));
    Console.WriteLine($"Максимальное число это {maxNum}");

    return maxNum;
}

MaxNumber(Convert.ToInt32(Console.ReadLine()),
          Convert.ToInt32(Console.ReadLine()),
          Convert.ToInt32(Console.ReadLine()));