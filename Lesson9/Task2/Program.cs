/*  Задача 2: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int NumbersSum(int start, int finish, int sum){
    if(start <= finish) {
        sum += start;
        return NumbersSum(start + 1, finish, sum);
    }
    else return sum;
}

Console.Write("Введите начальное число: ");
int start = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите конечное число: ");
int finish = Convert.ToInt32(Console.ReadLine());

Console.Write($"Сумма целых чисел в диапазоне [{start},{finish}] = {NumbersSum(start, finish, 0)}");


