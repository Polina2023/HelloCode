/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

string UserMessage(string message)
{
    return $"Введите {message} >>> ";
}

int GetRows(string message){
    Console.Write($"{UserMessage(message)}");
    int rows = Convert.ToInt32(Console.ReadLine());
    return rows;
}

int GetCols(string message){
    Console.Write($"{UserMessage(message)}");
    int cols = Convert.ToInt32(Console.ReadLine());
    return cols;
}
int[,] array = new int[5, 5];
void FillArray(int[,] array)
{
    for (int rows = 0; rows < array.GetLength(0); rows++)
    {
        for (int cols = 0; cols < array.GetLength(1); cols++)
        {
            array[rows, cols] = new Random().Next(1, 10);

        }    
    }
}

void PrintArray(int[,] array)
{
    for (int rows = 0; rows < array.GetLength(0); rows++)
    {
        for (int cols = 0; cols < array.GetLength(1); cols++)
        {
            Console.Write(array[rows,cols] + " ");
        }
        Console.WriteLine();
    }
}
void GetArray(int[,] array)
{
    for (int rows = 0; rows < array.GetLength(1); rows++)
    {
        for (int cols = 0; cols < array.GetLength(1); cols++)
        {
            for (int N = 0; N < array.GetLength(1) - 1; N++)
            {
                if (array[rows, cols] < array[rows, N + 1])
                {
                    int temp = array[rows, N + 1];
                    array[rows, N + 1] = array[rows, N];
                    array[rows, N] = temp;
                }
            }
        }
    }  
}

void Task53()
{
    FillArray(array);
    Console.WriteLine("Начальный массив");
    PrintArray(array);
    GetArray(array);
    Console.WriteLine("Новый массив");
    PrintArray(array);

}
Task53();


