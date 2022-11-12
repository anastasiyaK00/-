/*
int a=0, b=0, c=0;
float f=20.4f;
double d=3.14;
string s="hello";
char c='a';
bool flag=true;
int переменная1=0;
*/
//С клавиатуры вводится целое число. Вывести квадрат числа (блок-схема)
#region Мой код
Console.WriteLine("Hello");
#endregion

int a;
a=10;
System.Console.WriteLine("введите число:");
string? s=Console.ReadLine();// string?(строчка). Здесь присваивается строчка, но не значение 
a=Convert.ToInt32(s);// Комманда ToInt32 позволяет строчку преобразовать в значение!!т.о мы получаем значение.
int b=a*a;
System.Console.WriteLine($"{a}^2={b}");