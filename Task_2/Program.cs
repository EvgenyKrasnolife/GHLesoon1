int x;
Console.WriteLine("Введите первое число ");
x = Convert.ToInt32(Console.ReadLine());
int y;
Console.WriteLine("Введите второе число ");
y = Convert.ToInt32(Console.ReadLine());

if ( x > y)
{
Console.Write ("Большее число ");
Console.WriteLine (x);
}
else if (x==y)
{
Console.WriteLine ("Эти числа равны");
}
else
{
Console.Write ("Большее число ");
Console.WriteLine (y);
}