﻿Console.Write("Введите цифру обозначающую день недели: ");
int numberDay = Convert.ToInt32(Console.ReadLine());
if (numberDay == 6 || numberDay == 7) 
  Console.WriteLine("Это выходной день");
else if (numberDay < 1 || numberDay > 7)
    Console.WriteLine("Такого дня в неделе нет");
else 
  Console.WriteLine("Это будний день");
