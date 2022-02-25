Console.WriteLine("введите число");
int a = Convert.ToInt32(Console.ReadLine());
int b = a *(-1);
/* Console.WriteLine(b); */
if (a < b)
    {
        while (a <= b)
         {
            Console.Write(a+ " ");
            a = a+1;
         }
    }
else
    {
        while (b <= a)
         {
            Console.Write(b+ " ");
            b = b+1;
         }
    }
