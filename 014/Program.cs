/* С клавиатуры вводятся два числа a и b. 
Выяснить, кратно ли число a числу b, если нет, вывести остаток от деления a на b.
*/

System.Console.WriteLine("Введите число a ");
double a=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число b ");
double b=Convert.ToInt32(Console.ReadLine());

double c; c=a/b;

if (a%b==0)
{
  System.Console.WriteLine($"c={c}(А значит,число a кратно числу b)");  
}
else 
{
  System.Console.WriteLine ($"Остаток от деления a на b ={a%b} (А значит, число a не кратно числу b)");   
}

/*
double n;
n=a%b;
System.Console.WriteLine ($"c={c} (А значит,число нечетное)"); 
*/