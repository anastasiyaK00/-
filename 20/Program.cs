/* Определить номер четверти плоскости, 
   в которой находится точка с координатами Х и У, 
   причем X ≠ 0 и Y ≠ 0
*/
System.Console.WriteLine("Введите X");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите Y");
int y = Convert.ToInt32(Console.ReadLine());

if (x<0 && y>0) System.Console.WriteLine("Первая четверть плоскости, где x=(0;-x), y=(0;+y)");
if (x>0 && y>0) System.Console.WriteLine("Вторая четверть плоскости, где x=(0;+x), y=(0;+y)");
if (x<0 && y<0) System.Console.WriteLine("Третья четверть плоскости, где x=(0;-x), y=(0;-y)");
if (x>0 && y<0) System.Console.WriteLine("Четвертая четверть плоскости, где x=(1;+x), y=(0;-y)");
