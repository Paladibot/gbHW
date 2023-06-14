// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

int CheckMethodForLenghtArray(string message)
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

int CheckMethod(string message)
{   
    Console.Write($"{message}");

    string input = Console.ReadLine();

    if(string.IsNullOrEmpty(input))
    {
        return -1;
    }
    if(input.Length != 3)
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

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] resultArray = new int[size];

    for (int i = 0; i < resultArray.Length; i++) // i < resultArray.Length = i < size
    {
        resultArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return resultArray;
}

int FindEvenNumbers(int[] array)
{ 
  int result = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] % 2 == 0)
    {
      result++;
    }
  }
  return result;
}

int size = CheckMethodForLenghtArray("Введите длину массива: ");
int minValue = CheckMethod("Введите минимальное значение массива: ");
int maxValue = CheckMethod("Введите максимальное значение массива: ");
if (size == -1 || minValue == -1 || maxValue == -1)
{
  Console.WriteLine("Ошибка ввода. Введите трехзначное число для значений размера массива.");
}
else
{
 int[] array = GetArray(size, minValue, maxValue);
 int result = FindEvenNumbers(array);
 Console.WriteLine($"{result} - Кол-во найденых четных чисел в массиве");
}


//Подскажите, как вместо двух методов сделать один на проверку и длинны массива и условия на трехзначное число