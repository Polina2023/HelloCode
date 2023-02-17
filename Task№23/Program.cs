Console.Write("Ввести число: ");
int N = int.Parse(Console.ReadLine()!);
int x = 1;
while(x <= N)
{
    int y = x*x*x;
    Console.WriteLine(y);
    x++;
}
