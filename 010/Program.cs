// Вывести на экран последнюю цифру целого числа введенного с клавиатуры.
System.Console.WriteLine("Введите число ");
int n=Convert.ToInt32(Console.ReadLine());

int s;
s=n%10;
System.Console.WriteLine($"{s}");
