// Программа проверяет пятизначное число на палиндромом.
System.Console.WriteLine("Введите пятизначное число: ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"{x}");

int a=x%10;
int b=(x%100-a)/10;
int c=(x%1000-b)/100;
int d=(x%10000-c)/1000;
int e=(x-x%10000)/10000;
    System.Console.WriteLine($"{a},{b},{c},{d},{e}");
int a1=(x-x%10000)/10000;
int b1=(x%10000-c)/1000;
int c1=(x%1000-b)/100;
int d1=(x%100-a)/10;
int e1=x%10;
    System.Console.WriteLine($"{a1},{b1},{c1},{d1},{e1}");

    if (a==a1 && b==b1 && c==c1 && d==d1 && e==e1) System.Console.WriteLine("Yes");
    else System.Console.WriteLine("no");
