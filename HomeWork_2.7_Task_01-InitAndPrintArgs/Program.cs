using System;

namespace HomeWork_2._7_Task_01_InitAndPrintArgs
{
    internal class Program
    {
        /* TODO:
            Ф. И. О.
            Возраст
            Email
            Баллы по программированию
            Баллы по математике
            Баллы по физике
         */
        static void Main(string[] args)
        {
            string _fullName = "Shagov Alexander Valerevich";
            int _age = 36;
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

            Console.ReadKey();
        }
    }
}
