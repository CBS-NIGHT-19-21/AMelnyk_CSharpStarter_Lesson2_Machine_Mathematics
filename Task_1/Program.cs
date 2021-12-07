﻿using System;
// Создать проект по шаблону Console Application. 
// Дано значение числа pi, которое равно 3,141592653 и значение числа Эйлера е,
// которое равно 2,7182818284 590452.
// Необходимо создать две переменные, присвоить им значения числа pi и числа е
// и вывисти на экран без потери точности. 


namespace AMelnyk_CSharpStarter_Lesson2_Machine_Mathematics
{
    class Program
    {
        static void Main(string[] args)
        {
            // На 16 строке создаем переменную типа double
            // с именем pi и присваиваем ей значение 3.141592653.
            float pi = 3.141592653f;

            // На 21 строке создаем переменную типа double
            // с именем e и присваиваем ей значение 2.7182818284590452.
            double e = 2.7182818284590452d;

            // На 24 и 25 стоках выводим значение переменных pi и е на екран консоли.
            Console.WriteLine($"Значение числа pi=  {pi}");
            Console.WriteLine($"Значение числа Эйлера е=  {e}");
            Console.ReadKey();
        }
    }
}
