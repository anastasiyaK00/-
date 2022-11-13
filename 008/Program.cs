// Вывести на экран числа от -N до N
System.Console.WriteLine("Введите число ");
int n=Convert.ToInt32(Console.ReadLine());
int i=-n;
while (i<=n)
{
    System.Console.Write($"{i} ");
    i=i+1;
}

//Но если мы вводим -N, то он не будет выводить....
// предполагаю, что нужно добавить еще цикл, но пока не понимаю как.
