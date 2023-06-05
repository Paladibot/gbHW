// Задача 21
//Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

int InputN(string message)
{
  Console.Write($"{message}> ");
  int value;
  if (int.TryParse(Console.ReadLine(), out value))
  {
    return value;
  }
  else
  {
  Console.WriteLine("Вы ввели не число");
  Environment.Exit(1);
  return 0;
  }
  

}
int InputNf(string message)
{
    while(true)
    {
     Console.Write($"{message}> ");
     string input = Console.ReadLine();

     int number;
     if(int.TryParse(input, out number))
     {
        Console.WriteLine("Введено число: " + number);
        return number;
        
     }
     else
     {
        Console.WriteLine("Некоректный ввод, введите цифру");
        return 0;
        break;
     }

    }
    
}

int x1 = InputNf ("Введите координату X1");
int y1 = InputNf ("Введите координату Y1");
int z1 = InputNf ("Введите координату Z1");
int x2 = InputNf ("Введите координату X2");
int y2 = InputNf ("Введите координату Y2");
int z2 = InputNf ("Введите координату Z2");

double dis(int x1, int y1, int z1, int x2, int y2, int z2)
{
int deltax = x2 - x1;
int deltay = y2 - y1;
int deltaz = z2 - z1;
return Math.Sqrt(deltax*deltax+deltay*deltay+deltaz*deltaz);
}
System.Console.Write($"Растояние между точками A и B равно {dis(x1, y1, z1, x2, y2, z2):F2}");
