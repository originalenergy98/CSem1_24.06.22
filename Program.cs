//                                        Семинар 1

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


// ---------------------------------------------------------------------
//                           Домашнее задание 1

// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.Write("Number a: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Number b: ");
// int b = Convert.ToInt32(Console.ReadLine());

// if(a > b){  //либо это
//     Console.Write("max = " + a );}
// else if (a < b){ // либо это
//     Console.Write("max = " + b );}
// else { // иначе
//     Console.Write("введены одинаковые числа");}

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.Write("Input number_1: ");
// int num_1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number_2: ");
// int num_2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number_3: ");
// int num_3 = Convert.ToInt32(Console.ReadLine());

// if(num_1 > num_2 & num_1 > num_3){ //if & - если и то и то верно
//     Console.WriteLine("max number: " + num_1);}
// else if(num_2 > num_1 & num_2 > num_3){
//     Console.WriteLine("max number: " + num_2);}
// else if(num_3 > num_1 & num_3 > num_2){
//     Console.WriteLine("max number: " + num_3);}
// else
//     {Console.WriteLine("False");}

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.Write("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if(0 == number % 2) // % - процент от деления
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

// --------------------------------------------------------------------------------------------------------
//                                     Семинар 2

// 9. Напишите программу, которачя выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8
// 12 -> 2
// 85 -> 8

// void randomNumber(){ // метод
//     int num = new Random().Next(10,100); // последнюю цифру Random не включает
//         Console.Write(num + " -> ");
//     if ( num / 10 > num % 10){
//         Console.WriteLine(num / 10);}
//     else{Console.WriteLine(num % 10);}

// }

// for (int i = 0; i < 2; i++)
// {
//     randomNumber();
// }


// void randomNumber();

// int SumTwoNumbers(int a, int b){ // int возвращает
//     int sum = a +b;
//     return sum;
// }

// Console.Write("Введите первое число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Сумма двух чисел: " + SumTwoNumbers(number1, number2));

// --------------------------------------------------------------------------------------------------------
//                                Домашнее заадание 2


// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.Write("Введите трехзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int num1 = num / 10;
// int num2 = num1 % 10;
// Console.WriteLine(num2);


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

//
// Console.Write("Введите трехзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if(0 == num / 100){
//     Console.WriteLine("Третьей цифры нет");}
// else{while (num > 1000){
//     num = num / 10;}
//     Console.WriteLine(num % 10);}

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

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

// if (day < 6){
//     Console.WriteLine("Рабочий");}
// else if (day == 6 || day == 7)
//     Console.WriteLine("Выходной");
// else
//     Console.WriteLine("Не верно указан день");
//

//--------------------------------------------------------------
//                            Семинар 3

// 17

// int[] Input()
// {
//     int[] Array = new int[2];
//     Console.WriteLine("Введите координту числа X: ");
//     int x = Convert.ToInt32(Console.ReadLine());
//     Array[0] = x;
//     Console.WriteLine("Введите координту числа Y: ");
//     int y = Convert.ToInt32(Console.ReadLine());
//     Array[1] = y;
//     return Array;
// }

// int[] mini = Input();
// while (mini[0] == 0 || mini[1] == 0)
//     {Console.WriteLine("Точка находится на оси");
//     mini = Input();}
// if (mini[0] > 0 && mini[1] > 0){
//     Console.WriteLine("Точка находиится в 1 четверти");}
// else if (mini[0] < 0 && mini[1] < 0){
//     Console.WriteLine("Точка находиится в 3 четверти");}
// else if (mini[0] > 0 && mini[1] < 0){
//     Console.WriteLine("Точка находиится в 4 четверти");}
// else{
//     Console.WriteLine("Точка находиится в 2 четверти");}


// 18
// Console.WriteLine("Введите номер четверти: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num < 1 || num > 4)
//     {Console.WriteLine("Номер четверти введен не верно");}
// else if (num == 1){
//     Console.WriteLine("Координаты:  x < 0, y > 0");}
// else if (num == 2){
//     Console.WriteLine("Координаты:  x > 0, y > 0");}
// else if (num == 3){
//     Console.WriteLine("Координаты:  x > 0, y < 0");}
// else{
//     Console.WriteLine("Координаты:  x < 0, y < 0");}

// 21

// double SystemCoor( int x1, int y1, int x2, int y2){
//     return(Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2)));
// }
//     Console.WriteLine("Введите координту x1: ");
//     int Ax = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите координту y1: ");
//     int Ay = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите координту x2: ");
//     int Bx = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите координту y2: ");
//     int By = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Math.Round(SystemCoor(Ax, Ay, Bx, By), 4));// 4- знаки после запятой

//22
/*
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write(num + " => ");
for (int i = 1; i <= num; i++)
{
    Console.Write(i * i + ", ");
}
*/
//-------------------------------------------------------------------------
//                       Домашнее задание 3

//19

// Console.WriteLine("Введите пятизначноое число ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num < 10000 || num > 100000)
// {
//     Console.WriteLine("Введено не пятизначное число");
// }
// while (num > 9999 && num < 100000)
// {
//     int a1 = num % 10;
//     int a2 = num / 10 % 10;
//     int a3 = num / 100 % 10;
//     int a4 = num / 1000 % 10;
//     int a5 = num / 10000;
//     int num2 = a1 * 10000 + a2 * 1000 + a3 * 100 + a4 * 10 + a5;
//     if (num == num2)
//     {
//         Console.WriteLine(" является палиндромом");
//     }
//     else 
//     {
//         Console.WriteLine(" не является палиндромом");
//     }}


// 21

// double Coor( int x1, int y1, int z1, int x2, int y2, int z2){
//     return(Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2)));
// }
//     Console.WriteLine("Введите координту x1: ");
//     int Ax = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите координту y1: ");
//     int Ay = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите координту z1: ");
//     int Az = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите координту x2: ");
//     int Bx = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите координту y2: ");
//     int By = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите координту z2: ");
//     int Bz = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Coor(Ax, Ay, Az, Bx, By, Bz)); // 4- знаки после запятой

// 23

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.Write(num + " => ");
// for (int i = 1; i <= num; i++)
// {
//     Console.Write(i * i * i + ", ");
// }

//---------------------------------------------------------------------------------------
//                                    Семинар 4

// 24


// Решение с for
// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// Console.Write(num + " => ");
// for (int i = 1; i <= num; i++)
// {
//     sum = sum + i;}
// Console.WriteLine(sum);

// Решение с while
// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// int i = 1;
// while (i <= num)
// {
//     sum = sum + i;
//     i += 1;
// }
// Console.WriteLine(sum);

// Решение методом int
// int SumNumbers(int N)
// {
//     int sum = 0;
//     for (int i = 1; i <= N; i++)
//     {
//         sum = sum + i;}
//     return sum;
// }

// for (int i = 0; i < 5; i++)
// {
// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(num + "->" + SumNumbers(num));
// }

// Решение методом void
// void SumNumbers(int N)
// {
//     int sum = 0;
//     for (int i = 1; i <= N; i++)
//     {
//         sum = sum + i;}
//     Console.WriteLine(N + "->" + sum);
// }

// for (int i = 0; i < 5; i++)
// {
// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// SumNumbers(num);
// }

// 30
// int[] GenerateRandomArray(int N, int start, int end){
//     int[] RandomArray = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         RandomArray[i] = new Random().Next(start, end + 1);
//     }
//     return RandomArray;
// }

// int[] GenerateArray(int N, int start, int end){
//     int[] RandomArray = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         Console.WriteLine($"Введите {i + 1} элемент массива");
//         RandomArray[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return RandomArray;
// }

// void ShowArray(int[] array){
    
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// Console.Clear();
// Console.WriteLine("Введите количество элементов в массиве");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите первое число случайно генирируемого диапозона");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите последнее число случайно генирируемого диапозона");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myRandomArray = GenerateRandomArray(num, min, max);
// ShowArray(myRandomArray);
// Console.WriteLine("------------------");
// int[] myArray = GenerateArray(num, min, max);
// ShowArray(myArray);


//------------------------------------------------------------------------------------------------
//                                          Домашнее задание

// 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// void StepNumbers(int a, int b)
// {
//     int step = 1;
//     for (int i = 0; i < b; i++){   
//         step = step * a;}
//     Console.WriteLine(a + "->" + step);
// }

// Console.WriteLine("Введите число A");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число B");
// int B = Convert.ToInt32(Console.ReadLine());
// StepNumbers(A, B);


// 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

// void SumNumbers(int n)
// {
//     int j = 0;
//     int sum = 0;
//     while(n > 0){
//         j = n % 10;
//         n = n / 10;
//         sum = sum + j;}
//     Console.WriteLine(sum);
// }

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// SumNumbers(num);


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int[] GenerateRandomArray(int N, int start, int end){
//     int[] RandomArray = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         RandomArray[i] = new Random().Next(start, end + 1);
//     }
//     return RandomArray;
// }
// void ShowArray(int[] array){
    
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }
// Console.Clear();
// Console.WriteLine("Введите количество элементов в массиве");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите первое число случайно генирируемого диапозона");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите последнее число случайно генирируемого диапозона");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myRandomArray = GenerateRandomArray(num, min, max);
// ShowArray(myRandomArray);