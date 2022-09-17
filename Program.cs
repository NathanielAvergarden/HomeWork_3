// Домашняя работа № 3

/* Задача 19  Напишите программу, которая принимает на вход пятизначное число и проверяет,
является ли оно палиндромом.*/
/*
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
*/


/* Задача 21 Напишите программу, которая принимает на 
вход координаты двух точек и находит расстояние между ними в 3D */

// Действие 1) Зарандомим координаты точек a и b
/*
int ax = new Random().Next();
int ay = new Random().Next();
int az = new Random().Next();

int bx = new Random().Next();
int by = new Random().Next();
int bz = new Random().Next();

// Действие 2) Найдем расстояние между точками:

double temp = Math.Round(Math.Sqrt(Math.Pow((bx - ax),2) + Math.Pow((by - ay),2) + Math.Pow((bz - az),2)),2);

// Действие 3) Выведем temp:

System.Console.WriteLine(temp);
*/


/* Задача №23 Напишите программу, которая принимает на вход число (N) 
и выдает таблицу кубов чисел от 1 до N */

// Действие 1) Зарандомим число (N):

int number = new Random().Next(1,25);

// Действие 2) Выведем это число:

Console.WriteLine(number);

// Действие 3) Создадим таблицу через цикл:

for(int i = 1; i <= number; i++)

// Действие 4) Внутри цикла пропишем Кубическое значение:
{
    System.Console.WriteLine(Math.Pow(i,3));
}
