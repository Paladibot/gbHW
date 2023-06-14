//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double CheckMethod(string message)
{
    Console.Write($"{message}");

    string input = Console.ReadLine();
    double result = Convert.ToDouble(input);
    /* if(string.IsNullOrEmpty(input))
     {
         return -1;
     }

     double result;

     if(!double.TryParse(input, out result))
     {
         return -1;
     }
     */
    return result;
}
/*
double[] GetArray(int size, double minValue, double maxValue)
{
    double[] resultArray = new double[size];

    for (int i = 0; i < resultArray.Length; i++) // i < resultArray.Length = i < size
    {
        resultArray[i] = Convert.ToDouble(new Random().Next(minValue, maxValue + 1));
        
    }
    return resultArray;
}
*/
double[] array = {1.1, 2.2, 3.3, 6.4, 5.5};

double FindMinMax(double[] array)
{   
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    double result = max - min;
    return result;
}

double result = FindMinMax(array);
Console.WriteLine(result);
/*
double size = CheckMethod("Введите длину массива: ");
double minValue = CheckMethod("Введите минимальное значение массива: ");
double maxValue = CheckMethod("Введите максимальное значение массива: ");

double[] array = GetArray(size, minValue, maxValue);
double result = FindMinMax(array);
Console.WriteLine($"Сумма: {result}");
*/


