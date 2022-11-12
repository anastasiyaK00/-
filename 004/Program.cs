// По заданному с клавиатуры номеру дня недели вывести его название


int a=1; //Monday
int b=2; //Tuesday
int c=3; //Wednesday
int d=4; //Thursday
int e=5; //Friday
int f=6; //Saturday
int g=7; //Sunday

int i;

System.Console.WriteLine("Введите номер дня недели: ");
string? s=Console.ReadLine();
i=Convert.ToInt32(s);

if (i==a)
{
System.Console.WriteLine("Monday");
}
if (i==b) 
{ 
    System.Console.WriteLine("Tuesday");
}
if (i==c) 
{ 
    System.Console.WriteLine("Wednesday");
}
if (i==d)
{
System.Console.WriteLine("Thursday");
}
if (i==e) 
{ 
    System.Console.WriteLine("Saturday");
}
if (i==f) 
{ 
    System.Console.WriteLine("Wednesday");
}
if (i==g) 
{ 
    System.Console.WriteLine("Sunday");
}

