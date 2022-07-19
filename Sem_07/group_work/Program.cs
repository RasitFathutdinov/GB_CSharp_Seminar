// int[] CreateRandomArray(int N, int start, int end)  // автоматическое заполнение массива сл. числами
//  {     
//     int[] RandomArray = new int[N];     
//     for (int i = 0; i < N; i++)     
//     {         
//         RandomArray[i] = new Random().Next(start, end + 1);     
//     }     
//     return RandomArray; 
// }

// int[] CreateArray()   // заполнение массива пользователем
// {     
//     Console.WriteLine("Введите количество элементов массива");     
//     int size = Convert.ToInt32(Console.ReadLine());     
//     int[] RandomArray = new int[size];     
//     for (int i = 0; i < size; i++)     
//     {            
//         Console.WriteLine($"Введите {i+1} элемент массива");         
//         RandomArray[i] = Convert.ToInt32(Console.ReadLine());     
//     }     
//     return RandomArray;
// }

// void ShowArray(int[] array)   // вывод массива на экран
// {     
//     for (int i = 0; i < array.Length; i++)     
//     {         
//         Console.Write(array[i] + " ");     
//     }     
//     Console.WriteLine(); 
//  }

// Console.Clear(); 

// // Демонстрация автозаполнения массива псевдослучайными числами
// Console.WriteLine("Введите количество элементов в массиве"); 
// int num = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("Введите первое число случайно генерируемого диапазона"); 
// int min = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("Введите последнее число случайно генерируемого диапазона"); 
// int max = Convert.ToInt32(Console.ReadLine());  
// int[] myRandomArray = CreateRandomArray(num, min, max); 
// ShowArray(myRandomArray); 
// Console.WriteLine("-------"); 

// // Демонстрация заполнения массива пользователем
// int[] myArray = CreateArray(); 
// ShowArray(myArray);






/*     ДВУМЕРНЫЕ МАССИВЫ - СОЗДАНИЕ, ЗАПОЛНЕННОГО СЛ. ЧИСЛАМИ     */
/***********   Методы *************/ 
// int[,] GetRandomArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }
// void PrintArray(int[,] inArray)
// {
//     for (int row = 0; row < inArray.GetLength(0); row++)
//     {
//         for (int column = 0; column < inArray.GetLength(1); column++)
//         {
//             Console.Write($"{inArray[row,column]} ");
//         }
//         Console.WriteLine();
//     }
// }
/***********   Тело кода *************/ 
// Console.Clear();
// Console.Write("Введите количество строк массива: ");
// int rows=Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int columns=Convert.ToInt32(Console.ReadLine());
// int[,] array = GetRandomArray(rows, columns, 0, 10);
// PrintArray(array);


/*     ДВУМЕРНЫЕ МАССИВЫ - Перезаполнение массива суммой позиций по строке и столбцу    */
// int[,] ModifyArray(int m, int n)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = i+j;
//         }
//     }
//     return result;
// }
// void PrintArray(int[,] inArray)
// {
//     for (int row = 0; row < inArray.GetLength(0); row++)
//     {
//         for (int column = 0; column < inArray.GetLength(1); column++)
//         {
//             Console.Write($"{inArray[row,column]} ");
//         }
//         Console.WriteLine();
//     }
// }
/***********   Тело кода *************/ 
// Console.Write("Введите количество строк массива: ");
// int rows=Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int columns=Convert.ToInt32(Console.ReadLine());
// int[,] array = ModifyArray(rows, columns);
// PrintArray(array);

/******** ДВУМЕРНЫЕ МАССИВЫ **********/
//Задача 49: Задайте двумерный массив. 
//Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
int[,] GetArray(int m, int n, int minValue, int maxValue) // создает двумерный массив
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            result[i, j] = new Random().Next(minValue, maxValue + 1);
    return result;
}
void ModifyArrayByMultiplyItself(int [,] array2) // создает двумерный массив
{
    for (int i = 0; i < array2.GetLength(0); i=i+2)
        for (int j = 0; j < array2.GetLength(1); j=j+2)
            array2[i,j]=array2[i,j]*array2[i,j];
}
void PrintArray(int[,] inArray) // вывводит двумерный массив
{
    for (int row = 0; row < inArray.GetLength(0); row++)
    {
        for (int column = 0; column < inArray.GetLength(1); column++)
            Console.Write($"{inArray[row,column]} ");
        Console.WriteLine();
    }
}
/***********   Тело кода *************/ 
Console.Write("Введите количество строк массива: ");
int rows=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns=Convert.ToInt32(Console.ReadLine());
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine("------------------------------------");
ModifyArrayByMultiplyItself(array);
PrintArray(array);




//Задача 51: Задайте двумерный массив. 
//Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// int[,] GetArray(int m, int n, int minValue, int maxValue) // создает двумерный массив
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//         for (int j = 0; j < n; j++)
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
//     return result; 
// }
// int GetSum (int [,] array) // создает двумерный массив
// {   
//     int sum=0;
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             if(i==j) sum=sum+array[i,j];
//     return sum;
// } 
// void PrintArray(int[,] inArray) // выводит двумерный массив
// {
//     for (int row = 0; row < inArray.GetLength(0); row++)
//     {
//         for (int column = 0; column < inArray.GetLength(1); column++)
//             Console.Write($"{inArray[row,column]} ");
//         Console.WriteLine();
//     }
// }
/***********   Тело кода *************/
// Console.Clear();
// Console.Write("Введите количество строк массива: ");
// int rows=Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int columns=Convert.ToInt32(Console.ReadLine());
// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);
// Console.WriteLine("Сумма элементов на диагонали="+GetSum(array));
