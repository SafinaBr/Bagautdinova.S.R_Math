// Определение пространства имен CRE.MathTasks.Calculators
namespace CRE.MathTasks.Calculators;

// Объявление интерфейса ICalculator
public interface ICalculator
{
    // Метод для вычисления значения функции
    // Принимает параметр x и возвращает результат вычисления
    double Calculate(double x);
}
