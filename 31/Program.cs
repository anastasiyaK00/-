// Сгенерировать 10 случайных чисел. Показать кубы тех чисел, заканчивающихся на четную цифру
/*
------Так мы создаем как бы подпрограмму рандома и 
       дальше можем вызвать просто рандом и вводить чразу числа:
  Random random=new Random();
  random.Next(1,100); 

-------Так вводим рандом полностью:
//new Random().Next(1,100); Так показывали на лекции.
*/
/*

int r = 10;
double t = r; //неявное приведение типов
double x = 23;
//int o=Convert.ToInt32(x);
int o = (int)x;//Явное приведение типов 
*/

bool Test(int a) //Подпрограмма, проверяющая подходит или не подходит число под условия задачи.
{
    //if(a%2==0) return true; else return false;
    return a * a * a % 2 == 0;
}

Random random = new Random();
for (int i = 0; i < 5; i++)
{
    int a = random.Next(1, 100);
    int b = (int)Math.Pow(a, 3);
    if (Test(b))
        System.Console.WriteLine($"Случайное число={a}, Куб этого числа={b}");
}

/*Программа 1(не с 10 числами)
Random random = new Random();
for (int i = 0; i < 5; i++)
{
    int a = random.Next(1, 100);
    int b = (int)Math.Pow(a, 3);
    if (b % 10 % 2 == 0)
        System.Console.WriteLine($"Случайное число={a}, Куб этого числа={b}");
}
*/
/*
Random random = new Random();
for (int i = 0; i < 5; i++)
{
    int a = random.Next(1, 100);
    int b =a; || (int)Math.Pow(a, 3);
    if (b % 2 == 0)
        System.Console.WriteLine($"Случайное число={a}, Куб этого числа={b}");
}
*/