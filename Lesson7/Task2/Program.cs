/* Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание, что такого элемента нет. */

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

void SearchItem(int[,] array, int lineSearch, int columnSearch){
    int number = -1;
    if (lineSearch <= array.GetLength(0) && columnSearch <= array.GetLength(1)){
        for (int i = 0; i < array.GetLength(0); i++){
            for(int j = 0; j < array.GetLength(1); j++){
                if (array[lineSearch, columnSearch] == array[i, j]){
                    number = array[i, j];
                }
            }
        }

        Console.WriteLine("Найденный  элемент: " + number);
    }
    else{
        Console.WriteLine("Такого элемента нет");
    }


}

int[,] arr = FillArray(3, 4);
PrintArray(arr);

Console.Write("Введите номер строки: ");
int line = Convert.ToInt32(Console.ReadLine()) - 1;

Console.Write("Введите номер столбца: ");
int column = Convert.ToInt32(Console.ReadLine()) - 1;

SearchItem(arr, line, column);
