/* Задача 1: Пользователь вводит с клавиатуры M чисел.
 Посчитайте, сколько чисел больше 0 ввёл пользователь. */

int[] FillArray(int amount){
    
    int[] arr = new int[amount];
    for ( int i = 0; i < arr.Length; i++){
        Console.Write($"Введите {i + 1} число: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

int AboveZero(int[] array){

    int count = 0;

   for (int i = 0; i < array.Length; i++){
        if (array[i] > 0){
            count++;
        }
   }

   return count;

}

Console.Write("Введите количество чисел: ");
int[] array = FillArray(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine($"Количество чисел больше нуля = {AboveZero(array)} ");