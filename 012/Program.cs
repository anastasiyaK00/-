/* С клавиатуры вводится целое число из диапазона  [10, 99]. 
Показать наибольшую цифру числа
*/
System.Console.WriteLine("Введите число от 10 до 99 ");
int n=Convert.ToInt32(Console.ReadLine());

int s;
s=n%10;

double a;
a=n/10;

if (s>a)
{
   System.Console.WriteLine($"{s}"); // показывает второе число 
}
else 
{
   System.Console.WriteLine($"{a}"); //показывает первое число
}