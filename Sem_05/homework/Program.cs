// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
    // /*****************  ОБЪЯВЛЕНИЕ МЕТОДОВ  ***********************/
    // int[] GenerateRandomArray(int size, int start, int end) //Метод для создания массива размера size 
    // {                                                       // из случайных чисел из диапазона [start;end]
    //     int[] randomArray = new int[size];  // объявляем массив размера size( количество элементов = size)
    //     for (uint i = 0; i < size; i++)      // т.е.выделение памяти для хранения переменных типа int (количество переменных = size)
    //     {
    //         randomArray[i] = new Random().Next(start, end + 1); // Генерируем число из диапазона [start;end] 
    //     }                                                       // и записываем его в i-й элемент массива
    //     return randomArray; //так как "int[] Gen..." то вернуть должны массив.
    // }
    // void ShowArray(int[] array1)  //Метод для вывода элементов массива в 
    // {                             //консоль для вывода на экрана передаём массив "int[] "
    //     Console.Write("[");
    //     uint arr_size = (uint)array1.Length; 
    //     for (uint i = 0; i < arr_size; i++)
    //     {
    //         if (i < arr_size-1) {   Console.Write(array1[i]+", ");     }
    //         else                {   Console.Write(array1[i]+"]");      }
    //     }
    // }
    // uint CountOfEven(int[] array2)  // Проверка количества чётных чисел (элементов) массива
    // {                               //передаём "()" в метод ShowArray массив "int[] ", возвращаем число "uint"
    //     uint count = 0;
    //     uint arr_size = (uint)array2.Length;
    //     for (uint i = 0; i < arr_size; i++)
    //         if (array2[i] % 2 == 0) ++count;
    //     return count;
    // }
    // /**********  ВЫЗОВ РАНЕЕ ОБЪЯВЛЕННЫХ МЕТОДОВ ~ VOID MAIN  *****************/
    // Console.Write("\nВведите количество случайных чисел из диапазона [100; 999] и нажмите enter:\n"); 
    // uint coutOfNumbers = Convert.ToUInt32(Console.ReadLine());
    // int[] arrayNumbers = new int[coutOfNumbers];
    // arrayNumbers = GenerateRandomArray(coutOfNumbers, 100, 999);
    // Console.WriteLine("Количество чётных чисел:");
    // ShowArray(arrayNumbers);
    // Console.WriteLine(" -> " + CountOfEven(arrayNumbers) + "\n");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
    // /*****************  ОБЪЯВЛЕНИЕ МЕТОДОВ  ***********************/
    // int[] GenerateRandomArray(int size, int start, int end) //Метод для создания массива размера size 
    // {                                                       // из случайных чисел из диапазона [start;end]
    //     int[] randomArray = new int[size];  // объявляем массив размера size( количество элементов = size)
    //     for (uint i = 0; i < size; i++)      // т.е.выделение памяти для хранения переменных типа int (количество переменных = size)
    //     {
    //         randomArray[i] = new Random().Next(start, end + 1); // Генерируем число из диапазона [start;end] 
    //     }                                                       // и записываем его в i-й элемент массива
    //     return randomArray; //так как "int[] Gen..." то вернуть должны массив.
    // }
    // void ShowArray(int[] array)  //Метод для вывода элементов м-ассива в 
    // {                             //консоль для вывода на экрана передаём массив "int[] "
    //     Console.Write("[");
    //     uint arr_size = (uint)array.Length; 
    //     for (uint i = 0; i < arr_size; i++)
    //     {
    //         if (i < arr_size-1) {   Console.Write(array[i]+", ");     }
    //         else                {   Console.Write(array[i]+"]");      }
    //     }
    // }
    // int SumOfOddPosElements(int[] array) // Поиск суммы элементов массива сна нечётных ПОЗИЦИЯХ
    // {                                    // нумерация позиций: 1, 2, 3, 4 ... индексы же 0, 1, 2, 3 ...
    //     int result = 0;
    //     uint arr_size = (uint)array.Length;
    //     for (uint i = 0; i < arr_size; i = i+2)
    //         result += array[i];
    //     return result;
    // }
    // /**********  ВЫЗОВ РАНЕЕ ОБЪЯВЛЕННЫХ МЕТОДОВ ~ VOID MAIN  *****************/
    // Console.Write("\nВведите количество случайных чисел и нажмите enter:\n"); 
    // int coutOfNumbers = Convert.ToInt32(Console.ReadLine());
    // int[] arrayNumbers = new int[coutOfNumbers];
    // arrayNumbers = GenerateRandomArray(coutOfNumbers, -100, 100);
    // Console.WriteLine("Сумма элементов массива на нечётных позициях:");
    // ShowArray(arrayNumbers);
    // Console.WriteLine(" -> " + SumOfOddPosElements(arrayNumbers) + "\n");

// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
    // /*****************  ОБЪЯВЛЕНИЕ МЕТОДОВ  ***********************/
    // double[] GenerateRandomArray(int size, int start, int end) //Метод для создания массива размера size 
    // {                                                       // из случайных чисел из диапазона [start;end]
    //     double[] randomArray = new double[size];  // объявляем массив размера size( количество элементов = size)
    //     for (uint i = 0; i < size; i++)      // т.е.выделение памяти для хранения переменных типа int (количество переменных = size)
    //     {
    //         randomArray[i] = new Random().NextDouble()*(end-start) + start; // Генерируем число из диапазона [start;end] 
    //     }                                                       // c масштабирванием и записываем его в i-й элемент массива
    //     return randomArray; //так как "int[] Gen..." то вернуть должны массив.
    // }
    // void ShowArray(double[] array)  //Метод для вывода элементов м-ассива в 
    // {                             //консоль для вывода на экрана передаём массив "int[] "
    //     Console.Write("[");
    //     uint arr_size = (uint)array.Length; 
    //     for (uint i = 0; i < arr_size; i++)
    //     {
    //         if (i < arr_size-1) {   Console.Write("{0:f2}, ", array[i]);    }
    //         else                {   Console.Write("{0:f2}]",array[i]);      }
    //     }
    // }
    // double RangeOfMinMax(double[] array) // Поиск суммы элементов массива сна нечётных ПОЗИЦИЯХ
    // {                                    // нумерация позиций: 1, 2, 3, 4 ... индексы же 0, 1, 2, 3 ...
    //     double result = 0,
    //             min = array[0],
    //             max = array[0];
    //     uint arr_size = (uint)array.Length;
    //     for (uint i = 1; i < arr_size; i++)
    //         if (array[i] > max)     max = array[i];
    //         else if (array[i] < min) min = array[i];
    //     result = max-min;
    //     return result;
    // }
    // /**********  ВЫЗОВ РАНЕЕ ОБЪЯВЛЕННЫХ МЕТОДОВ ~ VOID MAIN  *****************/
    // Console.Write("\nВведите количество случайных чисел и нажмите enter: "); 
    // int coutOfNumbers = Convert.ToInt32(Console.ReadLine());
    // double[] arrayRealNumbers = new double[coutOfNumbers];
    // arrayRealNumbers = GenerateRandomArray(coutOfNumbers, -10, 10);
    // Console.WriteLine("Разница между минимальным и максимальным элементом массива:");
    // ShowArray(arrayRealNumbers);
    // Console.WriteLine(" -> {0:f2}\n", RangeOfMinMax(arrayRealNumbers));