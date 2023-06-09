// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int MathRes(int number)
{   
    int res = 0;
    while (number > 0)
    {
        res = res + number % 10;
        number = number / 10;

    }
    return res;
}

int a = MathRes(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine(a);
