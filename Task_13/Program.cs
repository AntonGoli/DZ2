// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введи трёхзначное число: ");

int Digit3 = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(Digit3);
Console.WriteLine("вторая цифра этого числа -> "+stringNumber[1]);