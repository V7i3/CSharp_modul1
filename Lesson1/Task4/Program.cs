﻿/* Задача 4: Напишите программу, которая на вход принимает число (N),
 а на выходе показывает все чётные числа от 1 до N. */

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 2;  i <= number; i+=2){
    if (i+1 < number){
        Console.Write(i + ", ");
    }
    else 
        Console.Write(i);
}
