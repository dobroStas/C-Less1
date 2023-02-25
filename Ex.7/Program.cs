// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = 0;
if (num >= 100 && num < 1000)
{
    num1 = (num % 10);
    Console.WriteLine(num1);
}
else
{
    Console.WriteLine("Error");
}