//Задача 15: Напишите программу, которая принимает на вход цифру,
//обозначающую день недели, и проверяет, является ли этот день выходным.

int WeekendOrWorkDay(int arg1)
{ 
  if(arg1 > 7 && arg1 < 0)
  {
    do
    {
      Console.Write($"{arg1} неверное значение");
      Console.Write("Введите значение заново: ");
    } 
    while (arg1 > 7 && arg1 < 0);
  }
   
  else if (arg1 < 6 && arg1 > 0) Console.WriteLine($"{arg1} день недели не является выходным");
  else if (arg1 > 5 && arg1 < 8) Console.WriteLine($"{arg1} является выходным");
  
  
  return arg1;
}

WeekendOrWorkDay(int.Parse(Console.ReadLine()));


// Уже сил не выдумывать, почему не просиходит зацикливание проверки числа?