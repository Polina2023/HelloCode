Console.WriteLine(" Введите первое число");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine(" Введите второе число");
int numberB = int.Parse(Console.ReadLine());
Console.WriteLine(" Введите третье число");
int numberC = int.Parse(Console.ReadLine());

if((numberA > numberB) && (numberA > numberC))
{
Console.Write(numberA);
}
else
{
if(numberB > numberC)
{
Console.Write(numberB);
}

else
{
Console.Write(numberC);
}
}
