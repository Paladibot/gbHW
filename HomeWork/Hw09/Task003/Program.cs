﻿﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");

int functionAkkerman = MethodOfAkkerman(m, n);

Console.Write($"Функция Аккермана = {functionAkkerman} ");

int MethodOfAkkerman(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return MethodOfAkkerman(m - 1, 1);
  else return MethodOfAkkerman(m - 1, MethodOfAkkerman(m, n - 1));
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}