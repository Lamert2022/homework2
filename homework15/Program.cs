/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.Write("Введите номер дня недели: ");
var str = Console.ReadLine();

if (!int.TryParse(str, out int num))
{
    Console.WriteLine("Не является числом");
    return;
};

switch (num)
{
    case 6:
        Console.WriteLine("Выходной");
        break;
    case 7:
        Console.WriteLine("Выходной");
        break;
    default:
        Console.WriteLine("Будний день");
        break;
}
