//Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.

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

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] resultArray = new int[size];

    for (int i = 0; i < resultArray.Length; i++) // i < resultArray.Length = i < size
    {
        resultArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return resultArray;
}

int SumOddNumbers(int[] array)
{
  int result = 0;
  for (int i = 0; i < array.Length; i++)
  {
   if (i % 2 != 0)
   {
      result += array[i];
   }
  }
  return result;

}

int size = CheckMethod("Введите длину массива: ");
int minValue = CheckMethod("Введите минимальное значение массива: ");
int maxValue = CheckMethod("Введите максимальное значение массива: ");
if (size == -1 || minValue == -1 || maxValue == -1)
{
  Console.WriteLine("Ошибка ввода. Введите число.");
}
else
{
  int[] array = GetArray(size, minValue, maxValue);
  int result = SumOddNumbers(array);
  Console.WriteLine($"Сумма: {result}");
}
