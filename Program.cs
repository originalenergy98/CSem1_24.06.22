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
// int[] GenerateRandomArray(int N, int start, int end){ // создает случайные элементы 
//     int[] RandomArray = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         RandomArray[i] = new Random().Next(start, end + 1);
//     }
//     return RandomArray;
// }

// int[] GenerateArray(int N, int start, int end){ // Запрашивает случайные элементы
//     int[] RandomArray = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         Console.WriteLine($"Введите {i + 1} элемент массива");
//         RandomArray[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return RandomArray;
// }

// void ShowArray(int[] array){ // Выводит элементы в консоль
    
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

// int[] myNumArray(int N, int start, int end){ 
//     int[] RandomArray = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         RandomArray[i] = new Random().Next(start, end + 1);
//     }
//     return RandomArray;
// }

// void newShowArray(int[] array){
    
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

// int[] myRandomArray = myNumArray(num, min, max);
// newShowArray(myRandomArray);

//---------------------------------------------------------------------------------------
//                                          Семинар 5

// Примеры форматирования

// string name = "Имя";
// int age = 99;
// Console.WriteLine("Имя: {0} Возраст: {1}", name, age);

// int number = 23;
// string result = string.Format("{0:f}", number);

// Console.WriteLine(result);

// double number2 = 45.08;
// string result2 = string.Format("{0:f5}", number2);
// Console.WriteLine(number2);
// Console.WriteLine(result2);

// string name = "Имя";
// int age = 99;
// Console.WriteLine($"Имя: {name} Возраст: {age}");

// int x = 7;
// int y = 8;
// string result = $"{x} + {y} = {x + y}";
// Console.WriteLine(result);

// string name = "Елена";
// int age = 99;

// Console.WriteLine($"Имя: {name, -10} Возраст: {age}"); // пробелы после
// Console.WriteLine($"Имя: {name, 15} Возраст: {age}"); // пробелы до

// 31

// int[] SetArray(int size, int start, int end){
//     int[] RandomArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         RandomArray[i] = new Random().Next(start, end + 1);
//     }
//     return RandomArray;
// }

// void OutputArray(int[] array){
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int[] MySetArray = SetArray(12, -9, 9);
// OutputArray(MySetArray);

// int sum_pos = 0;
// int sum_neg = 0;

// for (int i = 0; i < MySetArray.Length; i++)
// {
//     if(MySetArray[i] > 0)
//         sum_pos += MySetArray[i];
//     else
//         sum_neg += MySetArray[i];
// }

// Console.WriteLine($"Сумма положительных: {sum_pos}. Сумма отрицательных: {sum_neg}");

// 32 Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

// int[] SetArray(int size, int start, int end){
//     int[] RandomArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         RandomArray[i] = new Random().Next(start, end + 1);
//     }
//     return RandomArray;
// }

// void OutputArray(int[] array){
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int[] MySetArray = SetArray(4, -9, 9);
// OutputArray(MySetArray);

// for (int i = 0; i < MySetArray.Length; i++)
// {
//     Console.Write(MySetArray[i] * - 1 + " ");
// }


// 33 Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


// int[] SetArray(int size, int start, int end){
//     int[] RandomArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         RandomArray[i] = new Random().Next(start, end + 1);
//     }
//     return RandomArray;
// }

// void OutputArray(int[] array){
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }


// int[] MySetArray = SetArray(6, -9, 9);
// OutputArray(MySetArray);
// Console.WriteLine("Задайте цифру");
// int n = Convert.ToInt32(Console.ReadLine());

// string str = "No";
// for (int i = 0; i < MySetArray.Length; i++)
// {
//     if (MySetArray[i] == n)
//     {
//         str = "Yes";   
//         break;
//     }
    
// }
// Console.WriteLine(str);

// 35 Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


// int[] SetArray(int size, int start, int end){
//     int[] RandomArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         RandomArray[i] = new Random().Next(start, end + 1);
//     }
//     return RandomArray;
// }

// void OutputArray(int[] array){
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int[] MySetArray = SetArray(123, 0, 500);
// OutputArray(MySetArray);
// int n = 0;

// for (int i = 0; i < MySetArray.Length; i++)
// {
//     if (MySetArray[i] > 9 && MySetArray[i] < 100)
//     {
//         n++;
//     }
// }
// Console.WriteLine(n);

