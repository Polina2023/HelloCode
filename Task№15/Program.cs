int num = new Random().Next(1, 8);
Console.WriteLine(num);
if(num == 6 || num == 7)
{
    Console.WriteLine("Выходной");
}
else
{
    Console.WriteLine("Нет");
}
