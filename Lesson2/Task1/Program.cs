/* Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
вторую цифру этого числа. */

Console.Write("Введите 3х значное число: ");
int number = Convert.ToInt32(Console.ReadLine());
string number2 = Convert.ToString(number);

Console.WriteLine("Вторая цифра числа = " + number2[1]);
