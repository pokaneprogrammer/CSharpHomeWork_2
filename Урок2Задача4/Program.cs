// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();
System.Console.WriteLine();

int dayNumber = new Random().Next(1, 7);
string[] Days = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };
string txtResult = "";

if (dayNumber > 5) txtResult = $". Выходной день";
else txtResult = $", рабочий день.";

System.Console.WriteLine();
System.Console.WriteLine($"{dayNumber} день недели - это {Days[dayNumber - 1]}{txtResult}");
System.Console.WriteLine();