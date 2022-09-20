// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine("Введите трехзначное число: ");
// int number = int.Parse(Console.ReadLine());
// int num1 = number / 100;
// int num2 = number % 10;
// int result = (number - (num1 * 100 + num2))/10;
// Console.WriteLine(number);
// Console.Write($"Получили число {result}");

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

// Console.Write("Введи число: ");
// int Number = int.Parse(Console.ReadLine());
// string NumberText = Convert.ToString(Number);
// if (NumberText.Length > 2){
//   Console.WriteLine($"Третья цифра числа равна {NumberText[2]}");
// }
// else {
//   Console.WriteLine("Третьей цифры нет");
// }

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введи цифру, обозначающую день недели: ");
int Number = int.Parse(Console.ReadLine());

//Первый вариант

// if (Number == 6 || Number == 7)
// {
//     Console.WriteLine("этот день выходной");
// }
// else if (Number < 1 || Number > 7)
// {
//     Console.WriteLine("С какой ты планеты? В неделе нет такого количества дней");
// }
// else 
// {
//     Console.WriteLine("этот день рабочий");
// }

//Второй вариант

if (Number >=1 && Number <=5)
{
    Console.WriteLine("Этот день рабочий");
}
if (Number == 6 || Number == 7)
{
    Console.WriteLine("Этот день выходной");
}
else 
{
Console.WriteLine("С какой ты планеты? В неделе нет такого количества дней!");
}