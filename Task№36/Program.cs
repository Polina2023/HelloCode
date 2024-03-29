﻿// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0

int[] GetArray(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1, 20);
        Console.Write(array[i] + " ");
    }
    return array;
}
int FindSum(int[] arr)
{
    int count = 0;
    for(int index = 1; index < arr.Length; index++)
    {
        count += arr[index];
        index++;
    }
    return count;
}
int[] mass = GetArray(5);
Console.WriteLine();
Console.WriteLine($"сумма на нечетных позициях: {FindSum(mass)}");
