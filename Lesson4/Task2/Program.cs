/* Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. */

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сумма цифр в числе = " + SumNumbers(number));



int SumNumbers( int numbers){
    int sum = 0;
    
    while(numbers%10 != 0 || numbers/10 != 0){
        sum += numbers % 10;
        numbers /= 10;

    }

    return sum;
}