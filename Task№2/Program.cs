Console.WriteLine(" Введите первое число");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine(" Введите второе число");
int numberB = int.Parse(Console.ReadLine());
if(numberB > numberA)
{
Console.Write("Первое число меньше второго");
}
else
{
if(numberB == numberA)
{
Console.Write("Первое число равно второму");
}

else
{
Console.Write("Первое число больше второго");
}
}



