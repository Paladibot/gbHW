// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int Prompt(string message)
{
    Console.WriteLine(message);
    string input = Console.ReadLine();
    int result = Convert.ToInt32(input);
    return result;
}

int[] GenerationArray (int min, int max, int lenghtArray)
{
    int[] array = new int [lenghtArray];
    Random rand = new Random();
    for (int i = 0; i < lenghtArray; i++)
    {
        array[i] = rand.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }

}

int minS = Prompt("Минимальное значение: ");
int maxS = Prompt("Максимальное значение: ");
int lenghtS = Prompt("Длина массива: ");

int[] array = GenerationArray(minS, maxS, lenghtS);

PrintArray(array);


