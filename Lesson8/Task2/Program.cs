/* Задача 2: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов. */

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

int MinLineSum(int[,] arr){
    int sum = 0;
    int intermediateSum = 0;
    int lineMin = 0;
    for (int i = 0; i < arr.GetLength(0); i++){
        intermediateSum = sum;
        sum = 0;
        for(int j = 0; j < arr.GetLength(1); j++){
            sum += arr[i, j];
        }
        if (intermediateSum > sum){
            lineMin = i;
        }
    }

    return lineMin;
}  

int[,] array = FillArray(3, 4);
PrintArray(array);

DescendingRowElements(array);
Console.WriteLine($"Строка с минимальной суммой = : {MinLineSum(array) + 1}");
