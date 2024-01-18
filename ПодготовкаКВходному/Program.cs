using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Net.Http.Headers;
using System.Net.WebSockets;

namespace ПодготовкаКВходному
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Zadanie1
            Console.WriteLine("\r\nЗадание 1. Написать программу, которая запрашивает ввод с клавиатуры двух\r\nвещественных чисел и возводит первое введенное число в степень второго\r\nвведенного числа\r\n");
            Console.Write("Введите число, которое хотите возвести: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите число, в которое хотите возвести: ");
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Math.Pow(a, b);
            Console.WriteLine($"Результат: {c}");


            //Zadanie 2
            Console.WriteLine("\r\nЗадание 2. Написать программу, которая вычисляет периметр и площадь\r\nпрямоугольного треугольника по введенным пользователем координатам\r\nначальной и конечной точек гипотенузы.");
            Console.Write("Введите х1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите у1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите х2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите у2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());
            double x3 = x1;
            double y3 = y2;
            // Гипотенуза - длинна
            double hypotenuse = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            // Катет 1 - длинна
            double leg1 = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
            // Катет 2 - длинна
            double leg2 = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));
            double S = (leg1 * leg2) / 2;
            double P = leg1 + leg2 + hypotenuse;
            Console.WriteLine($"Периметр:{P} \r\nПлощадь:{S}");

            //Zadanie 3
            Console.WriteLine("\r\nЗадание 3. Напишите программу, которая проверяет, дает ли введенное с клавиатуры\r\nчисло одинаковый остаток при делении на 2 и на 3.");
            Console.Write("Введите число 1: ");
            int chislo = Convert.ToInt32(Console.ReadLine());
            if (chislo % 2 == chislo % 3)
            {
                Console.WriteLine("Данное число имеет одинаковый остаток");
            }
            else
            {
                Console.WriteLine("Данное число имеет НЕ одинаковый остаток");
            }

            //Zadanie 4
            Console.WriteLine("\r\nЗадание 4. Напишите программу, которая печатает в столбик все цифры введенного n\r\n значного (n от 1 до 10) числа в порядке возрастания разрядов.");
            Console.Write("Введите число: ");
            string str = Console.ReadLine();
            int length = Convert.ToInt32(str.Length);
            while (!(length >= 1 && length <= 10))
            {
                Console.Write("Попробуйте еще раз: ");
                str = Console.ReadLine();
                length = Convert.ToInt32(str.Length);
            }

            int n = Convert.ToInt32(str);
            Console.WriteLine(n % 10);
            while ((n /= 10) != 0)
            {
                Console.WriteLine(n % 10);
            }
            //Задание 5.

            Console.WriteLine("\r\nЗадание 5. Посчитайте значение следующего выражения при условии, что\r\nпользователь вводит с клавиатуры значения х и y:");
            Console.Write("Ведите х: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ведите у: ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Otvet: {0}", 1 + Math.Sin(x + 1) / Math.Cos(12 * y - 4));

            //Задание 6.

            Console.WriteLine("\r\nЗадание 6. Выведите на экран последовательность n первых чисел Фибоначчи (с\r\nуказанием их индекса), имеющих четные индексы. Количество чисел n\r\nпользователь вводит с клавиатуры. ");
            Console.Write("Введите количество чисел Фибоначи, которе хотите вывести на экран: ");
            int qantity = Convert.ToInt32(Console.ReadLine());
            int first = 0;
            int second = 1;
            int third = first + second;
            Console.WriteLine("Числа фибоначи:");
            if (qantity == 1)
            {
                Console.WriteLine(first);
            }
            else if (qantity == 2)
            {
                Console.WriteLine(first);
                Console.WriteLine(second);
            }
            else if (qantity == 3)
            {
                Console.WriteLine(first);
                Console.WriteLine(second);
                Console.WriteLine(third);
            }
            else
            {
                Console.WriteLine(first);
                Console.WriteLine(second);
                Console.WriteLine(third);
                while (qantity != 0)
                {
                    first = second;
                    second = third;
                    third = first + second;
                    Console.WriteLine(third);
                    qantity--;
                }
            }

            //задание 7. 
            Console.WriteLine("\r\nЗадание 7. Пользователь вводит число n с клавиатуры. Используя оператор цикла\r\nнеобходимо вычислить сумму первых n членов следующей\r\nпоследовательности: 1/2 + 2/3 + 3/4 + ...");
            Console.Write("Введите количество чисел: ");
            int qantity7 = Convert.ToInt32(Console.ReadLine());
            double chislitel = 1;
            double znamenatel = 2;
            double summ = 0;
            for (int i = 0; i < qantity7; i++)
            {
                summ = summ + (chislitel / znamenatel);
                chislitel = znamenatel;
                znamenatel++;
            }
            Console.WriteLine($"Ответ:{summ}");

            //задание 8
            Console.WriteLine("\r\nЗадание 8. Пользователь вводит результаты соревнований по плаванию трёх\r\nспортсменов. Необходимо выбрать лучший результат и вывести его на экран\r\nс сообщением, что это результат победителя заплыва.");
            Console.Write("Введите результаты ПЕРВОГО спортмена: ");
            double sp1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите результаты ВТОРОГО спортмена: ");
            double sp2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите результаты ТРЕТЬЕГО спортмена: ");
            double sp3 = Convert.ToDouble(Console.ReadLine());
            
            double max = Math.Max(sp1, sp2);
            max = Math.Max(max, sp3);
            Console.WriteLine($"Результат победителя заплыва: {max}");
        }

    }
}