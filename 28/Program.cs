// Определить количество цифр в числе. Сделать подпрограмму.
 //Подпрограмма

int CountDigits(int Number)
{
    Number=Math.Abs(Number);
    int count=0;
    if (Number==0) count=1;
    while (Number>0)
    {
        Number=Number/10;
        count++;
    }
    return count;
}
//Основная программа
int N=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(CountDigits(N));
/*
int N=Convert.ToInt32(Console.ReadLine());
N=Math.Abs(N);//и положительное и отрицательное значение
int count=0;
if(N==0) count=1;// пограничный случай, чтобы при значении 0, результат не был 0, а был 1, т.к 0-это одна цифра!
while (N>0)
{
    N=N/10;
    count++;
}
System.Console.WriteLine(count);
*/