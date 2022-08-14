// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();
System.Console.WriteLine();
int number = new Random().Next(100, 200);

System.Console.WriteLine($"Второй цифрой числа {number} является {number / 10 % 10} ");
System.Console.WriteLine(); 
