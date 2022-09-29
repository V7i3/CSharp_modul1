/* Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. */

int[] array = new int[8];
Console.Write("Введите числа через запятую: ");
string numbers = Console.ReadLine();

Console.Write("Массив: ");
WriteArray(ReadArray(array, numbers));

int[] ReadArray(int[] arr, string str){

    string number = String.Empty;
    int j = 0;

    for (int i = 0; i < arr.Length; i++){

        for(; j < str.Length; j++) {

            if (str[j] != ' ' || str[j] != ','){
                number += str[j];
            }
            else {
                break;
            }
        }
        arr[i] = Convert.ToInt32(number);
        number = String.Empty;
    }
    return arr;
}

void WriteArray(int[] arr){
    for (int i = 0; i < arr.Length; i++){
        if (i+1 < arr.Length){
            Console.Write($"{arr[i]}, ");
        }
        else
            Console.Write($"{arr[i]}");
    }
}