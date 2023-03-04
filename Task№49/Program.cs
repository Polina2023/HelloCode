// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int Array(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int[] GetArray(int Length)
{
    int[] array = new int[Length];
    for (int i = 0; i < array.Length; i++)
    {
       array[i] = Array($"Введите {i + 1} элементы массива");
    }
    return array;
}
void FindNumber(int[] arr)
{
    int positiveSum = 0;  
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]  > 0)
        {
        positiveSum++;
        }
         
    }
Console.WriteLine($"Сумма чисел больше 0 = {positiveSum} "); 
}
int[] array = GetArray(5);
Console.WriteLine();
FindNumber(array);