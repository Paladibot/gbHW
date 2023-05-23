//Метод, который генерирует и заполняет массив рандомными двухзначными числами

/*
void GenNumbers(int[] arr)
        {
            Random rnd = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(10, 100);
            }
        }


        int[] arr = new int[10]; // { 0,0,0,0,0,0....}

            GenNumbers(arr); // { 15,15,64,16,83....}

            for (int i = 0; i < arr.Length; i++) // 0 = 15 1 = 15 2 = 64 ...
            {
                int left = arr[i] / 10; // 15 / 10 = 1
                int right = arr[i] % 10; // 15 % 10 = 5
                if (left > right)
                {
                    Console.WriteLine($"Наибольшая цифра числа {arr[i]} = " + left);
                }
                else
                {
                    Console.WriteLine($"Наибольшая цифра числа {arr[i]} = " + right);
                }
            }
            */

//Находим 1 и 3 число из сгенерированого трехзначного числа

Random rnd = new Random();
int rndNum = rnd.Next(100, 1000); // array 100-999
Console.WriteLine(rndNum);
int a = rndNum / 100; // 
int c = rndNum % 10; //
int res = 10 * a + c;
Console.Write(res);

