using CRE.MathTasks.Calculators;
using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;

namespace CRE.MathTasks;

public static class MathTasks
{
    public static void Task_78_V()
    {
        // Инициализация переменной cont, управляющей циклом, значением true
        var cont = true;

        // Цикл while, выполняющийся, пока cont равно truex
        while (cont)
        {
            // Выводит на консоль текст с просьбой ввести номер задачи, для выхода введите 9
            Console.WriteLine("Введите номер задачи, если хотите выйти, введите 9:");

            // Считывает введенный пользователем номер задачи
            var numberOfTask = Console.ReadLine();

            // Инициализация переменной calculator интерфейсом ICalculator
            ICalculator calculator = null;

            // Конструкция switch для выбора калькулятора в зависимости от введенного номера задачи
            switch (numberOfTask)
            {
                case "1":
                    calculator = new Function1_Task_78_V();
                    break;
                case "2":
                    calculator = new Function2_Task_78_V();
                    break;
                case "3":
                    calculator = new Function3_Task_78_V();
                    break;
                case "9":
                    // Если введен номер 9, устанавливает cont в false, чтобы выйти из цикла
                    cont = false;
                    break;
                default:
                    // В случае некорректного ввода номера задачи ничего не делает
                    break;
            }

            // Проверка, был ли выбран калькулятор (не осталась ли переменная calculator равной null)
            if (calculator == null)
            {
                // Выводит сообщение об ошибке и переходит к следующей итерации цикла
                Console.WriteLine("Неправильный номер");
                continue;
            }

            // Выводит на консоль текст с просьбой ввести значение a
            Console.WriteLine("Введите a:");

            // Считывает введенное пользователем значение a и преобразует его в тип int
            var a = int.Parse(Console.ReadLine());

            // Выводит на консоль текст с просьбой ввести значение b
            Console.WriteLine("Введите b:");

            // Считывает введенное пользователем значение b и преобразует его в тип int
            var b = int.Parse(Console.ReadLine());

            // Выводит на консоль текст с просьбой ввести значение h
            Console.WriteLine("Введите h:");

            // Считывает введенное пользователем значение h и преобразует его в тип int
            var h = int.Parse(Console.ReadLine());

            // Вызывает метод BuildTable из класса MathHelper, передавая значения a, b, h и выбранный калькулятор
            MathHelper.BuildTable(a, b, h, calculator);
        }
    }
    public static void Task_78_VI()
    {
        Console.WriteLine("Введите число a, b, h:");

        double a = double.Parse(Console.ReadLine());

        double b = double.Parse(Console.ReadLine());

        double h = double.Parse(Console.ReadLine());

        Console.WriteLine("Ответ:");

        Console.WriteLine("x\t\t result");
        for (double x = a; x < b; x += h)
        {
            double res = 0;
            if (x < a)
            {
                res = 0;
            }
            if (x > a)
            {
                res = (x - a)/(x + a);
            }
            if (x == a)
            {
                res = 1;
            }

            Console.WriteLine($"{x}\t\t {res}");
        }
    }
    public static void Task_37_I()
    {
        Console.WriteLine("Введите x:");

        double x = double.Parse(Console.ReadLine());

        double res = Math.Sqrt(Math.Pow(x, 4) + Math.Sqrt(Math.Abs(x + 1)));

        Console.WriteLine($"Ответ: {res}");


    }
    public static void Task_38_II()
    {
        Console.WriteLine("Введите а, b и с, d"); 

        double a = double.Parse(Console.ReadLine());

        double b = double.Parse(Console.ReadLine());

        double c = double.Parse(Console.ReadLine());

        double d = double.Parse(Console.ReadLine());

        double res = Math.Sqrt(Math.Pow((c - a), 2) + Math.Pow((d - b), 2));

        Console.WriteLine($"Ответ: {res}");


    }
    public static void Task_38_III()
    {
        Console.WriteLine("Введите число");

        int x = int.Parse(Console.ReadLine());
        
        if (x % 2 == 0)
        {
            Console.WriteLine("четное");
        }
        else
        {
            Console.WriteLine("нечетное");
        }
    }
    public static void Task_164_II()
    {
        char[] vowels =
            { 'а', 'я', 'у', 'ю', 'о', 'е', 'ё', 'э', 'и', 'ы' };

        string str = "Маша каталась на качельях раннним утром, когда был дождь";

        Console.WriteLine($"Строка: {str}");
        int counter = 0;
        for (int i = 0; i < str.Length; i++)
        {
            char elem = char.ToLower(str.ElementAt(i));
            if (vowels.Contains(elem))
            {
                counter = counter + 1;
            }
        }
        Console.WriteLine($"Гласных: {counter}");
    }
    public static void Task_164_III()
    {
        string str = "Маша каталась на качельях раннним утром, когда был дождь";

        Console.WriteLine($"Строка: {str}");

        string[] words = str.Split(' ');

        int maxChars = int.MaxValue;

        string needWord = string.Empty;

        for (int i = 0; i < words.Length; i++)
        {
            int numberOfChars = words[i].Length;

            if (maxChars > numberOfChars)
            {
                maxChars = numberOfChars;
                needWord = words[i];
            }
        }
        Console.WriteLine($"Нужное слово: {needWord}");
    }
    public static void Task_94_I()
    {
        Console.WriteLine("Введите значение n: ");

        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите значение x: ");

        int x = int.Parse(Console.ReadLine());

        double sum_result = 0;

        for (int i = 1; i <= n; i++)
        {
            sum_result += 1 / (i * x);
        }

        Console.WriteLine($"Сумма S для n={n} и x={x}: {sum_result}");
    }
    public static void Task_95_II()
    {
        Console.WriteLine("Введите значение k: ");

        int k = int.Parse(Console.ReadLine());

        double res = 0;

        for (int n = 1; n <= k; n++)
        {
            res +=
                Math.Pow((-1), (n + 1))
                /
                Math.Pow(n, 2);
        }

        Console.WriteLine($"Результат: {res}");
    }
    public static void Task_96_III()
    {
        double epsilon = 1e-6;

        double sum = 0.0;
        int i = 2;
        double term = Math.Pow((-1.0), i)
                /
                (Math.Pow(i, 2.0) - 1);

        while (Math.Abs(term) > epsilon)
        {
            sum += term;
            i++;
            term = 
                Math.Pow((-1.0), i) 
                / 
                (Math.Pow(i, 2.0) - 1);
        }

        Console.WriteLine($"Результат: {sum}");
    }
}
