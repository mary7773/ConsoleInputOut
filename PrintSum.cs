//Write a program that reads 3 integer numbers from the console and prints their sum.
using System;

class Program
{
    static void Main()
    {
        int number1 = int.Parse(Console.ReadLine());//2
        int number2 = int.Parse(Console.ReadLine());//3
        int number3 = int.Parse(Console.ReadLine());//4
        int sum = number1 + number2 + number3;//sum = 9

        Console.WriteLine(sum);
    }
}

