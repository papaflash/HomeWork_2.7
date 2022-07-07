using System;

namespace HomeWork_2._7_Task_02_CalculateScores
{
    internal class Program
    {
        //TODO: Посчтитать сумму, среднею арифметическую и вывести в консоль
        static void Main(string[] args)
        {
            string _fullName = "Shagov Alexander Valerevich";
            byte _age = 36;
            string _email = "shagov25@gmail.com";
            double _programmingScores = 90.56;
            double _mathScores = 80.78;
            double _physicsScores = 75.0;

            Console.WriteLine($"Ф.И.О. - {_fullName}");
            Console.WriteLine($"Возраст - {_age}");
            Console.WriteLine($"Адрес эл. Почты - {_email}");
            Console.WriteLine($"Баллы по программированию - {_programmingScores:(#)} Балл");
            Console.WriteLine($"Баллы по математике - {_mathScores:(#)} Балл");
            Console.WriteLine($"Баллы по физике - {_physicsScores:(#)} Баллов");

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для подсчета общего кол-ва баллов");
            Console.ReadKey();

            //============================================================================================
            double _sum = _programmingScores + _mathScores + _physicsScores;
            Console.WriteLine($"Общее кол-во баллов - {_sum:(#)} Балла");
            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для подсчета среднего арифметического");
            Console.ReadKey();
            double _average = (_programmingScores + _mathScores + _physicsScores) / 3;
            Console.WriteLine($"Среднее арифметическое - {_average:(#)} Баллов");
            Console.ReadKey();
        }
    }
}
