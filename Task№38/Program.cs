// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76

double[] GetArray(int size)
{
    double[] array = new double[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().NextDouble();
        Console.Write(array[i] + " ");
    }
    double max = array[0];
    double min = array[0];
    for(int m = 0; m < size; m++)
    {
         if (array[m] > max)
        {
        max = array[m];
        }
        if (array[m] < min)
        {
        min = array[m];
        }
    }   
Console.WriteLine($"Разница между элементами = {max} - {min} = {max - min}");
    return array;
}
double[] array = GetArray(5);

