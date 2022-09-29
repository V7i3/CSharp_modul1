/* Задача 1: Напишите цикл, который принимает на вход два числа (A и B)
 и возводит число A в натуральную степень B. */

 Console.Write("Введите первое число: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int B = Convert.ToInt32(Console.ReadLine());

int result = 1;

for (int i = 0; i < B; i++){
    result = result * A;
}


Console.WriteLine("Результат = " + result);