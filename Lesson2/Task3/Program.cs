/* Задача 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
 что третьей цифры нет. */

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string anyNumber = Convert.ToString(number);
if (anyNumber.Length > 2) 
  Console.WriteLine("Третья цифра = " + anyNumber[2]);
else 
  Console.WriteLine("Третьей цифры нет");
