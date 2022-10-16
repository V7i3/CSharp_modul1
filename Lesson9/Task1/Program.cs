/* Задача 1: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */


void Numbers(int amount){
    if(amount == 0) return ; 
    else{
       Console.Write($"{amount--} ");
       Numbers(amount);
    }
}

Console.Write("Введите максимальное число: ");
int amt = Convert.ToInt32(Console.ReadLine());

Numbers(amt);