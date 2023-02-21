
Console.WriteLine("ввести первое число: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("ввести второе число: ");
int B = int.Parse(Console.ReadLine()!);

int product = 1;
int number = 1;
for(number=1; number <= B; number++)
     {
         product = product * A;
     }    
Console.WriteLine($"Произведение чисел = {product}");