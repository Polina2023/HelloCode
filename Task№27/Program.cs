int SumNumbers (int number)
{
    int result = 0;
    while(number > 0)
    {
       result += number % 10;
        number = number /10;
    }
    return result;
}
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.Write($"Сумма цифр в числе: {SumNumbers(number)}");


