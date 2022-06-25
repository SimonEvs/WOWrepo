int a =0;
Console.Clear();
Console.WriteLine("Найдем наибольшее число!");
Console.WriteLine("Введите первое число: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine("Найдем наибольшее число!");
Console.WriteLine("Введите второе число: ");
int second = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine("Найдем наибольшее число!");
Console.WriteLine("Введите третье число: ");
int third = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.Write("Ура, вы нашли его, это число!!! ");
if (first> second)
a = first;
else
a= second;

if (a<third)
a = third;
Console.WriteLine("И это число: " + a);