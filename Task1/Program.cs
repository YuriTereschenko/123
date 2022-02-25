int A = new int();
Console.WriteLine("Введите первое число");
A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int B = Convert.ToInt32(Console.ReadLine());
if (A==0 & B != 0)
{
    Console.WriteLine("Второе число не является квадратом первого");
}
else if (A==0 & B == 0)
{
    Console.WriteLine("Второе число является квадратом первого");
}
else if (B/A == A) 
{
    Console.WriteLine("Второе число является квадратом первого");
}
else
{
    Console.WriteLine("Второе число не является квадратом первого");
}
