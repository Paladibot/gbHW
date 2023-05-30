var stringNumber = "0003"; // var - ключевое слово, определяет тип данных
int number; // Если строчка состоит только из чисел,
// то в переменную попадает наше число
// TryParse (строчка, out переменная) -- out переменная - сохраняем число

bool isNumber = int.TryParse(stringNumber, out number);
// isNumber = true, то строка состоит только из чисел ("2")
// false - присутствуют в строке еще и символы, number = 0
if (isNumber && stringNumber.Length >= 3) // isNumber == true
{
Console.WriteLine("Перевод произошел успешно, в строчке есть ТОЛЬКО цифры");
Console.WriteLine(number);
Console.WriteLine("Третья цифра числа: " + stringNumber[2]);
}
else // isNumber == false
{
Console.WriteLine("Ошибка! В строчке присутсвуют и другие символы");
Console.WriteLine(number);
}
