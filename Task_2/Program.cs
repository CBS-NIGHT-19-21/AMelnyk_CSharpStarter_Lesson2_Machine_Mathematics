using System;
// Используя Visual Studio, создайте проект по шаблону Console Application. 
// Создать три строковые переменные и присвойте им значения: 
// "\nмоя строка 1";
// "\tмоя строка 2";
// "\aмоя строка 3";
// Выведите значение каждой переменной на экран.


namespace AMelnyk_CSharpStarter_Lesson2_Machine_Mathematics
{
    class Program
    {
        static void Main(string[] args)
        {
            // На 18, 19 и 20 строках создаем переменные типа string
            // с именами str1, str2, str3 и присваиваем им такст.
            string str1 = "\n моя строка 1";
            string str2 = "\t моя строка 1";
            string str3 = "\a моя строка 1";

            // На 23, 24 и и 25 стоках выводим значение переменных str1, str2, str3 на екран консоли.
            Console.WriteLine("Эскейп последовательность - новая строка" + str1);
            Console.WriteLine("Эскейп последовательность - табуляция" + str2);
            Console.WriteLine("Эскейп последовательность - звуковой сигнал" + str3);

            Console.ReadKey();
        }
    }
}
