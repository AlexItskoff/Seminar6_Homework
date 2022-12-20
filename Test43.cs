/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

// Вводим начальные значения переменных ******************************
Console.WriteLine("Enter b1");
double b1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter k1");
double k1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter b2");
double b2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter k2");
double k2 = int.Parse(Console.ReadLine()!);
// Проверяем, что прямые не параллельны ***********************************
if (k1 == k2)
{
    Console.WriteLine("Lines are parallel! Crossing point does not exist!");
    return;
}
//***********************************************************************************
double [] CrossingPoint =  CrossingLines(b1, k1, b2, k2);  // Создаем массив, дающий искомые координаты
Console.WriteLine("x = " + CrossingPoint[0]);             // Выводи конечный  резульат на печать
Console.WriteLine("y = " +CrossingPoint[1]);

//************************************************************************************
// Функция, создающая массив из двух вещественных чисел. 
// Координаты точки пересечения могут быть дробными
double []  CrossingLines (double b1, double k1, double b2, double k2) 
  {
    double[] result = new double[2];
    double x = (b2 - b1)/ (k1 - k2);
    double y = (k1 * (b2 - b1) / (k1 - k2)) + b1;

    result [0] = x;
    result [1] = y;
    return (result);

    }
// ***********************************************************************************