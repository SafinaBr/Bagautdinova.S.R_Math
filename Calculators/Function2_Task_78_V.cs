// Определение пространства имен CRE.MathTasks.Calculators
namespace CRE.MathTasks.Calculators;

// Объявление класса Function2, реализующего интерфейс ICalculator
public class Function2_Task_78_V : ICalculator
{
    // Реализация метода Calculate из интерфейса ICalculator
    // для вычисления значения функции для заданного аргумента x
    public double Calculate(double x)
    {
        return 1 / Math.Pow(x, 2) - 1;
    }
}