// 37 Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


// int[] SetArray(int size, int start, int end){
//     int[] RandomArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         RandomArray[i] = new Random().Next(start, end + 1);
//     }
//     return RandomArray;
// }

// void OutputArray(int[] array){
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int[] MySetArray = SetArray(123, 0, 500);
// OutputArray(MySetArray);
// int n = 0;

// for (int i = 0; i < MySetArray.Length; i++)
// {
//     if (MySetArray[i] > 9 && MySetArray[i] < 100)
//     {
//         n++;
//     }
// }
// Console.WriteLine(n);

//--------------------------------------------------------------------------------------
//                                 Домашнее задание 5

//  Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] SetArray(int size, int start, int end){
//     int[] RandomArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         RandomArray[i] = new Random().Next(start, end + 1);
//     }
//     return RandomArray;
// }

// void OutputArray(int[] array){
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int[] MySetArray = SetArray(5, 100, 999);
// OutputArray(MySetArray);
// int n = 0;

// for (int i = 0; i < MySetArray.Length; i++)
// {
//     if (0 == MySetArray[i] % 2)
//     {
//         n++;
//     }
// }
// Console.WriteLine(n);


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] SetArray(int size, int start, int end){
//     int[] RandomArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         RandomArray[i] = new Random().Next(start, end + 1);
//     }
//     return RandomArray;
// }

// void OutputArray(int[] array){
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int[] MySetArray = SetArray(5, 1, 100);
// OutputArray(MySetArray);
// int sum = 0;

// for (int i = 0; i < MySetArray.Length; i++)
// {
//     if (0 == i % 2)
//     {
//         sum = sum + MySetArray[i];
//     }
//     else{}
// }
// Console.WriteLine(sum);

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// int[] SetArray(int size, int start, int end){
//     int[] RandomArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         RandomArray[i] = new Random().Next(start, end + 1);
//     }
//     return RandomArray;
// }

// void OutputArray(int[] array){
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int[] MySetArray = SetArray(5, 1, 100);
// OutputArray(MySetArray);
// int min = MySetArray[0];
// int max = MySetArray[0];

// for (int i = 0; i < MySetArray.Length; i++)
// {
//     if (min > MySetArray[i])
//     {
//         min = MySetArray[i];
//     }
//     else if (max < MySetArray[i])
//     {
//         max = MySetArray[i];
//     }
// }
// Console.WriteLine(max - min);

//-------------------------------------------------------------------------------------------------
//                                       Семинар 6

// 39
// Напишите программу, которая перевернёт одномерный массив
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)

// int[] GetArray(int size, int minValue, int maxValue)
// {
// int[] res = new int[size];

// for (int i = 0; i < size; i++)
// {
// res[i] = new Random().Next(minValue, maxValue + 1);
// }
// return res;
// }

// void ReversArray1(int[] inArray)
// {
// for (int i = 0; i < inArray.Length / 2; i++)
// {
// int k = inArray[i];
// inArray[i] = inArray[inArray.Length - i - 1];
// inArray[inArray.Length - i - 1] = k;
// }
// }

// int[] ReversArray2(int[] inArray)
// {
// int[] result = new int[inArray.Length];
// for (int i = 0; i < inArray.Length; i++)
// {
// result[i] = inArray[inArray.Length - 1 - i];
// }
// return result;
// }

// Console.Clear();

// int[] array = GetArray(10, 0, 10);
// Console.WriteLine(String.Join(" ", array));

// int[] reversArray=ReversArray2(array);
// Console.WriteLine(String.Join(" ", reversArray));

// ReversArray1(array);
// Console.WriteLine(String.Join(" ", array));

// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

// Console.WriteLine("Введите 1 число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите 2 число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите 3 число: ");
// int c = Convert.ToInt32(Console.ReadLine());

// if (a <= b + c && b <= a + c && c <= b + a )
// {
//     Console.WriteLine("Треугольник может существовать");
// }
// else
// {
//     Console.WriteLine("Треугольник не может существовать");
// }

// 42 Напишите программу, которая будет преобразовывать десятичное число в двоичное.

// Console.WriteLine("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());

