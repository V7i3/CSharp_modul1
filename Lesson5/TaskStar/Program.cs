/* Задача со звездочкой: Заполнить массив четной длины таким образом,
 чтобы значение элемента массива повторялось ровно 2 раза. */

void PrintArray(int[] arr){

    Console.Write("[ ");

    foreach(int i in arr){
        Console.Write($"{i} ");
    }

    Console.Write("]");
}


int[] FillArray(int[] arr){

    Random rnd = new Random();
    int counter = 0;
    int enumerator = 0;
    int flag = arr.Length;
    int number;
    int index;

    while(flag > 0){
        number = rnd.Next(1, 10);

        for (int j = 0; j < arr.Length; j++){
            if (number == arr[j]){
                enumerator++;
                break;
            }
        }
        
        if(enumerator == 0){
            while(counter != 2){
                index = rnd.Next(arr.Length);
                if (arr[index] == 0){
                    arr[index] = number;
                    counter++;
                    flag--;
                }
            }
        }
        else 
            number = rnd.Next(1, 10);

        counter = 0;
    }
    return arr;
}


Console.Write("Введите размерность массива (чётное число): ");
int N = Convert.ToInt32(Console.ReadLine());
if (N % 2 ==0){
    int[] array = new int[N];
    PrintArray(FillArray(array));
}
else{
    Console.Write("Вы ввели нечётное число");
}


