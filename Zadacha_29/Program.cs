/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

int[] GetArray(int size)
{
    int[] result = new int[size]; 
    for (int i = 0; i < result.Length; i++) 
    {
        //[min; max+1);
        result[i] = new Random().Next(100);
    }
    return result;
}

int [] Array = GetArray(8);
Console.WriteLine($"Массив из 8 элементов: [ {String.Join("; ", Array)} ]");

