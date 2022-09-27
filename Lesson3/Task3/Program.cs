/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. */

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[number+1];
Cube(arr);
PrintArr(arr);

void Cube(int[] number){
  for (int i = 0; i <  number.Length; i++){
    number[i] = Convert.ToInt32(Math.Pow(i, 3));
  }
}

void PrintArr(int[] array){
  for(int i = 1; i < array.Length; i++){
    if (i+1 >= array.Length)
       Console.Write(array[i]);
    else
       Console.Write(array[i]+ ",");
  }
} 
