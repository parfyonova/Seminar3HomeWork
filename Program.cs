/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
(можно решить через строку, а можно математически)
14212 -> нет, 12821 -> да, 23432 -> да */

// Вариант 1: Математический

// Console.Write("Введите пятизначное число: ");
// int num = int.Parse(Console.ReadLine()!);
// if((num < 10000) || (num > 99999)){
//     Console.Write("Введенное число не пятизначное");
// }
// else{
//     int i1 = num / 10000;
//     int i2 = num / 1000 - i1 * 10;
//     int i41 = num % 100;
//     int i4 = i41 / 10;
//     int i5 = num % 10;
//     if((i1 == i5) && (i2 == i4)){
//         Console.WriteLine($"Число {num} является полиноидом");
//     }
//     else{
//         Console.WriteLine($"Число {num} не является полиноидом");
//     }
// }

// Вариант 2: Через строку

// Console.Write("Введите пятизначное число: ");
// string num = Console.ReadLine()!;
// if(num.Length == 5){
//     if((num[0] == num[4]) && (num[1] == num[3])){
//         Console.WriteLine($"Число {num} является полиноидом");
//     }
//     else{
//         Console.WriteLine($"Число {num} не является полиноидом");
//     }
// }
// else{
//     Console.Write("Введенное число не пятизначное");
// }


/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

// Console.Write("Введите координату х точки А: ");
// double x1 = Convert.ToDouble(Console.ReadLine()!);
// Console.Write("Введите координату y точки А: ");
// double y1 = Convert.ToDouble(Console.ReadLine()!);
// Console.Write("Введите координату z точки А: ");
// double z1 = Convert.ToDouble(Console.ReadLine()!);
// Console.Write("Введите координату х точки B: ");
// double x2 = Convert.ToDouble(Console.ReadLine()!);
// Console.Write("Введите координату y точки B: ");
// double y2= Convert.ToDouble(Console.ReadLine()!);
// Console.Write("Введите координату z точки B: ");
// double z2 = Convert.ToDouble(Console.ReadLine()!);

// double distan = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
// Console.WriteLine($"Расстояние между А и В равно {distan:f2}");


/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine()!);
// int i = 1;
// int result = 0;
// while(i <= num){
//     result = Convert.ToInt32(Math.Pow(i, 3));
//     Console.Write($"{result}, ");
//     i++;
// }