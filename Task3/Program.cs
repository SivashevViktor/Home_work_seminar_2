// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());

switch (day)
{
    case 1:
        Console.WriteLine("не выходной - понедельник");
        break;
    case 2:
        Console.WriteLine("не выходной - вторник");
        break;
    case 3:
        Console.WriteLine("не выходной - среда");
        break;
    case 4:
        Console.WriteLine("не выходной - четверг");
        break;
    case 5:
        Console.WriteLine("не выходной - пятница");
        break;
    case 6:
        Console.WriteLine("выходной - суббота");
        break;
    case 7:
        Console.WriteLine("выходной - воскресенье");
        break;
    default:
        Console.WriteLine("Такого числа дня недели - НЕТ");
        break;

}
