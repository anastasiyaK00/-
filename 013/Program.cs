﻿// Удалить вторую цифру целого числа введенного с клавиатуры.

int a=Convert.ToInt32(Console.ReadLine());
//345=35|12345=1345

int b=a/100*10+a%10; //Делим на 100 и получаем цифру без последих двух чисел
System.Console.WriteLine(b);

