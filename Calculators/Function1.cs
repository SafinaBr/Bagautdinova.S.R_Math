// Определение пространства имен CRE.MathTasks.Calculators
namespace CRE.MathTasks.Calculators;

// Объявление класса Function1, реализующего интерфейс ICalculator
public class Function1 : ICalculator
{
    // Реализация метода Calculate из интерфейса ICalculator
    // для вычисления значения функции для заданного аргумента x
    public double Calculate(double x)
    {
        // Возвращаем результат вычисления функции 1 / (1 + x)^2
        return 1 / Math.Pow(1 + x, 2);
    }
}
