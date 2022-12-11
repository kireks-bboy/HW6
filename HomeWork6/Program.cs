// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


// void Func(int[] arr, int count)
// {
//   for (int i = 0; i < arr.Length; i++)
//   {
//     if (arr[i] > 0)
//     {
//       count++;
//     }
//   }
//   Console.WriteLine($"Кол-во элементов > 0: {count}");
// }



// Console.Write("Введите элементы(через пробел): ");
// int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
// int count = 0;
// Func(arr, count);








// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void IntPoint(double k1, double b1, double k2, double b2)
{
    if(k1 == k2)
    {
        Console.WriteLine();
        Console.WriteLine($"Линии параллельны.");
    }
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k2 * x + b2;

        Console.WriteLine();
        Console.WriteLine($"Точка пересечения двух прямых это:");
        Console.WriteLine($"{x}, {y}");
    }
}

Console.WriteLine("Программа найдет точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2");
Console.WriteLine();

// Ввод параметров первой прямой
Console.WriteLine("Пожалуйста, задайте параметры для первой строки:");

Console.WriteLine("Введите значение для K1:");
double k1 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите значение для B1:");
double b1 = double.Parse(Console.ReadLine()!);

//Ввод параметров второй прямой
Console.WriteLine();
Console.WriteLine("Пожалуйста, задайте параметры для второй строки:");

Console.WriteLine("Введите значение для K2:");
double k2 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите значение для B2:");
double b2 = double.Parse(Console.ReadLine()!);



IntPoint(k1, b1, k2, b2);






