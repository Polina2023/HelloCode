/* Задача 52. Задайте двумерный массив из целых чисел.
 Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/


int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m,n];
    for(int i = 0; i<m;i++)
    {
        for(int j =0; j<n; j++)
        {
            result[i,j] = new Random().Next(minValue,maxValue);
            Console.Write($"{result[i,j]} ");
        }
        Console.WriteLine();
    }
    return result;
}
double GetAverageRevers(int[,] matrix)
{
    double sum = 0;
    int row = 0;
    for (int cols = 0; cols < matrix.GetLength(1); cols++)
    {
        sum = 0;
        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            sum = sum + matrix[rows,cols];
            row = rows+1;
        }
        sum = sum/row;
        Console.WriteLine(sum);
    }
    return sum;
}


Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);

Console.WriteLine(GetAverageRevers(array));