//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
/*
int NumberMoreOrLess(int num1, int num2)
{
    if(num1 > num2) Console.WriteLine($"Число {num1}, больше чем {num2}.");
    if(num1 < num2) Console.WriteLine($"Число {num2}, больше чем {num1}.");
    if(num1 == num2) Console.WriteLine($"Число {num1} и {num2} равны!.");
    return 0;
}

NumberMoreOrLess(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())); 

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

          


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).

int EvenNumbers(int num1)
{
    if(num1 % 2 == 0) Console.WriteLine($"Число {num1}, является четным");
    else Console.WriteLine($"Число {num1}, не является четным");

    return 0;
}

EvenNumbers(Convert.ToInt32(Console.ReadLine()));
*/
//Задача 8: Напишите программу, которая на вход принимает число (N),
//а на выходе показывает все чётные числа от 1 до N.

int FullStackEven (int num1)
{
    
    for (int i = 0; i <= num1; i++)
    {   
        if (i % 2 == 0) Console.Write($"{i} ");
        
    }

    return 0;
}
FullStackEven(Convert.ToInt32(Console.ReadLine()));