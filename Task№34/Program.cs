// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите 
//программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] GetArray(int size)
{
    int[] arr = new int[size];
    for(int i =0; i < size; i++)
    {
        arr[i] = new Random().Next(100, 999);
        Console.Write(arr[i] + " ");
    }
    return arr;   
}
void FindSum(int[] arr)
{
    int positiveSum = 0;
    int negativeSum = 0;

    foreach (int el in arr)
    {
         if (el % 2 == 0)
        {
        positiveSum++;
        }
    }
Console.WriteLine($"Количество четных чисел = {positiveSum}");
}
int[] array = GetArray(6);
Console.WriteLine();
FindSum(array);


