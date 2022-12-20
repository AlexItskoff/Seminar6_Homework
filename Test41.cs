/*Задача 41: Пользователь вводит с клавиатуры M чисел.
 Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

Console.WriteLine("Enter length of array");       // Имитируем ввод пользователем произвольного 
int arrayLength = int.Parse(Console.ReadLine()!);   // количетва положительных и отрицательных чисел

int[] array = CreateArray(arrayLength, -500, 500);    // Создаем массив
PrintArray(array);                                    // Выводим массив на печать
CountPositiveNumbers(array);                          // Считаем количество положительных чисел

int[] CreateArray(int length, int minValue, int maxValue)  // Функция создания массива
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
    return array;
}

void PrintArray(int[] arr)                                     // Прцедура печати массива
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void CountPositiveNumbers(int[] arr)                     // Процедура подсчета положительных чисел
{
    int count = 0;
     for (int i = 0; i < arrayLength; i++)
     {
        if (arr[i]>0)
        {
            count = count +1;
        }
    }
        Console.WriteLine( " amount of positive numbers" +  " - "  + count);
 } 
 