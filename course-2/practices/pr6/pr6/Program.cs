namespace pr5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание 1 
            int a = 12;
            int b = 15;
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);

            // Задание 2 
            Console.WriteLine("введите ваше имя");
            string name = Console.ReadLine();
            Console.WriteLine("Привет " + name);

            // Задание 3 
            Console.WriteLine("введите первое число");
            int a1 = int.Parse(Console.ReadLine());
            Console.WriteLine("введите второе число");
            int a2 = int.Parse(Console.ReadLine());
            Console.WriteLine(a1 + a2);

            // Задание 4
            Console.WriteLine("введите ширину");
            int weight = int.Parse(Console.ReadLine());
            Console.WriteLine("введите высоту");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine(weight * height);

            // Задание 5
            Console.WriteLine("введите температуру в градусах цельсия");
            float C = float.Parse(Console.ReadLine());
            float F = (C * 9 / 5) + 32;
            Console.WriteLine("Температура в градусах кельвина будет равна " + (float)F);

            // Задание 6
            Console.WriteLine("введите первое число");
            float b1 = float.Parse(Console.ReadLine());
            Console.WriteLine("введите второе число");
            float b2 = float.Parse(Console.ReadLine());
            Console.WriteLine("введите третье  число");
            float b3 = float.Parse(Console.ReadLine());
            float mid = (b1 + b2 + b3) / 3;
            Console.WriteLine((float)mid);

            // Задание 7
            Console.WriteLine("введите первое число");
            float f1 = float.Parse(Console.ReadLine());
            Console.WriteLine("введите второе число");
            float f2 = float.Parse(Console.ReadLine());
            Console.WriteLine((float)a + (float)b);
            Console.WriteLine((float)a - (float)b);
            Console.WriteLine((float)a * (float)b);
            Console.WriteLine((float)a / (float)b);







        }
    }
}
