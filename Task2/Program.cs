﻿// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num<100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    string i =Convert.ToString(num);
    Console.WriteLine(i[2]);
}