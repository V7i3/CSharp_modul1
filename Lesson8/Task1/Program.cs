/* Задача 1: Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива. */


int[,] FillArray(int line, int column){

    int[,] array = new int[line, column];

        for (int i = 0; i < array.GetLength(0); i++){
            for(int j = 0; j < array.GetLength(1); j++){
                array[i, j] = new Random().Next(0, 10);
            }
        }

    return array;
}

void PrintArray(int[,] array){

    for (int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
                Console.Write(array[i, j] + "   ");
            }
        Console.WriteLine();
    }
}

void DescendingRowElements(int[,] arr){
    int intermediate;
    for (int i = 0; i < arr.GetLength(0); i++){
        for(int j = 0; j < arr.GetLength(1) - 1; j++){
            if(arr[i,j] > arr[i, j + 1]){
                intermediate = arr[i, j];
                arr[i, j] = arr[i, j + 1];
                arr[i, j + 1] = intermediate;
            }
        }
    }
}  

Console.Write("Введите количество строк массива: ");
int line = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] array = FillArray(line, column);
PrintArray(array);

DescendingRowElements(array);
Console.WriteLine("Упорядоченный массив: ");
PrintArray(array);
