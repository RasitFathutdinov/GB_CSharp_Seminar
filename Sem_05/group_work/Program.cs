
/*
int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void ShowArray(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] myArray = CreateRandomArray(12, -9, 9);
ShowArray(myArray);

int sum_pos = 0;
int sum_neg = 0;

for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i] > 0)
        sum_pos += myArray[i];
    else
        sum_neg += myArray[i];
}

Console.WriteLine($"Сумма положительных: {sum_pos}. Сумма отрицательных: {sum_neg}");
*/





/*
int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void ShowArray(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] myArray = CreateRandomArray(12, -9, 9);
ShowArray(myArray);

int sum_pos = 0;
int sum_neg = 0;

for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i] > 0)
        sum_pos += myArray[i];
    else
        sum_neg += myArray[i];
}

Console.WriteLine($"Сумма положительных: {sum_pos}. Сумма отрицательных: {sum_neg}");
*/


//  Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
/*
    int[] CreateRandomArray(int size, int min, int max)
    {
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = new Random().Next(min, max + 1);
        }
        return array;
    }
    void ShowArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
    int[] myArray = CreateRandomArray(12, -9, 9);
    ShowArray(myArray);
    for (int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = myArray[i] *(-1);
    }
    ShowArray(myArray);
*/


// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
/*
    int[] CreateRandomArray(int size, int min, int max)
    {
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = new Random().Next(min, max + 1);
        }
        return array;
    }
    void ShowArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
    int[] myArray = CreateRandomArray(12, -9, 9);
    Console.Write("Введите число N: ");
    int N = Convert.ToInt32(Console.ReadLine());
    string str = "No";
    for (int i = 0; i < myArray.Length; i++)
    {
        if (myArray[i] == N)
        {
            str = "Yes";
            break;
        }
    }
    ShowArray(myArray);
    Console.WriteLine(str);
    // bool bool_arg= true
    // while (bool_arg && i<arr.Length)
    // {....
    //     i++;
    //     if (условие на выход)
    //     bool_arg = false;
    // }
*/


// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
/*
    int[] CreateRandomArray(int size, int min, int max)
    {
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = new Random().Next(min, max + 1);
        }
        return array;
    }
    void ShowArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
    int[] myArray = CreateRandomArray(5, 0, 500);
    ShowArray(myArray);
    int N = 0;
    for (int i = 0; i < myArray.Length; i++)
    {
        if (myArray[i] > 9 && myArray[i] < 100)
        {
            N = N + 1; //N++  //N +=1
        }
    }
    Console.WriteLine(N);
*/


// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

//**********************************************//
//  БЛОК МЕТОДОВ - ПОДПРОГРАММ - ИХ ОБЪЯВЛЕНИЕ  //
//**********************************************//
/*
Console.Clear();
// Метод 1 (функция, подпрограмма) 
double[] NewArrey(int size, int min, int max) //это объявили: название + что передаъём и что получаем
{   //это определили - что делаем в этом методе с входными и выходными данными
    Random rnd = new Random();  // создали объект, класса рандом (контейнер - набор инструментов)
    double[] arrey = new double[size];  // объявили пустой массив для size элементов, пока там ничего - мусор,
                                        //который был в ячейках памяти оперативно запаминающего устройства
    for (int i = 0; i < size; i++)      //это бегаем по кругу как в блок-схемах
    {       
        //возвращает вещественное число от 0 до 1
         //arrey[i] = rnd.NextDouble();//операция присвоения - заполняем пустые ячейки памяти нашим сшенерированным занчением.
                                    // теперь в выделенной памяти ОЗУ не мусор какой-то, а хранится наше число
         //масштабируем с интервала от 0 до 1 в интервал от min до max, т.е. сдвигаем и расширяем
         arrey[i] = rnd.NextDouble()*(min-max)+min;
    }
    
   return arrey; //возвращаем массив
}
// Метод 2 (функция, подпрограмма) 
void ShowArray(double[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        Console.Write($"{mass[i]:f2}, ");
        //Console.Write($"{mass[i]:0.00}, ");
        //можно и так:
        //Console.Write(" -> {0:0.00}", mass[i]); //2 знака после запятой
        //Console.Write(" -> {0:f2}", mass[i]); //2 знака после запятой
        //Console.Write(" -> {0:0.0000}", mass[i]); //4 знака после запятой
        //Console.Write(" -> {0:f4}", mass[i]); //4 знака после запятой
    }
    //можно переход на новую строку Console.Write("\n"); или Console.WriteLine();
    Console.Write("\n");
}

//  БЛОК МЕТОДОВ - ПОДПРОГРАММ - ИХ ОБЪЯВЛЕНИЕ  //
// ! В БУДУЩЕМ В C# ЭТО ГЛАВНЫЙ ПУСТОЙ МЕТОД VOID MAIN()//
//здесь применяем наши ранее объявленные (дали имя и входы-выходы) и определённые (написали что внутри то метода делать)
double[] myMass = NewArrey(10, 1, 5); //вызов метода 1
ShowArray(myMass);                    //вызов метода 2
*/

// ОСНОВНОЙ КОД - в книгах и интернете метод static void main()
Console.Write("Введите десятичное число и нажмите enter: ");
int number = Convert.ToInt32(Console.ReadLine());
string binary = "";
//Деление столбиком - сбор 0 и 1 - это в метод 3
while (number >= 1)
{
    binary = Convert.ToString(number % 2) + binary;
    number /=  2; 
}
//Это вывод - результата деления столбиком
Console.Write($"{number} -> " + binary);
