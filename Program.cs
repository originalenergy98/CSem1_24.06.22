// 1. Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя) 

// Console.Write("Input number:"); // запрашиваем у пользователя число 
// int number = Convert.ToInt32(Console.ReadLine()); // создаем переменную number и сохраняем в нее значение, введенное из консоли
// 2. int number = 4;
// 2. int q = number * number; // объявляем переменную q и сохраняем в нее квадрат числа number 
// Console.WriteLine(number + " -> " + q);//выводим значение переменных number и q
// 2. Console.WriteLine(number + " -> " + number * number);


// // 2. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// // a = 25, b = 5 -> да

// // вводим первое число
// Console.Write("Input first number: ");

// // сохраняем значение в переменную
// int number_1 = Convert.ToInt32(Console.ReadLine());

// // вводим второе число и сохраняем в переменную
// Console.Write("Input second number: ");
// int number_2 = Convert.ToInt32(Console.ReadLine());

// //сравниваем значение первой переменной со значением второй переменной, умноженным на само себя
// if(number_1 == number_2 * number_2)
//     Console.Write("a = " + number_1 + ", b = " + number_2 + "->" + "yes");
// else
//     Console.Write("a = " + number_1 + ", b = " + number_2 + "->" + "no");

// 3.
// Console.WriteLine("Введите день: ");
// int day = Convert.ToInt32(Console.ReadLine());
// if(day == 1)
//     Console.WriteLine("Понедельник");
// else if (day == 2)
//     Console.WriteLine("Вторник");
// else if (day == 3)
//     Console.WriteLine("Среда");
// else if (day == 4)
//     Console.WriteLine("Четверг");
// else if (day == 5)
//     Console.WriteLine("Пятница");
// else if (day == 6)
//     Console.WriteLine("Суббота");
// else if (day == 7)
//     Console.WriteLine("Воскресенье");
// else 
//     Console.WriteLine("Не верно указан день");

//                           Домашнее задание

// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.Write("Input first number: ");
// int number_1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input second number: ");
// int number_2 = Convert.ToInt32(Console.ReadLine());

// if(number_1 > number_2)
//     Console.Write("a = " + number_1 + ", b = " + number_2 + " -> " + "max = " + number_1 + ", min = " + number_2);
// else
//     Console.Write("a = " + number_1 + ", b = " + number_2 + " -> " + "max = " + number_2 + ", min = " + number_1);

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78 
// 22 3 9 -> 22

// Console.Write("Input number_1: ");
// int number_1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number_2: ");
// int number_2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number_3: ");
// int number_3 = Convert.ToInt32(Console.ReadLine());
// int max = 0; 

// if(number_1 > number_2){
//     max = number_1;}
// if(number_2 > number_3){
//     max = number_2;}
// else
//     {max = number_3;}
// Console.WriteLine("a = " + number_1 + ", b = " + number_2 + ", c = " + number_3 + " -> " + "max = " + max);

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.Write("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if(0 == number % 2)
//     Console.Write(number + "->" + "yes");
// else
//     Console.Write(number + "->" + "no");


// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Console.Write("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.Write(number + " -> ");
// for( int i = 1; i <= number; i++)
//     if(0 == i % 2)
//     Console.Write(" " + i);
     
    
