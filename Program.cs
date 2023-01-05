// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// ********************Задача 1*******************************
// Задача 63: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// Console.WriteLine("Введите число:");
// int num = Convert.ToInt32(Console.ReadLine());

// string Printnumber (int start, int end)
// {
//     if (start==end)
//     {
//         return start.ToString();
//     }
// return (start+" "+Printnumber(start+1,end));
// }

// Console.WriteLine(Printnumber(1,num));
// **************Конец**********************
// **************Задача 2*******************
// Задача 65: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

// Console.WriteLine("Введите N:");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите M:");
// int M = Convert.ToInt32(Console.ReadLine());

// string Printnum(int start, int end)
// {
//     if (start==end)
//     {
//         return start.ToString();
//     }
//     if (start>end)
//     {
//         return ("Числа некоректны");
//     }
//     return (start+" "+Printnum(start+1,end));
// }
// Console.WriteLine(Printnum(N,M));
// *****************Конец********************
// ***************Задача 3********************
// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// Console.WriteLine("Введите N:");
// int N = Convert.ToInt32(Console.ReadLine());

// int Sumnumber(int number)
// {
//     if (number == 0)
//     {
//         return (0);
//     }
//     return (number%10+Sumnumber(number/10));
// }
// Console.WriteLine(Sumnumber(N));

// *****************Конец************************
// *****************Задача 3**********************
// Задача 69: Напишите программу, которая на вход принимает 
// два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

// Console.WriteLine("Введите N:");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите M:");
// int M = Convert.ToInt32(Console.ReadLine());

// int Sqrnum(int number, int sqr)
// {
//     if (sqr==0)
//     {
//         return (1);
//     }
//     if (sqr==1)
//     {
//         return (N);
//     }
//     return (number*Sqrnum(number,sqr-1));
// }
// Console.WriteLine(Sqrnum(N,M));

// ****************Конец****************************
// ****************Задача 4************************


