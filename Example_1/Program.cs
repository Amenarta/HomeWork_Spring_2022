/* 
//Задача №1: Написать программу, которая на вход принимает целое число и выдает на консоль квадрат этого числа.
Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Результат квадрата числа " + num*num);

// Задача №2: Написать программу, которая на вход принимает 2 числа и проверяет является ли 1-е число квадратом 2-го числа.
Console.Write("Введите первое целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int quad = num2 * num2;

if(num1 == quad)
    {
        Console.WriteLine("Первое число является квадратом второго числа");
    }
else
    {
        Console.WriteLine("Первое число не является квадратом второго числа");
    }


// Задача №3: Программа, которая при вводе номера дня недели будет указывать какой именно это день недели.

Console.Write("Введите цифру дня недели от 1 до 7: ");
int num_day = Convert.ToInt32(Console.ReadLine());

if (num_day > 7 || num_day < 1)
    {
        Console.WriteLine("Цифра не соответствует количеству дней в неделе");
    }
else
    {
        if (num_day == 1)
            Console.WriteLine("Это понедельник");
        if (num_day == 2)
            Console.WriteLine("Это вторник");
        if (num_day == 3)
            Console.WriteLine("Это среда");
    }

    */

    // Задача №4: Написать прогрумму, которая на вход принимает число N, на выходе показывает все целые числа в промежутке от -N до N.

    Console.Write("Введите целое число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int current = -1 * num;

    while (current <= num)
    {
        Console.Write(current + " ");
        current ++;
    }



    