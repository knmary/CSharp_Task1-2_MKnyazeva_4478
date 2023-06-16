//Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
Console.WriteLine("Введите число №1");
string inputstring1 = Console.ReadLine();
int number1 = Convert.ToInt32(inputstring1);
Console.WriteLine("Введите число №2");
string inputstring2 = Console.ReadLine();
int number2 = Convert.ToInt32(inputstring2);
Console.WriteLine("Введите число №3");
string inputstring3 = Console.ReadLine();
int number3 = Convert.ToInt32(inputstring3);
if (number1 > number2)
{
if (number1 > number3)
{
Console.WriteLine($"Максимальное число {number1}");
}}
else
{
if (number3 > number2)
{
Console.WriteLine($"Максимальное число {number3}");   
}
else 
{
Console.WriteLine($"Максимальное число {number2}");
}
}