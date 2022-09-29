/* Задача 2: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях. */

void FillArray(int[] arr){
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++){
        arr[i] = rnd.Next(-100, 100);
    }
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

int SumOddIndex(int[] arr){
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2){
        sum += arr[i];
    }
    return sum;
}



int[] numbers = new int[5];
FillArray(numbers);
PrintArray(numbers);
Console.WriteLine($"Сумма элементов на нечётных позициях = {SumOddIndex(numbers)}");

