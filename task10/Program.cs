// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.WriteLine("Введите трёхзначное число:");
int number = Convert.ToInt32(Console.ReadLine()); 
// Вариант с вводом числа с клавиатуры.Оставил его так как требуется ввод с клавиатуры по условию задачи.

// int number = new Random().Next(100, 1000); 
// System.Console.WriteLine(number); 
//Вариант с системным вводом, отказался от него, так как не подходит по условию задачи.

int digit1 = number / 10;
int digit2 = digit1 % 10;

if (number >= 1000 || number < 100)
{
    Console.WriteLine($"Число {number} не является трёхзначным");
}
else
{
    Console.WriteLine($"-> {digit2}");
}
// If/else нужны только для ручного ввода данных, при системном подходе, 
// требуется только Console.WriteLine(digit2);.
