﻿// ############################################################################
// Реализация через строки 
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

//Метод № 1 - Подпрограмма для ввода числа с проверкой соответсвия условию задачи
string inputNumder()
{
    string str = "";
    //2 попытки ввести пользователю, что правильно ввести целое трёхзначное натуральное число
    for (int i=0; i<3; i++)
    {
        Console.Write("Введите натуральное трёхзначное число: ");
        str = Console.ReadLine()!;
        //проверка 3 ли символа в числе и нет ли знака минуса?
        //да - идём далее; нет - новая попытка ввода
        if (str.Length == 3 && str[0] != '-')
        {   
            // соответсвие типу данных int не проверяю (иные символы кроме 0-9)
            break;
        }
        Console.WriteLine("Нужно было ввести целое трёхзначное число!");
        Console.WriteLine("Осталось попыток ввода: " +(2-i));
        Console.WriteLine();
    }
    return str;
}
//Метод № 2 - Подпрограмма для ввода числа # 2
char serchSecondPosInNumber(string str)
{
    return str[1];
}
//Программа с вызовом методов (подпрограмм)
string num_str = inputNumder();
Console.WriteLine("У числа " + num_str + " вторая цифра " + serchSecondPosInNumber(num_str));




/* 
// ############################################################################
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

    Console.Write("Введите число (желательное трёхзначное): ");
    int number  = Convert.ToInt32(Console.ReadLine());
    //проверка 3 ли символа в числе, т.е. от 100 до 999 или -999 до -100?
    if ((99<number && number<1000) || (-99>number && number>-1000))
    {   
        int pos_3 = Math.Abs(number % 10);
        Console.WriteLine(number + " -> " + pos_3);
    }
    else
    {
        Console.WriteLine(number + " -> " + "третьей цифры нет");
    }
*/

/*
// ############################################################################
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.Write("Введите день недели: ");
//с типом char можно, но сложнее, м.б. нужна обработка исключений на случай вода более 1 символа и т.д.
int day = Convert.ToInt32(Console.ReadLine());
switch (day)
{
    case 1:
        Console.WriteLine(day + " -> нет, понедельник рабочий день"); 
        break; 
    case 2:
        Console.WriteLine(day + " -> нет, вторник рабочий день");
        break;
    case 3:
        Console.WriteLine(day + " -> нет, среда рабочий день");
        break;
    case 4:
        Console.WriteLine(day + " -> нет, четверг рабочий день");
        break;
    case 5:
        Console.WriteLine(day + " -> нет, пятница рабочий день");
        break;
    case 6:
        Console.WriteLine(day + " -> да, суббота выходной");
        break;
    case 7:
        Console.WriteLine(day + " -> да, воскресенье выходной");
        break;
    default:
        Console.WriteLine(day + " -> в календаре такого нет!");
        break;
}
*/

