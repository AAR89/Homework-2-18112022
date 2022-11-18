// // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// // что третьей цифры нет.

// // 645 -> 5

// // 78 -> третьей цифры нет

// // 32679 -> 6

// Console.Write("Введите число: ");
// int anyNumber = Convert.ToInt32(Console.ReadLine());
//ручной ввод
int anyNumber = new Random().Next();
System.Console.WriteLine(anyNumber);
// если долго играть в рулетку, то программа выдаст двузначное число, но что бы не мучаться? можно поставить
//int anyNumber = new Random().Next(0, 99);
//или использовать вариант с ручным вводом сверху.
string anyNumberText = Convert.ToString(anyNumber);
if (anyNumberText.Length > 2)
{
    Console.WriteLine("третья цифра -> " + anyNumberText[2]);
}
else
{
    Console.WriteLine("-> третьей цифры нет");
}
