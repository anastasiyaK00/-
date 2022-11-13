// Выяснить является ли число чётным.

System.Console.WriteLine("Введите число ");
int K=Convert.ToInt32(Console.ReadLine());


if (K%2==0)
{
  System.Console.WriteLine($"{K}-число четное");  
}
else System.Console.WriteLine($"{K}-число нечетное"); 
