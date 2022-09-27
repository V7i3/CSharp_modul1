/* Задача 2: Напишите программу, которая выводит случайное трёхзначное число 
и удаляет вторую цифру этого числа. */

int randomNumber = new Random().Next(100, 1000);
Console.WriteLine("Случайное число = " + randomNumber);
string number = Convert.ToString(randomNumber);
Console.WriteLine("После удаления второй цифры = "+ number[0] + number[2]);
