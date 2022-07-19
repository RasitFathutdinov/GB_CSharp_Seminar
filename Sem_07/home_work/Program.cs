// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// (дублирует задачу № 38)
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
    // /*****************  ОБЪЯВЛЕНИЕ МЕТОДОВ  ***********************/
    // /* Метод для создания массива размера size из случайных чисел из диапазона [start;end] */
    // double[,] GenerateRandomMatrix(int countRows, int countColumns, int start, int end)  
    // {
    //     double[,] result = new double[countRows, countColumns];  // объявляем массив размера mхn, т.е. выделение памяти для mхn переменных
    //     for (uint i = 0; i < countRows; i++)           
    //         for (uint j = 0; j < countColumns; j++)                         // Генерируем число из диапазона [start;end] 
    //            result[i,j] = new Random().NextDouble()*(end-start) + start; // c масштабирванием и записываем его в [i,j]-й элемент массива                                                                                                                        
    //     return result;
    // }
    // /* Метод для вывода элементов массива в консоль */
    // void ShowMatrix(double[,] matrix)  
    // {                             
    //     uint rows = (uint)matrix.GetLength(0); 
    //     uint columns =  (uint)matrix.GetLength(1); 
    //     for (uint i = 0; i < rows; i++)
    //     {
    //         for (uint j = 0; j < columns; j++) 
    //            Console.Write("{0:f2}\t", matrix[i, j]);  
    //         Console.WriteLine();
    //     }
    // }
    // /**********  ВЫЗОВ РАНЕЕ ОБЪЯВЛЕННЫХ МЕТОДОВ ~ VOID MAIN  *****************/
    // Console.WriteLine("\n-------"); 
    // Console.Write("Введите количество (m) строк в матрице и нажмите enter, m = "); 
    //     int m = Convert.ToInt32(Console.ReadLine()); 
    // Console.Write("Введите количество (m) строк в матрице и нажмите enter, m = "); 
    //     int n = Convert.ToInt32(Console.ReadLine()); 
    // Console.WriteLine("Введите первое число случайно генерируемого диапазона и нажмите enter:"); 
    //     int min = Convert.ToInt32(Console.ReadLine()); 
    // Console.WriteLine("Введите последнее число случайно генерируемого диапазона и нажмите enter:"); 
    //     int max = Convert.ToInt32(Console.ReadLine());  
    // double[,] randomMatrix = GenerateRandomMatrix(m, n, min, max); //перегруженный оператор присваивания с вызовом конструктора
    // Console.WriteLine("Сгенерирована матрица: ");
    // ShowMatrix(randomMatrix); 
    // Console.WriteLine("-------\n"); 


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
    // /*****************  ОБЪЯВЛЕНИЕ МЕТОДОВ  ***********************/
    // /* Метод для создания массива размера size из случайных чисел из диапазона [start;end] */
    // int[,] GenerateRandomMatrix(int countRows, int countColumns, int start, int end)  
    // {
    //     int[,] result = new int[countRows, countColumns];  // объявляем массив размера mхn, т.е. выделение памяти для mхn переменных
    //     for (uint i = 0; i < countRows; i++)           
    //         for (uint j = 0; j < countColumns; j++)                         
    //            result[i,j] = new Random().Next(start, end+1); // генерируем число из диапазона [start;end] 
    //     return result;
    // }
    // /* Метод для вывода элементов массива в консоль */
    // void ShowMatrix(int[,] matrix)  
    // {                             
    //     uint rows = (uint)matrix.GetLength(0); 
    //     uint columns =  (uint)matrix.GetLength(1); 
    //     for (uint i = 0; i < columns; i++)
    //     {
    //         if(i==0) Console.Write("  {0}\t", i+1);
    //         else     Console.Write("{0}\t", i+1);
    //     }
    //      Console.WriteLine();
    //     for (uint i = 0; i < columns; i++)
    //     {
    //         if(i==0) Console.Write("  __\t");
    //         else     Console.Write("__\t");
    //     }
    //     Console.WriteLine();
    //     for (uint i = 0; i < rows; i++)
    //     {
    //         Console.Write("{0}| ", i+1);
    //         for (uint j = 0; j < columns; j++) 
    //            Console.Write("{0}\t", matrix[i, j]);  
    //         Console.WriteLine();
    //     }
    // }
    // /* Метод для нахождения элемента по индексам (есть либо нет) */
    // void PrintElementByPosition(int[,] matrix, int indexByRow, int indexByColumn)  
    // {                             
    //     uint rows = (uint)matrix.GetLength(0); 
    //     uint columns =  (uint)matrix.GetLength(1); 

    //     if (indexByRow < 0 || indexByColumn < 0)
    //         Console.Write("Некорректные координаты позиции элемента: a({0},{1})\n", indexByRow+1, indexByColumn+1);
    //     else if (indexByRow > rows || indexByColumn > columns)
    //         Console.Write("элемента a({0},{1}) нет!\n", indexByRow+1, indexByColumn+1);
    //     else
    //         Console.Write("элемент a({0},{1}) = {2}\n", indexByRow+1, 
    //                                                     indexByColumn+1,
    //                                                     matrix[indexByRow,indexByColumn]);
    // }
    // /**********  ВЫЗОВ РАНЕЕ ОБЪЯВЛЕННЫХ МЕТОДОВ ~ VOID MAIN  *****************/
    // /* Ввод данных */
    // Console.WriteLine("\n-------"); 
    // Console.Write("Введите количество (m) строк в матрице и нажмите enter, m = "); 
    //     int m = Convert.ToInt32(Console.ReadLine()); 
    // Console.Write("Введите количество (n) столбцов в матрице и нажмите enter, n = "); 
    //     int n = Convert.ToInt32(Console.ReadLine()); 
    // Console.WriteLine("Введите первое число случайно генерируемого диапазона и нажмите enter:"); 
    //     int min = Convert.ToInt32(Console.ReadLine()); 
    // Console.WriteLine("Введите последнее число случайно генерируемого диапазона и нажмите enter:"); 
    //     int max = Convert.ToInt32(Console.ReadLine());  
    // /* Создание матрицы */
    // int[,] randomMatrix = GenerateRandomMatrix(m, n, min, max); //перегруженный оператор присваивания с вызовом конструктора
    // Console.WriteLine("Сгенерирована матрица: ");
    // ShowMatrix(randomMatrix); 
    // /* Выполнение условий задачи - вывод элемента по ПОЗИЦИИ */
    // Console.Write("\nПоиск элемента a(i,j) двумерного массива по позиции - нумерация начинается с 1"); 
    // Console.Write("\n Введите позицию по строке и нажмите enter, i = ");
    //     int positionRow = Convert.ToInt32(Console.ReadLine()); 
    // Console.Write(" Введите позицию по столбцу и нажмите enter, j = ");
    //     int positionColumn = Convert.ToInt32(Console.ReadLine()); 
    // Console.Write("Результат: ");
    // PrintElementByPosition(randomMatrix, positionRow-1, positionColumn-1);
    // Console.WriteLine("-------\n"); 


// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
    /*****************  ОБЪЯВЛЕНИЕ МЕТОДОВ  ***********************/
    /* Важно: здесь интерпритация работы с классом Matrix, п.э. векторов нет
    /* Метод для создания массива размера size из случайных чисел из диапазона [start;end] */
    int[,] GenerateRandomMatrix(int countRows, int countColumns, int start, int end)  
    {
        int[,] result = new int[countRows, countColumns];  // объявляем массив размера mхn, т.е. выделение памяти для mхn переменных
        for (uint i = 0; i < countRows; i++)           
            for (uint j = 0; j < countColumns; j++)                         
               result[i,j] = new Random().Next(start, end+1); // генерируем число из диапазона [start;end] 
        return result;
    }
    /* Метод для вывода элементов массива в консоль */
    void ShowMatrix(int[,] matrix)  
    {                             
        uint rows = (uint)matrix.GetLength(0); 
        uint columns =  (uint)matrix.GetLength(1); 
        for (uint i = 0; i < columns; i++)
        {
            if(i==0) Console.Write("  {0}\t", i+1);
            else     Console.Write("{0}\t", i+1);
        }
         Console.WriteLine();
        for (uint i = 0; i < columns; i++)
        {
            if(i==0) Console.Write("  __\t");
            else     Console.Write("__\t");
        }
        Console.WriteLine();
        for (uint i = 0; i < rows; i++)
        {
            Console.Write("{0}| ", i+1);
            for (uint j = 0; j < columns; j++) 
               Console.Write("{0}\t", matrix[i, j]);  
            Console.WriteLine();
        }
    }
    /* Перегрузка метода вывода матрицы для типа double */
    void ShowMatrixDoubleType(double[,] matrix)  
    {                             
        uint rows = (uint)matrix.GetLength(0); 
        uint columns =  (uint)matrix.GetLength(1); 
        for (uint i = 0; i < columns; i++)
        {
            if(i==0) Console.Write("  {0}\t", i+1);
            else     Console.Write("{0}\t", i+1);
        }
         Console.WriteLine();
        for (uint i = 0; i < columns; i++)
        {
            if(i==0) Console.Write("  __\t");
            else     Console.Write("__\t");
        }
        Console.WriteLine();
        for (uint i = 0; i < rows; i++)
        {
            Console.Write("{0}| ", i+1);
            for (uint j = 0; j < columns; j++) 
               Console.Write("{0:f1}\t", matrix[i, j]);  
            Console.WriteLine();
        }
    }
    /* Метод для нахождения стредних значений по столбцам */
    double[,] AverrangeByMatrixColumn(int[,] matrix)  
    {                             
        uint countRows = (uint)matrix.GetLength(0); 
        uint countColumns =  (uint)matrix.GetLength(1); 
        double[,] result = new double[1,countColumns];  // объявляем массив размера columns, для хранения среднего по столбцу
        for (uint j = 0; j < countColumns; j++)
        {
            for (uint i = 0; i < countRows; i++) 
                if (i == 0) // чтоб не обнулять массив и не вводить врем. переменную
                    result[0,j] = matrix[i, j]; 
                else
                    result[0,j] += matrix[i, j];
            result[0,j] = result[0,j]/(double)countRows; // собрали все по столбцу и разделили на количество 
        }                                                // типа double, иначе округлит до int
        return result;
    }
    /**********  ВЫЗОВ РАНЕЕ ОБЪЯВЛЕННЫХ МЕТОДОВ ~ VOID MAIN  *****************/
    /* Ввод данных */
    Console.WriteLine("\n-------"); 
    Console.Write("Введите количество (m) строк в матрице и нажмите enter, m = "); 
        int m = Convert.ToInt32(Console.ReadLine()); 
    Console.Write("Введите количество (n) столбцов в матрице и нажмите enter, n = "); 
        int n = Convert.ToInt32(Console.ReadLine()); 
    Console.WriteLine("Введите первое число случайно генерируемого диапазона и нажмите enter:"); 
        int min = Convert.ToInt32(Console.ReadLine()); 
    Console.WriteLine("Введите последнее число случайно генерируемого диапазона и нажмите enter:"); 
        int max = Convert.ToInt32(Console.ReadLine());  
    /* Создание матрицы */
    int[,] randomMatrix = GenerateRandomMatrix(m, n, min, max); //перегруженный оператор присваивания с вызовом конструктора
    Console.WriteLine("\nСгенерирована матрица: ");
    ShowMatrix(randomMatrix); 
    /* Выполнение условий задачи - сренднее значение матрицы по столбцам */
    Console.WriteLine("\n****** Результат ******");
    Console.WriteLine("Среднее значение матрицы по столбцам:"); 
    double[,] averrangeMatrix = AverrangeByMatrixColumn(randomMatrix); 
    ShowMatrixDoubleType(averrangeMatrix); 
    Console.WriteLine("-------\n"); 




