int x;
Console.WriteLine("Введите число ");
x = Convert.ToInt32(Console.ReadLine());
int y = -x;
while (y <= x)
{
    Console.WriteLine(y);
    y+=1;
}