// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] GetArray(int size)
// size = 12, minValue = -9, maxValue = 9
{
    int[] resultArray = new int[size];
    Console.Write($"Введите значение 1: ");
    for (int i = 0; i < resultArray.Length; i++) // i < resultArray.Length = i < size
    {
        resultArray[i] = Convert.ToInt32(Console.ReadLine());
        Console.Write($"Введите значение {i + 2}: ");
    }
    return resultArray;
}
int FindPositiveNumbers(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) result++;
    }
    return result;
}
Console.Write("Введите кол-во вводимых симолов на проверку:");
int a = Convert.ToInt32(Console.ReadLine());
int[] array = GetArray(a);
int b = FindPositiveNumbers(array);
Console.WriteLine();
Console.WriteLine("_____________________");
Console.WriteLine($"Массив: [ {String.Join("; ", array)} ]");
Console.WriteLine($"Кол-во чисел больше нуля: {b}");