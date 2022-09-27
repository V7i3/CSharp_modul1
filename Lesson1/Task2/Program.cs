/* Задача 2: Напишите программу, которая принимает на вход три числа
 и выдаёт максимальное из этих чисел.  */

 Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2 && number1 > number3){
    Console.WriteLine("Наибольшее число = " + number1);
}
else {
    if (number2 > number1 && number2 > number3){
        Console.WriteLine("Наибольшее число = " + number2);
    }
    else {
        if (number3 > number1 && number3 > number2) {
            Console.WriteLine("Наибольшее число = " + number3);
        }
        else 
            Console.WriteLine("Числа равны");
    }
        
}
    
