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
if (c==d)
Console.WriteLine(a + " четное");
else
Console.WriteLine(a + " нечетное");}