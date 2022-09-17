// Домашняя работа № 3

/* Задача 19  Напишите программу, которая принимает на вход пятизначное число и проверяет,
является ли оно палиндромом.*/

// Действие 1) Зарандомим неизвестное число:
int number = new Random().Next(10000,99999);
// Действие 2) Посмотрим на это число:
System.Console.WriteLine(number);
// Действие 3) Создадим массив с размером равному пяти:
int[] array = new int[5];
int firstNum = number / 10000;
int secondNum = number / 1000 % 10;
int thirdNum = number / 100 % 10;
int fourthNum = number / 10 % 10;
int fifthNum = number / 1 % 10;

System.Console.WriteLine(firstNum);
System.Console.WriteLine(secondNum);
System.Console.WriteLine(thirdNum);
System.Console.WriteLine(fourthNum);
System.Console.WriteLine(fifthNum);

    if(firstNum == fifthNum & secondNum == fourthNum)
    {
        System.Console.WriteLine(number + "Палиндром");
    }
    else
    {
        System.Console.WriteLine("Число не является Палиндромом");
    }
