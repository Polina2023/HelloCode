/* Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/
int M = int.Parse(Console.ReadLine());
int N = int.Parse(Console.ReadLine());
int S = 0;
SumNaturalNumber2(N, M, S);

void SumNaturalNumber2(int number, int start, int summ)
{
summ = 0;
for (int i = start; i<=number; i++)
    {
        summ = summ + i;
    }
   Console.Write($"{summ} ");
}
