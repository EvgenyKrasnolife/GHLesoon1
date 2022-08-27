int x;
Console.WriteLine("Введите число: ");
x = Convert.ToInt32(Console.ReadLine());

if (x % 7 == 0)
if (x % 23 == 0)
Console.WriteLine("Число кратное 7 и 23");
else
Console.WriteLine("Не делится на 7 и 23 без остатка");
