int num = new Random().Next(10, 1000);
Console.WriteLine(num);
int A = num/100;
int B = num%10;
if(A != 0)
{
    Console.WriteLine(B);
}
else
{
    Console.WriteLine("третьей цифры нет");
}
