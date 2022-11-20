// 
/*Алгоритм эвклида

int a = 10;
int b = 5;

while (a != b)
    if (a > b)
        a = a - b;
    else
        b = b - a;
System.Console.WriteLine(a);
*/

/*Алгоритм Эвклида с подпрограммой 
int GCD(int a, int b)
{
    while (a != b)
        if (a > b)
            a = a - b;
        else
            b = b - a;
    return a;
}
System.Console.WriteLine(GCD(10, 30));
*/

//Ускоренный Алгоритм Эвклида
int k = 0;

int GCD(int a, int b)
{
    while (a != b)
    {
        k++;
        if (a > b)
            a = a - b;
        else
            b = b - a;
    }
    return a;
}

int QuickGCD(int a, int b)
{
    while (a != 0 && b != 0)
    {
        k++;
        if (a > b)
            a = a % b;
        else
            b = b % a;
    }
    return a + b;
}
System.Console.WriteLine(GCD(5, 50));
System.Console.WriteLine(k);
k = 0;
System.Console.WriteLine(QuickGCD(5, 50));
System.Console.WriteLine(k);
