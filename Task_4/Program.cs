int a;
Console.WriteLine("Введите первое число ");
a = Convert.ToInt32(Console.ReadLine());
int b;
Console.WriteLine("Введите второе число ");
b = Convert.ToInt32(Console.ReadLine());
int c;
Console.WriteLine("Введите третье число ");
c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}
Console.WriteLine ("Число " + max + " максимальное из этих чисел");