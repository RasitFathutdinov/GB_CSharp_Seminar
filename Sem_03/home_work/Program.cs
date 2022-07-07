/*
    // Задача 19
    // Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
    // 14212 -> нет
    // 12821 -> да
    // 23432 -> да

    //Объявление и определение метода 
    bool polindrom (string str)
    {
        //в циклах буду сравнивать по символу слева и справа от середины.
        //при первом же не совпадении - результат не полиндром
        bool result = true;
        int str_len = str.Length;
        
        if(str_len == 1)
        {
            //1 символ поумолчанию полиндром.
            return result;
        }
        else if (str_len % 2 == 1)
        {
            //если нечётное количество сиволов, то есть явная середина
            int middle = str_len/2,
                i = 1; //!1 из-за нечётного количеста символов
            //идём влево и вправо от середины с шагом 1
            while (result && i<middle)
            {
                if(str[middle-i] != str[middle+i])
                {      
                    result = false;  
                }
                i++; 
            }
        }
        else
        {
            //если чётное количество сиволов, то нет явной середины
            int middle = str_len/2,
                i = 0; //!0 из-за чётного количеста символов
            //идём слева и справа к середине с шагом 1
            while (result && i<middle)
            {
                if(str[i] != str[(str_len-1)-i])
                {   result = false;  }
                i++;
            }
        }

        return result;
    }

    //Основная часть программы 
        Console.Write("Введите натуральное пятизначное число : ");
        string num_str = Console.ReadLine();
        //метод на сравнение палиндрома универсальный, но не противоречим условию задачи, п.э. "5"
        if (num_str.Length < 5)
        {
            Console.Write("Введено число, отличное от пятизначного\n Программа завершена...\n");
        }
        else
        {
            //проверка на палиндром через метод
            if (polindrom(num_str))
            {
                Console.Write("Число " + num_str + " -> палиндром\n"); 
            }
            else
            {
            Console.Write("Число " + num_str + " -> не является палиндромом\n"); 
            }
        }
*/


/*
    // Задача 21
    // Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
    // A (3,6,8); B (2,1,-7), -> 15.84
    // A (7,-5, 0); B (1,-1,9) -> 11.53
    //Метод 1 - Унифицированный метод ввода координаты
    int[] input_point(int dimension)
    {
        int[] point_3d = new int[dimension];
        for (int i = 0; i<dimension; i++)
        {
            //обработка исключений на преобразоание типов в случае ввода букв не рассматривается
            Console.Write($"Введите у точки координату # {i+1} и нажмите enter: ");
            point_3d[i]=Convert.ToInt32(Console.ReadLine());
        }
        return point_3d;
    }
    //Метод 2 - Унифицированный расчёт длины вектора
    double vector_length(int[] arr1, int[] arr2)
    {
        double distance = 0;
        // по хорошему, здесь должна быть проверка, что массивы одного размера
        // и генерация исключения, что массивы разных размеров
        int point_coord_num = arr1.Length;
        for (int i = 0; i<point_coord_num; i++)
        {
            distance += Math.Pow((arr1[i]-arr2[i]),2);
        }
        return Math.Sqrt(distance);
    }
    // Метод 3 - Метод для вывода точки на экран в таком виде A (7,-5, 0)
    void output_point(int[] arr, char ch_value)
    {
        int point_coord_num = arr.Length;
        Console.Write(ch_value + "(");
        //по умолчанию у координатыне менее 2-х значений
        for (int i = 0; i<point_coord_num-1; i++)
        {
            Console.Write(arr[i] + ",");
        }
        Console.Write(arr[point_coord_num-1] + ")");
    }

    //Основная программа
    // Размерность пространства (можно поменять на 2 и будет работать)
    int point_coord_count = 3; 
    //Ввод координаты n-мерного пространства;
    Console.Write("\nВедите координаты точки А:\n");
        int[] point_1 = input_point(point_coord_count);
    Console.Write("Ведите координаты точки B:\n");
        int[] point_2 = input_point(point_coord_count);
    //Рассчёт длины между 2мя координатами n-мерного пространства
    double distance = vector_length(point_1, point_2);
    //вывод введённых точек
    output_point(point_1, 'A'); Console.Write("; ");
    output_point(point_1, 'B');
    //вывод результата рассчёта
    Console.Write(" -> {0:f2}", vector_length(point_1, point_2));
        //Console.Write(" -> {0:0.00}", distance);
    Console.Write("\n\n");
*/

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
    //Метод 1 - возведенье в 3-ю  степень 
    int degree3(int num)
    {
        return num*num*num;
    }

    //Основная программа
    // Ввод числа пользователем
    Console.Write("\nВедите натуральное (положительное целое) число и нажмите enter: ");
    int numnber = Convert.ToInt32(Console.ReadLine());
     Console.Write("Tаблица кубов чисел от 1 до {0}:\n",numnber);
    //проверка какое же чило ведено - натуральное?
    if (numnber<1)
    {
        Console.Write("Введено число, отличное от пятизначного\n Программа завершена...\n");
    }
    else
    {
        //вывод результата рассчёта, до i < numnber из-за запятых
        Console.Write("{0} -> ", numnber);
        for(int i = 1; i < numnber; i++)
        {
            Console.Write(degree3(i) + ", ");
        }
         //вывод результата рассчёта
        Console.WriteLine("{0}\n", degree3(numnber)); 
    }

