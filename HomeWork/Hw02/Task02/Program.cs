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





