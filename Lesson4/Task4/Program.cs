/* Задачи 4: (*) Напишите программу, которая задаёт массив из 8 элементов случайными числами 
и выводит их на экран. Также ищет второй максимум 
(число меньше максимального элемента, но больше всех остальных) */


void FillArray(int[] arr){
    Random rnd = new Random();

    for(int i = 0; i < arr.Length; i++){
        arr[i] = rnd.Next(1, 10);
    }
}

void PrintArray(int[] array){
    Console.Write("Массив: ");
    for (int i = 0; i < array.Length; i++){
        if(i + 1 < array.Length){
            Console.Write($"{array[i]}, ");
        }
        else
            Console.WriteLine(array[i]);
    }
}

int[] SortArr(int[] array){
    for(int i = 0; i < array.Length - 1; i++){
        int min = i;
        for (int j = i + 1; j < array.Length; j++){
            if (array[j] < array[min]){
                min = j;
            }
        }
        int index = array[i];
        array[i] = array[min];
        array[min] = index;
    }
    return array;
}

int MaxTwo(int[] array){
    
    //Второй максимум через сортированный массив

    int max = array[array.Length - 1];
    int max2 = -1;
    for(int i = array.Length - 1; i >= 0; i--){
        if(array[i] < max){
            max2 = array[i];
            break;
        }
    }
    return max2;
    
    //Второй максимум без сортировки массива
    /* 
    int max = array[0];
    int max2 = -1;

    for (int i = 0; i < array.Length; i++){
        if (array[i] > max){
            max2 = max;
            max = array[i];
        }
    }

    return max2; */
}


int[] numbers = new int[8];
FillArray(numbers);
PrintArray(numbers);
SortArr(numbers);
Console.WriteLine("Второй максимум = " + MaxTwo(numbers));