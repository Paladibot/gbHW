// Задача 10: Напишите программу,
// которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int NumberTwoDetected(int arg1)
{
    int num = 0;
    if(arg1 > 99 && arg1 < 1000) num = arg1;
    else Console.WriteLine("Вы ввели не трехзначное число");

    arg1 = arg1 % 100;
    arg1 = arg1 / 10;
    Console.WriteLine(arg1);
    return 0;
}

NumberTwoDetected(int.Parse(Console.ReadLine()));

