//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.

int NumberMoreOrLess(int num1, int num2)
{
    if(num1 > num2) Console.WriteLine($"Число {num1}, больше чем {num2}.");
    if(num1 < num2) Console.WriteLine($"Число {num2}, больше чем {num1}.");
    if(num1 == num2) Console.WriteLine($"Число {num1} и {num2} равны!.");
    return 0;
}

NumberMoreOrLess(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())); 
