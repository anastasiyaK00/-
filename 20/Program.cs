// Определить номер четверти плоскости, 
// в которой находится точка с координатами Х и У, 
// причем X ≠ 0 и Y ≠ 0

System.Console.WriteLine("Введите X");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите Y");
int y = Convert.ToInt32(Console.ReadLine());

if (x<0 && y>0) System.Console.WriteLine("Первая четверть плоскости, где x=(0;-x), y=(0;+y)");
if (x>0 && y>0) System.Console.WriteLine("Вторая четверть плоскости, где x=(0;+x), y=(0;+y)");
if (x<0 && y<0) System.Console.WriteLine("Третья четверть плоскости, где x=(0;-x), y=(0;-y)");
if (x>0 && y<0) System.Console.WriteLine("Четвертая четверть плоскости, где x=(1;+x), y=(0;-y)");


//ПРИМЕР NET6
/*class Program
{
    static int Part(double x, double y)
    {
        //тело подпрограммы
        if (x < 0 && y > 0) return 1;
        if (x > 0 && y > 0) return 2;
        if (x < 0 && y < 0) return 3;
        if (x > 0 && y < 0) return 4;
        return 0;
    }

    static void Pause()
    {
        System.Console.WriteLine("press any key");
        Console.ReadKey();
    }

    static void Pause(string message) //перегрузка по аргументам
    {
        System.Console.WriteLine(message);
        Console.ReadKey();
    }

    static void Pause(int i)
    {

    }

    static void Main()
    {
        double x = Convert.ToDouble(Console.ReadLine());
        double y = Convert.ToDouble(Console.ReadLine());
        int p = Part(x, y);
        System.Console.WriteLine("part:" + p);
        Pause("Нажмите любую клавишу");
    }
}
*/