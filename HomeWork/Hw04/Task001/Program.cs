// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.


string Input(string arg1)
{ 
  Console.Write($"{arg1}");
 
  string input = Console.ReadLine();
  return input;
   
}

string CheckMethod(string argCheckMethod1)
{
   int number = 1;
   bool isNumber = int.TryParse(argCheckMethod1, out number);
   if(number == 0)
   {
    Console.WriteLine("В строке присутствуют символы");
    return null;
   }
   else return argCheckMethod1;
  
}

int Power(int argNaturalNumber1, int argNaturalNumber2)
{ 
  int result = 1;
  for (int i = 0; i < argNaturalNumber2; i++)
  {
     result *= argNaturalNumber1;
  }
  return result;
  
}
string arg = Input("Введите значение: ");
string power = Input("Введите степень: ");
string arg1 = CheckMethod(arg);
string power2 = CheckMethod(power);

int res1 = Convert.ToInt32(arg1);
int res2 = Convert.ToInt32(power2);

int final = Power(res1, res2);
Console.WriteLine(final);






