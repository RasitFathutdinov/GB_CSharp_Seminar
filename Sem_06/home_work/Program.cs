// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
    // /*****************  ОБЪЯВЛЕНИЕ МЕТОДОВ  ***********************/
    // /* Метод для создания массива размера size вводом данных пользователем через консоль */
    // int[] InputArray(int size)              
    // {                         
    //     int[] array = new int[size];   // объявляем массив размера size( количество элементов = size)
    //     for (uint i = 0; i < size; i++)     
    //     {
    //         Console.Write("Введите {0}-й элемент массива: ", i);
    //         array[i] = Convert.ToInt32(Console.ReadLine());
    //     }                                                       
    //     return array; 
    // }
    // /* Метод для вывода элементов м-ассива в консоль для вывода на экрана передаём массив "int[] " */
    // void ShowArray(int[] array)  
    // {                            
    //         uint arrSize = (uint)array.Length; 
    //     for (uint i = 0; i < arrSize; i++)
    //     {
    //         if (i < arrSize-1) {   Console.Write(array[i]+", \t");     }
    //         else               {   Console.Write(array[i]+" ");      }
    //     }
    // }
    // /* Поиск количества элементов массива больше "0" */
    // int CountOfPositiveElements(int[] array) 
    // {                                        
    //     int result = 0;
    //     uint arrSize = (uint)array.Length;
    //     for (uint i = 0; i < arrSize; i++)
    //         if(array[i]>0)  result++;
    //     return result;
    // }
    // /************  ВЫЗОВ РАНЕЕ ОБЪЯВЛЕННЫХ МЕТОДОВ ~ VOID MAIN  ***************/
    // Console.Write("\nВведите размер массива и нажмите enter: "); 
    // int coutOfNumbers = Convert.ToInt32(Console.ReadLine());
    // int[] arrayNumbers = InputArray(coutOfNumbers);             // объявление массива ч/з перегруженный оператор присваивания (конструктор)
    // Console.WriteLine("\nКоличество элементов массива больше нуля:");
    // ShowArray(arrayNumbers);
    // Console.WriteLine(" -> " + CountOfPositiveElements(arrayNumbers) + "\n");



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
    // /******************  ОБЪЯВЛЕНИЕ МЕТОДОВ  ***********************/
    /* метод для ввода уравнения прямой */
    double[] CurveInputData(int curveNumber) 
    {
        Console.Write("\tУравнение прямой № {0}: ", curveNumber); 
        double [] result = new double[2];  // 0 - k, 1 - b
        Console.Write("\nВведите коэффициент k{0} и нажмите enter: ", curveNumber); 
            result[0] = Convert.ToDouble(Console.ReadLine());   // угловой коэффициент для оси Ох
        Console.Write("Введите коэффициент b{0} и нажмите enter: ", curveNumber);    
            result[1] = Convert.ToDouble(Console.ReadLine());   // смещение по оси Оу
        return result;
    }
    /* метод для вывода уравнения прямой */
    void CurveOutputData(double[] curve, int curveNumber) 
    {
        Console.Write("Уравнение прямой № {0}: ", curveNumber);
        Console.Write("\ty = {0} * x + {1}\n", curve[0], curve[1]); // 0 - k, 1 - b
    }
    /* метод для поиска пересечения 2х прямых */
    void CurvesCrossPointFind(double[] curveFst, double[] curveSnd)
    {
        if(curveFst[0] == curveSnd[0] && curveFst[1] == curveSnd[1])
            Console.WriteLine("Уравнения, описывающие прямые, совпадают. \n Поэтому прямые не пересекаются, а совпадают");
        else if(curveFst[0] == curveSnd[0] && curveFst[1] != curveSnd[1])
        {
            Console.Write("Прямые парраллельны: ");
            if (curveFst[0] > curveSnd[0]) 
                Console.WriteLine("прямая № 1 лежит на плоскости хОу выше прямой 2");
            else
                Console.WriteLine("прямая № 1 лежит на плоскости хОу ниже прямой 2");
        }
        else
        {
            double[] pointOfCross = new double[2]; //точка пересечения: 0 - х; 1 - у.
            /* x = (b2-b1)/(k1-k2) */
            pointOfCross[0] = (curveSnd[1]-curveFst[1])/(curveFst[0]-curveSnd[0]);
            /* y = k1*x + b1 */
            pointOfCross[1] = curveFst[0]*pointOfCross[0] + curveFst[1];
            Console.WriteLine("Точка пересечения: [{0:f4};{1:f4}]", pointOfCross[0], pointOfCross[1]);
        }
        Console.WriteLine();
    }


    /**********  ВЫЗОВ РАНЕЕ ОБЪЯВЛЕННЫХ МЕТОДОВ ~ VOID MAIN  *****************/
    Console.WriteLine();
    double [] curveFstData = CurveInputData(1);
    double [] curveSndData = CurveInputData(2);
    Console.WriteLine("\nВведены уравнения двух прямых: ");
    CurveOutputData(curveFstData, 1);
    CurveOutputData(curveSndData, 2);
    Console.WriteLine("\nРезультат поиска пересечения двух прямых:");
    CurvesCrossPointFind(curveFstData, curveSndData);

    // Печать системы координат
    int CoordDimange = 20;
    for(int i = 0; i < CoordDimange; i++)
    {
        if (i == CoordDimange/2)
        {
            for (int j = 0; j < CoordDimange+1; j++)
                Console.Write("* ");
        }
        else
        {
            for (int j = 0; j < CoordDimange; j++)
                if(j == CoordDimange/2)
                    Console.Write("* ");
                else
                    Console.Write("  ");
        }
        Console.WriteLine("");
    }

    //   /* Вариант реализации без методов */
    //   /**********  ВЫЗОВ РАНЕЕ ОБЪЯВЛЕННЫХ МЕТОДОВ ~ VOID MAIN  *****************/
    //     Console.Write("\n\tУравнение прямой № 1: "); 
    //     double [] curveFstData = new double[2];
    //     Console.Write("\n Введите коэффициент k1 и нажмите enter: "); // угловой коэффициент для оси Ох
    //         curveFstData[0] = Convert.ToDouble(Console.ReadLine());
    //     Console.Write("Введите коэффициент b1 и нажмите enter: ");    // смещение по оси Оу
    //         curveFstData[1] = Convert.ToDouble(Console.ReadLine());

    //     Console.Write("\n\tУравнение прямой № 2: "); 
    //     double [] curveSndData = new double[2];
    //     Console.Write("\nВведите коэффициент k2 и нажмите enter: "); // угловой коэффициент для оси Ох
    //         curveSndData[0] = Convert.ToDouble(Console.ReadLine());
    //     Console.Write(" Введите коэффициент b2 и нажмите enter: ");   // смещение по оси Оу
    //         curveSndData[1] = Convert.ToDouble(Console.ReadLine());
        
    //     Console.WriteLine("\nРезультат поиска пересечения двух прямых:");
    //     if(curveFstData[0] == curveSndData[0] && curveFstData[1] == curveSndData[1])
    //         Console.WriteLine("Уравнения, описывающие прямые, совпадают. \n Поэтому прямые не пересекаются, а совпадают");
    //     else if(curveFstData[0] == curveSndData[0] && curveFstData[1] != curveSndData[1])
    //     {
    //         Console.WriteLine("Прямые парраллельны.");
    //         if (curveFstData[0] > curveSndData[0]) 
    //             Console.WriteLine("Прямая № 1 лежит на плоскости хОу выше прямой 2");
    //         else
    //             Console.WriteLine("Прямая № 1 лежит на плоскости хОу ниже прямой 2");
    //     }
    //     else
    //     {
    //         double[] pointOfCross = new double[2]; //точка пересечения: 0 - х; 1 - у.
    //         /* x = (b2-b1)/(k1-k2) */
    //         pointOfCross[0] = (curveSndData[1]-curveFstData[1])/(curveFstData[0]-curveSndData[0]);
    //         /* y = k1*x + b1 */
    //         pointOfCross[1] = curveFstData[0]*pointOfCross[0] + curveFstData[1];
    //         Console.WriteLine("Точка пересечения: [{0:f4};{1:f4}]", pointOfCross[0], pointOfCross[1]);
    //         Console.WriteLine();
    //     }



    // /* Печать системы координат */
    // int CoordDimange = 20;
    // for(int i = 0; i < CoordDimange; i++)
    // {
    //     if (i == CoordDimange/2)
    //     {
    //         for (int j = 0; j < CoordDimange+1; j++)
    //             Console.Write("* ");
    //     }
    //     else
    //     {
    //         for (int j = 0; j < CoordDimange; j++)
    //             if(j == CoordDimange/2)
    //                 Console.Write("* ");
    //             else
    //                 Console.Write("  ");
    //     }
    //     Console.WriteLine("");
    // }

    // /* Парралельный перенос системы координат + печать кривых точками */
