Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] nums = new int[5];

if (number <= 99999 || number >= 10000)
{
    Array(nums, number);
    if ( nums[0] == nums[4] && nums[1] == nums[3])
        Console.WriteLine("Вы ввели палиндром");
    else
        Console.WriteLine("Вы ввели не палиндром");
}
else 
     Console.WriteLine("Вы ввели не пятизначное число!");     

void Array(int[] arr, int num){
    arr[0] = num%10;
    arr[1] = num%100/10;
    arr[2] = num%1000/100;
    arr[3] = num%10000/1000; 
    arr[4] = num/10000;
}
