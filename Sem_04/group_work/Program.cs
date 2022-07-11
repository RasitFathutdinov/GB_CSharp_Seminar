// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36
// Console.Write("Введите число А: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int sum = 0;

// for (int i=1; i <= number; i++)
// {
//     sum +=  i;
// }
// Console.WriteLine($"Сумма чисел от 1 до {number}: {sum}");

    // // Реализация через while
    // int i = 1;
    // while (i <= number)
    // {
    //     sum +=  i;
    //     i++;
    // }

// int SumOfNumbers(int num)
// {
//     int sum = 0;
//     for (int i=1; i <= num; i++)
//     {     sum +=  i;      }
//     return sum;
// }
// Console.Write("Введите число А: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int sum = SumOfNumbers(number);
// Console.WriteLine($"Сумма чисел от 1 до {number}: {sum}");

// int[] GenerateRandomArray(int N, int start, int end)
// {
//     int[] RandomArray = new int[N];
//     for (int i=0; i<N;i++)
//     {
//         RandomArray[i] = new Random().Next(start, end+1);

//     }
// }

Console.Write("Введите число: ");
string num_str = Console.ReadLine()!;
int num_len = num_str.Length;

if (num_str[0] =='-' && num_len > 3) 
{
    Console.WriteLine(num_str[3]);
}
else if(num_str[0] !='-' && num_len > 4) 
{
    Console.WriteLine(num_str[2]);
}
else
{
    Console.WriteLine("Нет третьей цифры");
}