// while (a > 0)
// {
//     Console.Write(a%2);
//     a = a/2;
// }


// 44 Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());

// int b = 1;
// for (int i = 0; i < a; i++)
// {
//     b = i + b;
//     Console.Write(b + " ");
//}

// 45

//-------------------------------------------------------------------------------------
//                                       Домашнее задание 6

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


// int[] CreateArray(){ 
//     Console.WriteLine("Введите количество элементов массива"); 
//     int size = Convert.ToInt32(Console.ReadLine()); 
//     int[] RandomArray = new int[size]; 
//     for (int i = 0; i < size; i++){
//         Console.WriteLine($"Введите {i+1} элемент массива"); 
//         RandomArray[i] = Convert.ToInt32(Console.ReadLine()); } 
// return RandomArray; }

// int[] MySetArray = CreateArray();
// Console.Clear();
// Console.WriteLine(MySetArray);

// int count = 0;
// for (int i = 0; i < MySetArray.Length; i++)
// {
//     if (MySetArray[i] > 0)
//     {
//         count = count + 1;
//     }
//     else{}
// }
// Console.WriteLine($"Колличество цифр введеных больше нуля: " count);


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 0,5)

// Console.Write("Введите точку b1: ");
// double b1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите точку k1: ");
// double k1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите точку b2: ");
// double b2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите точку k2: ");
// double k2 = Convert.ToInt32(Console.ReadLine());


// if (k1 == k2){
//     if (b1 == b2){
//         Console.WriteLine("Точек пересечения бесконечно много - прямые совподают ");
//     } 
//     else{
//         Console.WriteLine("Точек пересечения нет");
//     }   
// }
// else{
//     double x = (b1 -b2)/(k2 - k1);
//     double y = k1 * x + b1;
// Console.WriteLine(x + ", " + y );}

//--------------------------------------------------------------------------------------
//                                            Семинар 7
// 46
// Console.Clear();

// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
// int[,] result = new int[m, n];
// for (int i = 0; i < m; i++)
// {
// for (int j = 0; j < n; j++)
// {
// result[i, j] = new Random().Next(minValue, maxValue + 1);
// }
// }
// return result;
// }

// void PrintArray(int[,] inArray)
// {
// for (int row = 0; row < inArray.GetLength(0); row++)
// {
// for (int column = 0; column < inArray.GetLength(1); column++)
// {
// Console.Write($"{inArray[row,column]} ");
// }
// Console.WriteLine();
// }
// }

// Console.Write("Введите количество строк массива: ");
// int rows=Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов массива: ");
// int columns=Convert.ToInt32(Console.ReadLine());

// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);


// 48

// Console.Clear();

