/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/
//Создаем функцию GetFormNumbers
int GetFormNumbers(int numberA, int numberB)
{
    int form = numberA;
    int start = 2;
    while(start <= numberB)
    {
        form = form*numberA;
        start++;
    }
    return form;
}
Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Число А в степени В = {GetFormNumbers(numberA, numberB)}");

/*Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5*/

//Вариант с использованием string.

/*Console.Write("Введите любое число: ");
string inputNumber = Console.ReadLine(); 
Console.Write("В числе " + inputNumber.Length + " цифры");*/

// Математический вариант решения.

/*int number = Convert.ToInt32(Console.ReadLine());

int GetCountNumbers(int digit)
{
    int count = 0; // чисел 0
    while (digit > 0)
    {
        count++;
        digit /= 10;
    }
    return count;
}

Console.WriteLine(GetCountNumbers(number));*/


