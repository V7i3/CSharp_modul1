/* Задача 5 *: Напишите программу, которая генерирует несколько случайных чисел, и в цикле проверяет, 
кратны ли эти числа предварительно введенному числу, при кратности - цикл прерывается.
Введенное число 2 */

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Random rnd = new Random();
int[] array = new int[] {rnd.Next(0, 20), rnd.Next(0, 20), rnd.Next(0, 20), rnd.Next(0, 20), rnd.Next(0, 20),};

for (int i = 0; i < array.Length; i++){
    if (array[i]%number == 0){
        Console.WriteLine(array[i] + " -> Да");
        break;
    }
    else  
       Console.WriteLine(array[i] + " -> Нет");
}
