using System.Runtime.InteropServices;
// Напишите программу, 
//которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
int A = int.Parse(Console.ReadLine());
string num = Convert.ToString(A);
if ((num[0] == num[4]) && (num[1] == num[3]))
    Console.WriteLine($"{num} -> yes");
else
    Console.WriteLine($"{num} -> no");