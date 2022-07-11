// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
/*
    //Метод 1 - Возведие в степень  
    int exponentiation(int num1, int num2)
    {
        //через модуль получаем натуральную степень числа num2
        return Convert.ToInt32((Math.Pow(num1, Math.Abs(num2))));
    }

    //Основная программа
    // Ввод числа пользователе: проверка числа на целое не провожу, так как есть неявное преобразование
    Console.Write("\nВедите число А и нажмите enter: ");
        int numnberA = Convert.ToInt32(Console.ReadLine());
    Console.Write("Ведите число B и нажмите enter: ");
        int numnberB = Convert.ToInt32(Console.ReadLine());
    //Выводрезультатма с вызовом метода 1 для взведения в степень
    Console.Write("Результат вычислений A^B: {0}, {1} -> {2} \n\n", numnberA, numnberB, 
                                        exponentiation(numnberA,numnberB));
*/


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
/*
    //Метод 1 - Сумма цифр числа 
    int SumOfNumbers(string str)
    {
        int size = str.Length, 
            sum = 0;
        // Пример решения через строки
        for (int i = 0; i < size; i++)
        {
            //Проверка, если пользователь сделал опечатку с литерой, либо есть минус и т.д. 
            if (str[i] >= '1' && str[i] <='9')  //от 1 (49) до 9 (57): (int)str[i] >= 49 && (int)str[i] <= 57)
            {
                sum += (int)char.GetNumericValue(str[i]);  //Это складывает цифры
                //sum += (int)str[i];                       //Это складывает ASCII-коды цифр
            }
        }
        
            // Пример решения через разряды чисел
            sum = 0;                            //Console.WriteLine(Convert.ToString(sum));
            int number = Math.Abs(Convert.ToInt32(str));  //Console.WriteLine('\t'+ Convert.ToString(number));
            while(number > 0)
            {
                // Остаток от деления
                sum += number % 10;             //Console.WriteLine(Convert.ToString(sum));
                // Целочисленное деление
                number /= 10;                   //Console.WriteLine('\t'+ Convert.ToString(number));
            }
        
        return sum;
    }

    //Основная программа
    // Ввод числа пользователе: проверка числа на целое не провожу, так как есть неявное преобразование
    Console.Write("\nВедите натуральное число и нажмите enter: ");
    string numnber_str = Console.ReadLine()!;
    //сюда сохраняю сумму
    int SumOfSymbols = SumOfNumbers(numnber_str);
    //Вывод результата
    Console.Write("\n{0} -> {1}\n\n", numnber_str, SumOfSymbols);
*/

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
/*
    // Метод 1 - Создание массива из случайных чисел
    int[] CreateRandomArray(int size, int min, int max)
    {
        //объявляем массив - выделяем область памяти в ОЗУ
        int[] array = new int[size];
        //Создаём объект класаа псевдослучайных чисел
        Random rnd = new Random(); 
        // заполняем значениями ранее зарезервированную память
        for (int i = 0; i < size; i++)
        {
            array[i] = rnd.Next(min, max + 1);
        }
        return array;
    }

    // Метод 2 - Вывод в консоль сгенерированного массива в формате: 6, 1, 33 -> [6, 1, 33]
    void ShowArray(int[] array)
    {   
        int size = array.Length;    // экономлю на времени исполнения, чтоб в for постоянно не вызывать
        string str1 = "", str2 = ""; // создал 2 пустые строки для "6, 1, 33" и "[6, 1, 33]"
        str2 = "[";
        for (int i = 0; i < size; i++)
        {   
            //наращиваем строку через перегруженный оператор + (+=) класса String
            str1 += Convert.ToString(array[i]);
            str2 += Convert.ToString(array[i]);
            //условие, рождённое из-за запятой - добавление пунктуации
            if (i < size-1)
            {
                str1 += ", ";
                str2 += ", ";
            }            
        }
        str2 += "]";
        Console.WriteLine("\n" + str1 + " -> " + str2 + "\n");
    }
   
    //Основная программа
    //вызов метода 1 при перегрузке конструктора для созданиия массива 
    int[] arr_rnd = CreateRandomArray(8, 1, 20); 
    //вызов метода 2
    ShowArray(arr_rnd);  
*/