using System.ComponentModel.Design;

namespace pr7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Задание 1
            int number = 10;
            if (number > 0)
            {
                Console.WriteLine("Число положительное");

            }
            else if (number < 0) { 
              Console.WriteLine("Число отрицательное");
            }
            else
            {
                Console.WriteLine("Число равно нулю");
            }

            // Задание 2
            int age = int.Parse(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("Вы совершеннолетнй");
            }
            else 
            {
              Console.WriteLine("Вы несовершеннолетний");  
            }

            // Задание 3
            int num = 7;
            if ((num % 2) == 0)
            {
                Console.WriteLine("Число чётное");
            }
            else
            {
                Console.WriteLine("Число нечётное");
            }

            // Задание 4
            int a = -5;
            int b = 2;
            if (a > 0 && b > 0)
            {
                Console.WriteLine("Оба числа положительные");
            }
            else if (a > 0 || b < 0)
            {
                Console.WriteLine("Хотя бы одно число положительное");
            }
            if (a < 0)
            {
                Console.WriteLine("Число a отрицательное");
            }

            // Задание 5
            int grade = int.Parse(Console.ReadLine());
            if (grade < 3)
            {
                Console.WriteLine("неудовлетворительно");
            }
            else if (grade == 3)
            {
                Console.WriteLine("удовлетворительно");
            }
            else if (grade == 4)
            {
                Console.WriteLine("хорошо");
            }
            else if (grade == 5)
            {
                Console.WriteLine("отлично");
            }

            // Задание 6
            int min = 10;
            int max = 100;
            int x = int.Parse(Console.ReadLine());
            if (max >= x && x >= min) 
            {
                Console.WriteLine("Число в диапазоне");
            }
            else
            {
                Console.WriteLine("Число не в диапазоне");
            }

            // Задание 7

            int a1 = int.Parse(Console.ReadLine());
            int a2 = int.Parse(Console.ReadLine());
            int a3 = int.Parse(Console.ReadLine());
            if ((a1 == a2) && (a2 == a3) && (a1 == a3))
            {
                Console.WriteLine("Равносторонний");
            }
            else if ((a1 != a2) && ( a2 != a3) && (a1 != a3))         
            {
                Console.WriteLine("Все разные");
            }
            else
            {
                Console.WriteLine("Равнобедренный");
            }

            // Задание 7
            int x1 = int.Parse(Console.ReadLine());
            int sale = x1 - ((x1 / 100) * 10);
            int sale2 = x1 - ((x1 / 100) * 5);
            if (x1 >= 5000)
            {
                Console.WriteLine("Ваша итоговая сумма составит = " + sale);
            }
            else if (x1 < 5000 && x1 > 2000)
            {
                Console.WriteLine("Ваша итоговая сумма составит = " + sale2);
            }
            else 
            {
                Console.WriteLine("Ваша итоговая сумма составит = " + x1);
            }
        }
    }
}
