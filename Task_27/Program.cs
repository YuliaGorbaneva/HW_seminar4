// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Write number: ");

int number = int.Parse(Console.ReadLine());
int sum = 0;
for (int i = 0; i < number+1; i++)
{
    sum = sum + i;
}
Console.WriteLine(sum);