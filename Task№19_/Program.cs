Console.WriteLine("Ввести пятизначное число: ");
int N = int.Parse(Console.ReadLine()!);
if(N/10000 == N%10 & N%10000/1000 == N%100/10)
{
    Console.Write("да");
}
else
{
    Console.Write("нет");
}   
