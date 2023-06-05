// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.

string CheckMethod(string argCM1) //Проверяет строку на наличие символов и длинну
{  

   int number = 1;
   bool isNumber = int.TryParse(argCM1, out number);
  
   if (argCM1.Length != 5 && number == 0)
    {
      Console.WriteLine("Укажите значение нужной длинны, из 5-ти символов");
      Console.WriteLine("В строке присутствуют символы");
      return null;
    }
   if (argCM1.Length != 5)
    {
      Console.WriteLine("Укажите значение нужной длинны, из 5-ти символов");
      return null;
    }
   if(number == 0) 
   {
     Console.WriteLine("В строке присутствуют символы1");
     return null;
   }
   else return argCM1;
   
   
   
}


string TruePolindrom(string arg1) //Проверяет строку, является ли она полиндромом
{ 
   if(arg1 != null)
   {
      if (arg1[0] == arg1 [4] && arg1[1] == arg1[3])
      {
      Console.WriteLine($"{arg1} - Является полиндромом");
      }
      else Console.WriteLine($"{arg1} - Не является полиндромом");
   }
   
   
  
   return arg1;
}


string result = CheckMethod(Console.ReadLine()); 
TruePolindrom(result);


