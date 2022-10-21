/* ДЗ ! Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

Console.Write("Сколько чисел Вы хотите проверить? - ");
double m = Convert.ToInt32(Console.ReadLine());
double i = 0;
double count = 0;
while (i < m)
{
Console.Write("Введите число для проверки: ");
double n = Convert.ToInt32(Console.ReadLine());
if (n > 0)
{
    count += 1;
}
i++;
}
Console.Write($"Чисел больше 0: {count}");

/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

// Console.Write("Введите координатy прямой АА: ");
// double b1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координатy прямой АА: ");
// double k1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координатy прямой BB: ");
// double b2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координатy прямой BB: ");
// double k2 = Convert.ToInt32(Console.ReadLine());


// //y = k1 * x + b1;
// //y = k2 * x + b2;
// // k1 * x - k2 * x = b2 - b1;
// double z = k1 - k2;
// double x = (b2 - b1) / z;
// double y = k1 * x + b1;

// Console.WriteLine($"Точка пересечения двух прямых - ({x};{y})");