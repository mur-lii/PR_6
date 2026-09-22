//***********************************************************************
//* Практичсекая работа № 6                                             *
//* Выполнила: Трухина Е.Д., группа 2ИСП                                *
//* Задание: составить программу разветвляющейся усложненной структуры  *
//***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.Title = "Практичсекая работа 6";
            Console.ForegroundColor = ConsoleColor.White;

            double N;

            Console.WriteLine("Здравствуй!");
            Console.Write("Введите N = ");

            try
            {
                N = Convert.ToDouble(Console.ReadLine());//Конвертируем вводимое число в doble

                if (N >= 1000 && N <= 9999)//проверяем является ли число четырехзначным
                {
                    double ostatok = N % 2;

                    switch (ostatok)
                    {
                        case 0:
                            Console.WriteLine("Число " + N + " является четным четырехзначным числом.");
                            break;
                        case 1:
                            Console.WriteLine("Число " + N + " является четырехзначным, но нечетным.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Число " + N + " не является четырехзначным.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Вы ввели не число! Пожалуйста, введите цифры.");//Если пользователь вводит символы вместо цифр
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ошибка: Введенное число слишком большое или слишком маленькое.");//Если введенное число слишком большое или слишком маленькое для типа double
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла непредвиденная ошибка: " + ex.Message);//любая другая ошибка
            }
            Console.ReadKey();

        }
    }
}