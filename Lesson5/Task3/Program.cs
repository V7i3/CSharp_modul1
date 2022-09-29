/* Задача 3: Задайте массив вещественных чисел.
 Найдите разницу между максимальным и минимальным элементов массива. */

 double[] numbers = new double[5];

void FillArray(double[] arr){
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++){
        arr[i] = Convert.ToDouble(rnd.Next(1, 100)/10.0);
    }
}

void PrintArray(double[] arr){
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++){
        if (i + 1 < arr.Length){
            Console.Write($"{arr[i]}; ");
        }
        else
            Console.Write(arr[i]);
    }
    Console.WriteLine(" ]");
}

double SumMaxMin(double[] arr){
    double max = arr[0];
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++){
        if (arr[i] > max){
            max = arr[i];
        }
        else 
            if (arr[i] < min){
                min = arr[i];
            }
    }
    return max + min;
}

FillArray(numbers);
PrintArray(numbers);
Console.WriteLine("Сумма максимального и минимального элемента = " + "{0,2:N1}", SumMaxMin(numbers));
