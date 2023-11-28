// Импорт пространства имен с калькуляторами из библиотеки CRE.MathTasks.Calculators
using CRE.MathTasks.Calculators;

// Определение пространства имен CRE.MathTasks
namespace CRE.MathTasks;

// Объявление статического класса MathHelper
public static class MathHelper
{
    // Метод для построения таблицы значений функции
    // Принимает параметры: начальное значение a, конечное значение b, шаг h и калькулятор
    public static void BuildTable(double a, double b, double h, ICalculator calculator)
    {
        // Вывод заголовка таблицы на консоль
        Console.WriteLine("x\t\t y");

        // Итерация по значениям x с шагом h в интервале [a, b]
        for (double x = a; x <= b; x += h)
        {
            // Вычисление значения функции y = f(x) с использованием калькулятора
            double y = calculator.Calculate(x);

            // Проверка, определена ли функция в данной точке
            if (!double.IsNaN(y))
            {
                // Вывод значений x и y в таблицу
                Console.WriteLine($"{x}\t\t {y}");
            }
            else
            {
                // Если функция не определена, вывод сообщения
                Console.WriteLine($"{x}\t\t Функция не определена");
            }
        }
    }
}
