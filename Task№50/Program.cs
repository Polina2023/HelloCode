
/* Задача 50. Напишите программу, которая на вход принимает позиции элемента 
в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
[1,7] -> по данным индексам такого числа в массиве нет*/

string UserMessage(string message){
    return $"Введите количество {message} >>> ";
}

int GetRows(){
    Console.Write($"{UserMessage("строк")}");
    int rows = Convert.ToInt32(Console.ReadLine());
    return rows;
}

int GetCols(){
    Console.Write($"{UserMessage("столбцов")}");
    int cols = Convert.ToInt32(Console.ReadLine());
    return cols;
}

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
int[,] GetMatrix(int[,]  matrix)
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int cols = 0; cols < matrix.GetLength(1); cols++)
        {
            if (cols <= rows)
            { 
                matrix[rows,cols] = Convert.ToInt32(matrix[rows,cols]); 
            }
            if (cols > 0 && rows > 0) 
            {
                Console.WriteLine($"{rows}, {cols} -> по данным индексам такого числа в массиве нет");
            }
        }
    }
    return matrix;
}

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);

GetMatrix(array);

