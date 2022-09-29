/* Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве. */

void FillArray(int[] arr){
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++){
        arr[i] = rnd.Next(100, 1000);
    }
}

int EvenNumbers(int[] arr){
    int counter = 0;
    for (int i = 0; i < arr.Length; i++){
        if (arr[i] % 2 == 0){
            counter++;
        }
    }
    return counter;
}

void PrintArray(int[] arr){
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++){
        if (i + 1 < arr.Length){
            Console.Write($"{arr[i]}, ");
        }
        else
            Console.Write(arr[i]);
    }
    Console.WriteLine(" ]");
}

int[] numbers = new int[5];
FillArray(numbers);
PrintArray(numbers);
Console.WriteLine($"Количество четных чисел = {EvenNumbers(numbers)}");
