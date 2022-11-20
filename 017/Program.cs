// Дано число обозначающее день недели. 
//Выяснить является номер дня недели выходным

System.Console.WriteLine("Введите номер дня недели: ");
string? s=Console.ReadLine();
int p=Convert.ToInt32(s);
if (p==6) System.Console.WriteLine("Yeeees,it's Saturday"); 
if (p==7) System.Console.WriteLine("Yeeees,it's Sanday"); 
else System.Console.WriteLine("Noo,it's weekdays");

// Здесь можно было бы использовать массив, флаг, но я не понимаю зачем, 
//если такое решение намного проще и в условиях вроде как не указано использовать спешлкоманды




