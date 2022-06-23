// ЗАДАЧА 1
    // Console.Write("Введите целое число:");
    // int number= Convert.ToInt32(Console.ReadLine());
    // int q = number*number;
    // Console.WriteLine(number + "^2  -> " + q);

// ЗАДАЧА 2 - Мой вариант
    // Console.Write("Введите целое число № 1: ");
    // int number1 = Convert.ToInt32(Console.ReadLine());
    // Console.Write("Введите целое число № 2: ");
    // int number2 = Convert.ToInt32(Console.ReadLine());
    // if (number1 == number2*number2)
    //     Console.WriteLine("a = " + number1 + ", b = " + number2 + " -> " + "да");
    // else   
    //     Console.WriteLine("a = " + number1 + ", b = " + number2 + " -> " + "нет");

// ЗАДАЧА 2 - вариант Елены
//  Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// вводим первое число
    // Console.Write("Input first number: ");
    // // сохраняем значение в переменную
    // int number_1 = Convert.ToInt32(Console.ReadLine());
    // // вводим второе число и сохраняем значение в переменную
    // Console.Write("Input second number: ");
    // int number_2 = Convert.ToInt32(Console.ReadLine());
    // // объявляю переменную q, в которую сохраняю квадрат второго введенного числа
    // int q = number_2 * number_2;
    // // сравниваем значение первой переменной со значением переменной q
    // if (number_1 == q)
    //     Console.WriteLine("a = " + number_1 + ", b = " + number_2 + " ->  yes");
    // else
    //     Console.WriteLine("a = " + number_1 + ", b = " + number_2 + " -> no");


// ЗАДАЧА 3
Console.Write("Введите день недели (от 1 до 7): ");
int day = Convert.ToInt32(Console.ReadLine());
switch(day)
{    
    case 1:
        Console.WriteLine("Понедельник");
        break;
    case 2:
        Console.WriteLine("Вторник");
        break;
    case 3:
        Console.WriteLine("Среда");
        break;
    case 4:
        Console.WriteLine("Четверг");
        break;
    case 5:
        Console.WriteLine("Пятница");
        break;
    case 6:
        Console.WriteLine("Суббота");
        break;
    case 7:
        Console.WriteLine("Воскресенье");
        break;
    default:
        Console.WriteLine("Вы ввели целое число не из диапазона [1; 7]");
        break;
}