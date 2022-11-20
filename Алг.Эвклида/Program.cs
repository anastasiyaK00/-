// 

int a = 10;
int b = 5;

while (a != b)
    if (a > b)
        a = a - b;
    else
        b = b - a;
System.Console.WriteLine(a);