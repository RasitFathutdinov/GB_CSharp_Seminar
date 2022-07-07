
// Random rnd = new Random();
// Thread.Sleep(200);
// for (int ctr = 1; ctr <= 10; ctr++) {
//    Console.WriteLine("{0,3}    ", rnd.Next(10, 1000001));
// }
// Random rnd = new Random();
// int lowerBound = -500;
// int upperBound = 500;
// for (int ctr = 0; ctr < 10; ctr++) 
// {
//    Double value = rnd.NextDouble() * (upperBound - lowerBound) + lowerBound;
//    Console.WriteLine("{0,10}   ", Convert.ToInt32(value));
// }

//вывести случайные числа из диапазона от 0 до 1000
//делим отрезок пополам (1000-0)/2 = 500.
//так как Rand работает по нормальному закону распределения, то к серединеотрезка больше выпдов чисел
//потом перемасштабируем под наш отрезок, отняв -500 (т.е. минимальную гранницу от симметричного интервала) 
// Random rnd = new Random();
// int lowerBound = -500;
// int upperBound = 500;
// for (int ctr = 0; ctr < 20; ctr++) 
// {
//    int value = rnd.Next(lowerBound,upperBound);
//    Console.WriteLine("{0,10}   ", value);
// }

/*
    //Задача № 1
    int[] Input()
    {
        int[] Array = new int[2];
        Console.WriteLine("Введите координату Х");
        Array[0] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите координату У");
        Array[1]  = Convert.ToInt32(Console.ReadLine());
        return Array;
    }
    int[] arr_xy = Input();
    while (arr_xy[0] == 0 || arr_xy[1] == 0)
    {
        Console.WriteLine("Точка находится на оси");
        arr_xy = Input();
    }
    if (arr_xy[0] > 0 && arr_xy[1] > 0)
        Console.WriteLine("Точка находится в первой четверти");
    else if (arr_xy[0] < 0 && arr_xy[1] < 0)
        Console.WriteLine("Точка находится в третьей четверти");
    else if (arr_xy[1] < 0 && arr_xy[0] > 0)
        Console.WriteLine("Точка находится в четвертой четверти");
    else
        Console.WriteLine("Точка находится во второй четверти");
*/

//Задача № 18
/*Console.WriteLine("Введите номер четверти: ");
int field = Convert.ToInt32(Console.ReadLine());

while (field>4 || field<1)
{
    Console.WriteLine("Введите номер четверти (это число от 1 до 4): ");
    field = Convert.ToInt32(Console.ReadLine());
}
if (field == 1)
    Console.WriteLine("Точка находится в первой четверти: х > 0 и у > 0");
else if (field == 2)
    Console.WriteLine("Точка находится в второй четверти: х < 0 и у > 0");
else if (field == 3)
    Console.WriteLine("Точка находится в третьей четверти: х < 0 и у < 0");
else
    Console.WriteLine("Точка находится во четвертой четверти: х > 0 и у < 0");
*/

/*
// Другой вариант реализации без цикличесого перевода значения
Console.WriteLine("Введите номер четверти: ");
int field = Convert.ToInt32(Console.ReadLine());
switch (field)
{
    case 1:
        Console.WriteLine("Точка находится в первой четверти: х > 0 и у > 0"); 
        break; 
    case 2:
        Console.WriteLine("Точка находится в второй четверти: х < 0 и у > 0");break;
        break;
    case 3:
        Console.WriteLine("Точка находится в третьей четверти: х < 0 и у < 0");break;
    case 4:
        Console.WriteLine("Точка находится во четвертой четверти: х > 0 и у < 0");break;
    default:
        Console.WriteLine("Вввели неверное число! Перезапустите программу");
        break;
}
*/

//Задача №21
//Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 2D пространстве
//A (3,6); B (2,1) -> 5,09 
//A (7,-5); B (1,-1) -> 7,21

//Метод - подпрограмма 1: ввод координаты, т.е. х и у
int[] Input()
{
    //Инициализация пустого массива из 2-х элементов
    int[] Array = new int[2];
    Console.Write("Введите координату x: ");
        //Присвоение значение 0-му элемкнту массива (точке х)
        Array[0] = Convert.ToInt32(Console.ReadLine()); 
    Console.Write("Введите координату y: ");
        //Присвоение значение 1-му элемкнту массива (точке у)
        Array[1]  = Convert.ToInt32(Console.ReadLine());
    //возвращаем массив из 2-х точек (координату в двухмерном пространстве)
    return Array;
}
//Метод - подпрограмма 2: вычисляем точку С 
int[] calc_point_C(int[] arr1, int[] arr2)
{
    int[] arr_vector = new int[2];
    arr_vector[0] = arr2[0]-arr1[0];
    arr_vector[1] = arr2[1]-arr1[1];
    return arr_vector;
}
//Метод - подпрограмма 3: вывод точки в консоль
void print_point(int[] arr1)
{
    Console.Write('['+Convert.ToString(arr1[0]) +';'+ Convert.ToString(arr1[1])+']');
}

//Основное тело программы
Console.WriteLine("Введите координату начала отрезка");
    int[] arr_point_A = Input();
Console.WriteLine("Введите координату конца отрезка");
    int[] arr_point_B = Input();
//Координата точки С: демонстрация передачи и возвращения массива в метод
int[] arr_point_C = calc_point_C(arr_point_A,arr_point_B);
//длина отрезка, заданная двумя коорбинатами (вычисляем как длину вектора)
double vector_len = Math.Sqrt(arr_point_C[0]*arr_point_C[0] + arr_point_C[1]*arr_point_C[1]);
//Вывод результата вычислений - длины отрезка
Console.Write("Длина отрезка по точкам ");
    print_point(arr_point_A); //вызов подпрограммы 3
Console.Write(" и ");
    print_point(arr_point_B); //вызов подпрограммы 3
Console.Write(" -> " + Math.Round(vector_len,2));
    //Добавляем переход на новую строку в консоли
    Console.WriteLine();


