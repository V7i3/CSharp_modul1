/* Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых,
 заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем. */


 string CrossingBeeline(double k1, double b1, double k2, double b2){

    double x = (b2-b1)/(k1-k2);
    double y = k1*(b2-b1)/(k1-k2) + b1;
    return $"({x}, {y})";
 }

void PrintEqation(int item, double k, double b){
    Console.WriteLine($"y{item} = {k}x + {b}");
}

 int Coordinates(int num, char letter){
    Console.Write($"Введите {letter}{num}: ");
    return Convert.ToInt32(Console.ReadLine());
 }


double b1 = Coordinates(1, 'b');
double k1 = Coordinates(1, 'k');
double b2 = Coordinates(2, 'b');
double k2 = Coordinates(2, 'k');

Console.WriteLine();

PrintEqation(1, k1, b1);
PrintEqation(2, k2, b2);

Console.WriteLine("Координаты: " + CrossingBeeline(k1, b1, k2, b2));