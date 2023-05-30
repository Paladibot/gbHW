//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int ThreeNumbers(string arg2)
{
    if(arg2.Length < 3) Console.WriteLine("Третьего числа нету");
    char chr = arg2[2];
    int resultParse = int.Parse(chr.ToString());
    return resultParse;
}


int result = ThreeNumbers(Console.ReadLine());
Console.WriteLine(result);



// // 17. Напишите программу, которая принимает на вход координаты
// // точки (X и Y), причём X ≠ 0 и Y ≠ 0 и
// // выдаёт номер четверти плоскости, в которой находится эта точка.

Console.Write("Введите координату по оси oХ: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату по оси oY: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
Console.WriteLine("I четверть");
}

else if (x < 0 && y > 0)
{
Console.WriteLine("II четверть");
}

else if (x < 0 && y < 0)
{
Console.WriteLine("III четверть");
}

else if (x > 0 && y < 0)
{
Console.WriteLine("IV четверть");
}
else
{
Console.WriteLine("Вы попали в коорд. ось");
}