// int[,] GetArray(int m, int n, int minValue, int maxValue){
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++){
//         for (int j = 0; j < n; j++){
//             result[i, j] = (i+j);
//             }
//         }
//     return result;
// }

// void PrintArray(int[,] inArray)
// {
// for (int row = 0; row < inArray.GetLength(0); row++)
// {
// for (int column = 0; column < inArray.GetLength(1); column++)
// {
// Console.Write($"{inArray[row,column]} ");
// }
// Console.WriteLine();
// }
// }

// Console.Write("Введите количество строк массива: ");
// int rows=Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов массива: ");
// int columns=Convert.ToInt32(Console.ReadLine());

// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);

// 49 Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Console.Clear();

// int[,] GetArray(int m, int n, int minValue, int maxValue){
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++){
//         for (int j = 0; j < n; j++){
//             result[i, j] = new Random().Next(minValue, maxValue + 1);}
//             }
//             return result;}

// void PrintArray(int[,] inArray){
//     for (int row = 0; row < inArray.GetLength(0); row++){
//         for (int column = 0; column < inArray.GetLength(1); column++){
//             Console.Write($"{inArray[row,column]} ");}
//             Console.WriteLine();}}

// Console.Write("Введите количество строк массива: ");
// int rows=Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов массива: ");
// int columns=Convert.ToInt32(Console.ReadLine());

// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);
// Console.WriteLine("---------");

// int sum = 0;
// for (int i = 0; i < array.GetLength(0); i++){
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//      if (0 == i % 2 && 0 == j % 2)
//      {
//         array[i,j] = array[i,j] * array[i, j];
//      }   
//     }
// }
// PrintArray(array);

//51
// Console.Clear();

// int[,] GetArray(int m, int n, int minValue, int maxValue){
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++){
//         for (int j = 0; j < n; j++){
//             result[i, j] = new Random().Next(minValue, maxValue + 1);}
//             }
//             return result;}

// void PrintArray(int[,] inArray){
//     for (int row = 0; row < inArray.GetLength(0); row++){
//         for (int column = 0; column < inArray.GetLength(1); column++){
//             Console.Write($"{inArray[row,column]} ");}
//             Console.WriteLine();}}

// Console.Write("Введите количество строк массива: ");
// int rows=Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов массива: ");
// int columns=Convert.ToInt32(Console.ReadLine());

// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);

// int sum = 0;
// for (int i = 0; i < array.GetLength(0); i++){
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//      if (i == j)
//      {
//         sum = sum + array[i, j];
//      }   
//     }
// }
// Console.WriteLine(sum);

//-------------------------------------------------------------------------------------
//                                       Домашнее задание 7

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.Clear();

// double[,] GetArray(int m, int n, int minValue, int maxValue){
//     double[,] result = new double[m, n];
//     for (int i = 0; i < m; i++){
//         for (int j = 0; j < n; j++){   
//             result[i, j] = new Random().NextDouble()*(maxValue-minValue);}}
//             return result;}

// void PrintArray(double[,] inArray){
//     for (int row = 0; row < inArray.GetLength(0); row++){
//         for (int column = 0; column < inArray.GetLength(1); column++){
//             Console.Write($"{inArray[row,column]:f2} ");}
//             Console.WriteLine();}}

// Console.Write("Введите количество строк массива: ");
// int rows=Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов массива: ");
// int columns=Convert.ToInt32(Console.ReadLine());

// double[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого числа в массиве нет

// Console.Clear();

// int[,] GetArray(int m, int n, int minValue, int maxValue){
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++){
//         for (int j = 0; j < n; j++){
//             result[i, j] = new Random().Next(minValue, maxValue + 1);}
//             }
//             return result;}

// void PrintArray(int[,] inArray){
//     for (int row = 0; row < inArray.GetLength(0); row++){
//         for (int column = 0; column < inArray.GetLength(1); column++){
//             Console.Write($"{inArray[row,column]} ");}
//             Console.WriteLine();}}

// Console.Write("Введите количество строк массива: ");
// int rows=Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов массива: ");
// int columns=Convert.ToInt32(Console.ReadLine());

// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);



// Console.Write("Введите номер сроки: ");
// int a =Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите номер столбца: ");
// int b =Convert.ToInt32(Console.ReadLine());
// Console.Write($"{a},{b}");

// if(a < args.GetLength(0) && b < array.GetLength(1)){
//     Console.Write(" -> такой индекс существует в массиве");
// }
// else{
//     Console.Write(" -> такой индекс не существует в массиве");
// }

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Console.Clear();

// int[,] GetArray(int m, int n, int minValue, int maxValue){
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++){
//         for (int j = 0; j < n; j++){
//             result[i, j] = new Random().Next(minValue, maxValue + 1);}
//             }
//             return result;}

// void PrintArray(int[,] inArray){
//     for (int row = 0; row < inArray.GetLength(0); row++){
//         for (int column = 0; column < inArray.GetLength(1); column++){
//             Console.Write($"{inArray[row,column]} ");}
//             Console.WriteLine();}}

// Console.Write("Введите количество строк массива: ");
// int rows=Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов массива: ");
// int columns=Convert.ToInt32(Console.ReadLine());

// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);

// for (int j = 0; j < array.GetLength(1); j++){
//     int sum = 0;
//     for (int i = 0; i < array.GetLength(0); i++){
//         sum = sum + array[i,j];
//     }
//     Console.Write($"{sum/rows} ,");
// }

//--------------------------------------------------------------------------------------
//                                        Семинар 8

// Задача 53: Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую и последнюю строку массива.

// int[,] GetArray(int a, int b, int minValue, int maxValue){
//     int[,] result = new int[a,b];
//     for (int i = 0; i < a; i++){
//         for (int j = 0; j < b; j++){
//             result[i,j] = new Random().Next(minValue, maxValue + 1);}}
//     return result;}

// void PrintArray(int[,] inArray){
//     for (int row = 0; row < inArray.GetLength(0); row++){
//         for (int colum = 0; colum < inArray.GetLength(1); colum++){
//             Console.Write($"{inArray[row,colum]}");}
//             Console.WriteLine();}}
// Console.Write("Введите количество строк массива: ");
// int rows=Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов массива: ");
// int columns=Convert.ToInt32(Console.ReadLine());

// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);
// Console.WriteLine("----------------------- ");

// void NewArray(int[,] inArray){
//     int k = inArray.GetLength(0)-1;
//     for (int i=0; i < inArray.GetLength(1); i++){
//         int n = inArray[0, i];
//         inArray[0,i] = inArray[k, i];
//         inArray[k,i] = n;}
//     PrintArray(inArray);}
// NewArray(array);

// Задача 55: Задайте двумерный массив. 
// Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.


// int[,] GetArray(int a, int b, int minValue, int maxValue){
//     int[,] result = new int[a,b];
//     for (int i = 0; i < a; i++){
//         for (int j = 0; j < b; j++){
//             result[i,j] = new Random().Next(minValue, maxValue + 1);}}
//     return result;}

// void PrintArray(int[,] inArray){
//     for (int row = 0; row < inArray.GetLength(0); row++){
//         for (int colum = 0; colum < inArray.GetLength(1); colum++){
//             Console.Write($"{inArray[row,colum]}");}
//             Console.WriteLine();}}
// Console.Write("Введите количество строк массива: ");
// int rows=Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов массива: ");
// int columns=Convert.ToInt32(Console.ReadLine());

// int[,] myArray = GetArray(rows, columns, 0, 10);
// PrintArray(myArray);

// Console.WriteLine("----------------------- ");
// int[,] arrayTwo = new int[myArray.GetLength(0), myArray.GetLength(1)];
// if (rows == columns){
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             arrayTwo[j,i] = myArray[i,j];
//         }
//     }
//     PrintArray(arrayTwo);
// }
// else
// Console.Write("Строки не равны столбцам");

// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

// Задача 59: Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.


//--------------------------------------------------------------------------------------
//                                     Домашее задание 8
// Задача 54: Задайте двумерный массив.
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


// int[,] GetArray(int a, int b, int minValue, int maxValue){
//     int[,] result = new int[a,b];
//     for (int i = 0; i < a; i++){
//         for (int j = 0; j < b; j++){
//             result[i,j] = new Random().Next(minValue, maxValue + 1);}}
//     return result;}

// void PrintArray(int[,] inArray){
//     for (int row = 0; row < inArray.GetLength(0); row++){
//         for (int colum = 0; colum < inArray.GetLength(1); colum++){
//             Console.Write($"{inArray[row,colum]}, ");}
//             Console.WriteLine();}}
// Console.Write("Введите количество строк массива: ");
// int rows=Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов массива: ");
// int columns=Convert.ToInt32(Console.ReadLine());

// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);
// Console.WriteLine("----------------------- ");

// void SortArray(int[,] inArray){
//     for (int i = 0; i < inArray.GetLength(0); i++){
//         for (int j = 0; j < inArray.GetLength(1); j++){//доп.цикл для сравнения рядом стоящих элементов
//             for (int t = j + 1; t < inArray.GetLength(1); t++){
//                 if (inArray[i, t] > inArray[i, j]){//делаем замену через временную переменную temp
//                     int temp = inArray[i, j];
//                     inArray[i, j] = inArray[i, t];
//                     inArray[i, t] = temp;}}}}
//                     PrintArray(inArray);}
//                     SortArray(array);

// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// int[,] GetArray(int m, int n, int minValue, int maxValue){
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++){
//         for (int j = 0; j < n; j++){
//             result[i, j] = new Random().Next(minValue, maxValue + 1);}}
//             return result;}

// void PrintArray(int[,] inArray){
//     for (int row = 0; row < inArray.GetLength(0); row++){
//         for (int column = 0; column < inArray.GetLength(1); column++){
//             Console.Write($"{inArray[row, column]} ");}
//             Console.WriteLine();}}

// Console.Write("Введите количество строк массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов массива: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] array = GetArray(rows, columns, 0, 7);
// PrintArray(array);

// int GetRowNumbers(int[,] array){
//     int row = 0;
//     int minsum = 0;
//     for (int j = 0; j < array.GetLength(1); j++){
//         minsum = minsum + array[0, j];}


// for (int i = 1; i < array.GetLength(0); i++){
//     int sum = 0;
//     for (int j = 0; j < array.GetLength(1); j++){
//         sum = sum + array[i, j];}
//         if (minsum > sum){
//             minsum = sum;
//             row = i;}}
//             return row;}
// Console.WriteLine($"Индекс строки с наименьшей суммой элементов: {GetRowNumbers(array)}");

// Задача 58: Задайте две матрицы.
// Напишите программу, которая будет находить произведение двух матриц.

// Console.Write("Введите количество строк 1 массива: ");
// int rowsA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов 1 массива: ");
// int columnsA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество строк 2 массива: ");
// int rowsB = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов 2 массива: ");
// int columnsB = Convert.ToInt32(Console.ReadLine());

// if (columnsA != rowsB){
//     Console.WriteLine("Такие матрицы умножать нельзя!");
//     return;}
// int[,] A = GetArray(rowsA, columnsA, 0, 10);
// int[,] B = GetArray(rowsB, columnsB, 0, 10);
// PrintArray(A);
// Console.WriteLine();
// PrintArray(B);
// Console.WriteLine();
// PrintArray(GetMultiplicationMatrix(A, B));

// int[,] GetArray(int m, int n, int min, int max){
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++){
//         for (int j = 0; j < n; j++){
//             result[i, j] = new Random().Next(min, max + 1);}}
//             return result;}

// void PrintArray(int[,] inArray){
//     for (int i = 0; i < inArray.GetLength(0); i++){
//         for (int j = 0; j < inArray.GetLength(1); j++){
//             Console.Write($"{inArray[i, j]} ");}
//             Console.WriteLine();}}

// int[,] GetMultiplicationMatrix(int[,] arrayA, int[,] arrayB){
//     int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
//     for (int i = 0; i < arrayA.GetLength(0); i++){
//         for (int j = 0; j < arrayB.GetLength(1); j++){
//             for (int k = 0; k < arrayA.GetLength(1); k++){
//                 arrayC[i, j] += arrayA[i, k] * arrayB[k, j];}}}
//                 return arrayC;}

// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// Console.Write("Введите размеры массива через пробел:");
// string[] nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
// int[,,] array = GetArray(new int[] { int.Parse(nums[0]), int.Parse(nums[1]), int.Parse(nums[2])}, 10, 99);
// PrintArray(array);

// int[,,] GetArray(int[] sizes, int min, int max){
//     int[,,] result = new int[sizes[0], sizes[1], sizes[2]];
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             int k = 0;
//             while(k < result.GetLength(2)){
//                 int element = new Random().Next(min, max+1);
//                 if(FindElement(result, element))continue;
//                 result[i, j, k] = element;
//                 k++;}}}
//                 return result;}

// bool FindElement(int[,,] array, int el){
//     for(int i = 0; i < array.GetLength(0); i++){
//         for (int j = 0; j < array.GetLength(1); j++){
//             for (int k = 0; k < array.GetLength(2); k++){
//                 if(array[i, j, k] == el) return true;}}}
//                 return false;}

// void PrintArray(int[,,] array){
//     for (int i = 0; i < array.GetLength(0); i++){
//         for (int j = 0; j < array.GetLength(1); j++){
//             for (int k = 0; k < array.GetLength(2); k++){
//                 Console.Write($"{array[i,j,k]}({i}, {j}, {k})   ");}
//                 Console.WriteLine();}
//                 Console.WriteLine();}}

// Задача 62: Заполните спирально массив 4 на 4.

// Console.Write($"Введите размер матрицы: ");
// int s = int.Parse(Console.ReadLine());
// int[,] arr = GetArray(s);
// PrintArray(arr);

// int[,] GetArray(int size){
//     int[,] result = new int(size, size);
//     int i = 0;
//     int j = 0;
//     int rowE = size - 1;
//     int columnE = size - 1;
//     int rowS = 0;
//     int columnS = 0;
//     bool left = true;
//     bool top = true;
//     int count = 0;
//     while (count < size + size){
//         count++;
//         result[i,j] = count;
//         //идем вправо
//         if(left && top){
//             if(j== columnE){
//                 rowS++;
//                 top = true;
//                 left = false;
//                 i++;
//                 continue;}
//             else{
//                 j++;
//                 continue;}}
//         //идем вниз
//         if(!left && top){
//             if(i == rowE){
//                 columnE--;
//                 top = false;
//                 left = false;
//                 j--;
//                 continue;}
//             else{
//                 i++;
//                 continue;}}
//         //идем влево
//         if(!left && !top){
//             if(j == columnS){
//                 rowE--;
//                 top = false;
//                 left = true;
//                 i--;
//                 continue;}}
//         //идем вверх
//         if (left && !top){
//             columnS++;
//             top = true;
//             left = true;
//             j++;
//             continue;}
//         else{
//             i--;
//             continue;}}
//         return result;}
        

//--------------------------------------------------------------------------------------
//                                        Семинар 9

// Задача 63: 
//Задайте значение N.
// Напишите программу, которая выведет все натуральные числа
// в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// // 1 решение стандартное
// Console.Write("Введите натуральное число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= N; i++)
// {
//     Console.Write($"{i} ");
// }
// Console.WriteLine();

// // 2 решение через void
// void PrintNumbersString(int number)
// {
//     for (int i = 1; i <= number; i++)
//     {

//         Console.Write($"{i} ");
//     }
//     Console.WriteLine();
// }

// // 3 решение через string
// string PrintNumbersStringType(int number)
// {
//     string result = "";
//     for (int i = 1; i <= number; i++)
//     {
//         result += i.ToString()+" ";
//     }
//    return result;
// }
// Console.Clear();
// Console.Write("Введите натуральное число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// //PrintNumbers(N); // вывод
// Console.WriteLine(PrintNumbersStringType(N)) ;


// Рекурсия
// string PrintNumbersRecusiveType(int start, int end)
// {
//     if (start == end)
//     {
//         return start.ToString();
//     }
//     return (start + " " + PrintNumbersRecusiveType(start+1, end));
// }

// Console.Clear();
// Console.Write("Введите натуральное число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(PrintNumbersRecusiveType(1, N)) ;

// Задача 64: Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке 
// от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 6, 7, 8"

// string PrintNumbersRecusiveType(int start, int end)
// {
//     if (start == end)
//     {
//         return start.ToString();
//     }
//     return (start + " " + PrintNumbersRecusiveType(start+1, end));
// }

// Console.Clear();
// Console.Write("Введите 1 натуральное число: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите 2 натуральное число: ");
// int N = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(PrintNumbersRecusiveType(M, N)) ;

// Задача 67: Напишите программу, которая будет принимать на вход число 
// и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// Console.Write("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{N}->{SumNumbers(N)}");

// int SumNumbers(int number){
//     if (number == 0) return 0;
//     return number % 10 + SumNumbers(number/10);}

// Задача 69: Напишите программу, которая на вход принимает
// два числа A и B, и возводит число А в целую степень B 
// с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 
// m = 2, n = 3 -> A(m,n) = 29

//--------------------------------------------------------------------------------------
//                                     Домашнее задание 9

// Задача 64: Задайте значения M и N.
// Напишите программу, которая выведет все натуральные числа 
// в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

// string RecusiveType(int start, int end){
//     if (start == end){
//         return start.ToString();}
//     return (start + " " + RecusiveType(start+1, end));}

// Console.WriteLine();
// Console.Write("Number m: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write("Number n: ");
// int N = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(RecusiveType(M, N)) ;


// Задача 66: Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int RecusiveSum(int start, int end){
//     if (start == end) return end;
//     else return (start + RecusiveSum(start + 1, end));}

// Console.WriteLine();
// Console.Write("Number m: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write("Number n: ");
// int N = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(RecusiveSum(M, N)) ;


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

int RecursionA(int start, int end){
    if (start == 0) {
        return end + 1;}
    else if (start == 0 && end > 0) {
        return RecursionA(start - 1, 1);}
    else {
        return RecursionA(start - 1, RecursionA(start, end - 1));}}

Console.Write(RecursionA(2, 3));
