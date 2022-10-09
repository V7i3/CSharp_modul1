/* Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. */

double[,] FillArray(int line, int column){

    double[,] array = new double[line, column];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            array[i, j] = Convert.ToDouble(rnd.Next(-100, 100)/10.0);
        }
    }

    return array;
}

void PrintArray(double[,] array){

    for (int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write(array[i, j] + "   ");
        }
        Console.WriteLine();
    }
}

double[,] array = FillArray(3,4);
PrintArray(array);