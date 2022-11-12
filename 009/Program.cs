// Вывести на экран четные числа от 1 до N
System.Console.WriteLine("Введите число ");
int n=Convert.ToInt32(Console.ReadLine());
int i=2;
while (i<=n)
{
    System.Console.Write($"{i} ");
    i=i+2;
}

System.Console.WriteLine();
for(int j=1;j<=n;j=j+1)
{
    if(j%2==0)
    {
        System.Console.Write($"{j} ");
    }
}
