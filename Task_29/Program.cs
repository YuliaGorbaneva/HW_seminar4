// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
Console.WriteLine("Ввудите длинну массивва: ");
int number = int.Parse(Console.ReadLine());

int [] array = new int [number];
for (int i = 0; i < number; i++)
{
    array[i] = new Random().Next(10, 100);
}
for (int i = 0; i < number; i++)
{
    Console.Write($"{array[i]}, ");
}
