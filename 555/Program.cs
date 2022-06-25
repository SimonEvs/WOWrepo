Console.Clear();
double b,d;
int c;
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a==0)
Console.WriteLine("Ноль - четное число, гугл говорит так)");
else
{
b=a;//4.0
c=a/2;//2
d=b/2;//2.0
Console.Clear();
if (c!=d)
a=a-1;
else
Console.WriteLine(a);
}

Console.Clear();
Console.WriteLine("Список четных чисел до переменной N");
Console.Write(a +"; ");
while(a>4)
{a=a-2; Console.Write(a + "; ");}
Console.Write("2.");