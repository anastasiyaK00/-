// С клавиатуры вводится целое число. Вывести третью цифру числа или сообщить, что её нет (Вывести: NO).

System.Console.WriteLine("Введите число ");
int a=Convert.ToInt32(Console.ReadLine());
a=Math.Abs(a);
if (a<99)
{
    System.Console.WriteLine("NO");
}
else 
{
    while (a>999)
    {
       a=a/10; 
    }
     a=a%10;
     System.Console.WriteLine($"{a}");
}




/*
{
    s=(a/1000*100+a%100);
System.Console.WriteLine($"{s}");
}

int b=a/100*10+a%10;

if (a>99)
{
s=a-10;
i=i+1;
System.Console.WriteLine($"{i}");
}
else System.Console.WriteLine("NO");
*/