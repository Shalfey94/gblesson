// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

// int n1 = number / 10000;
// int n2 = (number / 1000) % 10;
// int n4 = (number / 10) % 10;
// int n5 = number % 10;

// if (n1 == n5 && n2 == n4) Console.WriteLine("Да");
// else Console.WriteLine("Нет");


 if (number > 9999 && number < 100000)
 {
     Console.WriteLine(Palindrom(number) ? "да" : "нет");
 }
 else
 {
     Console.WriteLine("Некорректный ввод");
 }

 bool Palindrom(int num)
 {
     return num / 10000 == num % 10 && (num / 1000) % 10 == (num / 10) % 10;
 }

