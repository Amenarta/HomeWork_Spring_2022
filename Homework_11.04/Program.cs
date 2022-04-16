
/*

// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
    Console.WriteLine("Из двух введеных чисел больше: " + number1);
else
    Console.WriteLine("Из двух введеных чисел больше: " + number2);
   


// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2 && number1 > number3)
    Console.WriteLine("Из трех введеных чисел больше: " + number1);
else
    if (number2 > number3 && number2 > number1)
    Console.WriteLine("Из трех введеных чисел больше: " + number2);
    if (number3 > number2 && number3 > number1)
    Console.WriteLine("Из трех введеных чисел больше: " + number3);



// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number%2 == 0)
        Console.WriteLine("Число " + number + " является четным.");

else
    Console.WriteLine("Число " + number + " не является четным.");   

*/

// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
    
if (number > 1)
{
    int i = 1; i += 2;
    Console.WriteLine(i);
}  
          
while (number >= 1)
{
    Console.Write(number + " ");
    number ++;
}
