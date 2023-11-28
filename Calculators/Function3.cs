// Определение пространства имен CRE.MathTasks.Calculators
namespace CRE.MathTasks.Calculators;

// Объявление класса Function3, реализующего интерфейс ICalculator
public class Function3 : ICalculator
{
    // Реализация метода Calculate из интерфейса ICalculator
    // для вычисления значения функции для заданного аргумента x
    public double Calculate (double x)
    {
        return Math.Sqrt(Math.Pow (x,2) - 1);
    }
}
