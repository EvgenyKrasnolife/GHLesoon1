int x;
Console.WriteLine("Введите число ");
x = Convert.ToInt32(Console.ReadLine());
int y = 1;
while(y <= x)
{
    if (y % 2 == 0){
        Console.WriteLine(y);
    }
    y+=1;
}