/* С клавиатуры вводится целое число из диапазона  [10, 99]. 
Показать наибольшую цифру числа
*/
int n;
do
{
System.Console.WriteLine("Введите число от 10 до 99 ");
n=Convert.ToInt32(Console.ReadLine());
}
while (n<10 || n>99);

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