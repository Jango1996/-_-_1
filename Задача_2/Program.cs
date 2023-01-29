// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


Console.WriteLine("Введите два числа и мы скажем какое больще, а кокое меньше. ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

if (a < b)
{
    Console.WriteLine("Максимальное число " + b);
    Console.WriteLine("Минимальное число " + a);
}
else if (b < a)
{
    Console.WriteLine("Максимальное число " + a);
    Console.WriteLine("Минимальное число " + b);
}
else
{
    Console.WriteLine("Числа равны");
}