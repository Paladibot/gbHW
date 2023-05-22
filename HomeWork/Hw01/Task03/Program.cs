// Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).

int EvenNumbers(int num1)
{
    if(num1 % 2 == 0) Console.WriteLine($"Число {num1}, является четным");
    else Console.WriteLine($"Число {num1}, не является четным");

    return 0;
}

EvenNumbers(Convert.ToInt32(Console.ReadLine()));