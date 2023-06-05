// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.

string TryParseMethod(string argTPM1) //Проверяет строку на наличие символов
{  
   
   int number = 1;
   bool isNumber = int.TryParse(argTPM1, out number);
   if(number == 0) 
   {
     Console.WriteLine("В строке присутствуют символы");
     
   }
   return argTPM1;
   
   
}
string LenghtArg(string argLA1) //Проверяет строку на длинну из 5-ти символов
{   
  
    if (argLA1.Length != 5)
    {
      Console.WriteLine("Укажите значение нужной длинны, из 5-ти символов");
    }
    return argLA1; 
    
}
string TruePolindrom(string arg1) //Проверяет строку, является ли она полиндромом
{ 
   if (arg1[0] == arg1 [4] && arg1[1] == arg1[3])
   {
      Console.WriteLine($"{arg1} - Является полиндромом");
   }
   else Console.WriteLine($"{arg1} - Не является полиндромом");
  
   return arg1;
}


string result = TryParseMethod(Console.ReadLine()); 
result = LenghtArg(result);
TruePolindrom(result);
//123

