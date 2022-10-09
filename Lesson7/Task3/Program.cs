/* Задача 3. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце. */

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
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}


void AverageColumnPrint(int[,] array){

    double sum = 0;
    double counter = 0;
    double avarage;
    for (int j = 0; j < array.GetLength(1); j++){
        for(int i = 0; i < array.GetLength(0); i++){
            sum += array[i, j];
            counter++;
        }
        avarage = sum/counter;
        if (avarage * 10 % 10 != 0){
            Console.WriteLine($"Среднее арифметическое {j + 1}-столбца = {String.Format("{0:F1}", avarage)}");
        }
        else
            Console.WriteLine($"Среднее арифметическое {j + 1}-столбца = {avarage}");
        sum = 0;
        counter = 0;
    }
}

int[,] arr = FillArray(3, 4);
PrintArray(arr);
AverageColumnPrint(arr);