/* Задача 3: (*)
Найдите максимальное значение в матрице по каждой строке, получите сумму этих максимумов.
Затем найдите минимальное значение по каждой колонке,получите сумму этих минимумов. 
Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами) */


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

int SumMaxItem(int[,] array){

    int sum = 0;
    int max;
    for (int i = 0; i < array.GetLength(0); i++){
        max  = array[i, 0];
        for(int j = 0; j < array.GetLength(1); j++){
            if (array[i, j] > max){
                max = array[i, j];
            }
        }
        sum+=max;
    }
    return sum;
}

int SumMinItem(int[,] array){

    int sum = 0; 
    int min;
    for (int j = 0; j < array.GetLength(1); j++){
        min = array[0, j];
        for(int i = 0; i < array.GetLength(0); i++){
            if (array[i, j] < min){
                min= array[i, j];
            }
        }
        sum+=min;
    }
    return sum;
}

int[,] arr = FillArray(2, 3);
PrintArray(arr);

Console.WriteLine("----------------------------");
Console.WriteLine("Сумма максимальных значений строк = " + SumMaxItem(arr));
Console.WriteLine("Сумма минимальных значений столбцов = " + SumMinItem(arr));
Console.WriteLine("----------------------------");
Console.WriteLine($"Разница значений сумм =  {SumMaxItem(arr) - SumMinItem(arr)} ");